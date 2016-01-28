﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace AxTools.Services
{
    internal static class KeyboardListener2
    {
        private static readonly Timer _timer = new Timer(50);
        private static KeyExt[] _uniqKeys;
        private static readonly Dictionary<uint, Keys[]> keysInstances = new Dictionary<uint, Keys[]>();
        private static uint keysInstancesCounter = 0;
        private static readonly List<Keys> _keys = new List<Keys>();
        private static readonly object _locker = new object();
        internal static readonly Stopwatch _stopwatch = new Stopwatch();
        internal static int counter;
        private static int _intLocker;

        /// <summary>
        ///     ATTENTION!
        ///     <para>As this event is static, it raise with all registered Keys, from all identifiers</para>
        /// </summary>
        internal static event Action<Keys> KeyPressed;

        static KeyboardListener2()
        {
            _timer.Elapsed += TimerOnElapsed;
        }

        /// <summary>
        ///     Add Keys to listener
        ///     <para>You can use this method up to uint.MaxValue times</para>
        /// </summary>
        /// <param name="keysToHandle">Set of Keys to listen to</param>
        /// <returns>Unique identifier of set. You should use it in RemoveKey</returns>
        internal static uint AddKeys(params Keys[] keysToHandle)
        {
            lock (_locker)
            {
                if (keysToHandle == null || keysToHandle.Length == 0)
                {
                    throw new ArgumentException("You should specify at least one key", "keysToHandle");
                }
                _timer.Enabled = false;
                while (_intLocker != 0)
                {
                    Thread.Sleep(1);
                }
                keysInstancesCounter++;
                keysInstances[keysInstancesCounter] = keysToHandle;
                RebuildUniqueKeys();
                _timer.Enabled = true;
                return keysInstancesCounter;
            }
        }

        /// <summary>
        ///     Removes set of Keys with certain identifier from listener
        /// </summary>
        /// <returns>True if identifier is present, false otherwise</returns>
        internal static bool RemoveKeys(uint identifier)
        {
            lock (_locker)
            {
                if (keysInstances.ContainsKey(identifier))
                {
                    _timer.Enabled = false;
                    while (_intLocker != 0)
                    {
                        Thread.Sleep(1);
                    }
                    keysInstances.Remove(identifier);
                    RebuildUniqueKeys();
                    if (_uniqKeys.Length != 0)
                    {
                        _timer.Enabled = true;
                    }
                    return true;
                }
                return false;
            }
        }

        private static void RebuildUniqueKeys()
        {
            HashSet<Keys> hashSet = new HashSet<Keys>();
            foreach (Keys key in keysInstances.Values.SelectMany(keys => keys))
            {
                hashSet.Add(key);
            }
            _uniqKeys = hashSet.Select(l => new KeyExt(l)).ToArray();
        }

        private static void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            counter++;
            _stopwatch.Start();
            Interlocked.Increment(ref _intLocker);
            try
            {
                foreach (KeyExt keyExt in _uniqKeys)
                {
                    bool pressed = (GetAsyncKeyState((int)keyExt.Key) & 0x8000) != 0;
                    if (pressed && !keyExt.Pressed && KeyPressed != null)
                    {
                        KeyPressed(keyExt.Key);
                    }
                    keyExt.Pressed = pressed;
                }
            }
            finally
            {
                Interlocked.Decrement(ref _intLocker);
            }
            _stopwatch.Stop();
        }

        private class KeyExt
        {
            internal readonly Keys Key;
            internal bool Pressed;

            internal KeyExt(Keys pKey)
            {
                Key = pKey;
                Pressed = false;
            }

        }

        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int vKey);

    }
}