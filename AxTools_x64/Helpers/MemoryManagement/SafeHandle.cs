﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace AxTools.Helpers.MemoryManagement
{
    [HostProtection(MayLeakOnAbort = true)]
    [SuppressUnmanagedCodeSecurity]
    public class SafeMemHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeMemHandle() : base(true)
        {

        }

        [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
        public SafeMemHandle(IntPtr handle) : base(true)
        {
            SetHandle(handle);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        protected internal static extern bool CloseHandle(IntPtr hObject);

        #region Overrides of SafeHandle

        /// <summary>
        ///     When overridden in a derived class, executes the code required to free the handle.
        /// </summary>
        /// <returns>
        ///     true if the handle is released successfully; otherwise, in the event of a catastrophic failure, false. In this
        ///     case, it generates a releaseHandleFailed MDA Managed Debugging Assistant.
        /// </returns>
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            Console.WriteLine("Releasing handle on " + handle.ToString("X"));
            return CloseHandle(handle);
        }

        #endregion
    }
}
