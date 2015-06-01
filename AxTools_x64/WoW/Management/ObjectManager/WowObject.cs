﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AxTools.WoW.Management.ObjectManager
{
    /// <summary>
    ///     World of Warcraft game object
    /// </summary>
    public sealed class WowObject
    {
        internal WowObject(IntPtr pAddress)
        {
            Address = pAddress;
            WoWObjectsInfo info = WoWManager.WoWProcess.Memory.Read<WoWObjectsInfo>(Address);
            GUID = info.GUID;
            Bobbing = info.Bobbing == 1;
            Location = info.Location;
        }

        internal readonly IntPtr Address;

        internal static readonly Dictionary<UInt128, string> Names = new Dictionary<UInt128, string>();

        internal readonly UInt128 GUID;

        internal readonly WowPoint Location;

        internal readonly bool Bobbing;

        private UInt128 mOwnerGUID;
        internal UInt128 OwnerGUID
        {
            get
            {
                if (mOwnerGUID == UInt128.Zero)
                {
                    IntPtr tempOwner = WoWManager.WoWProcess.Memory.Read<IntPtr>(Address + WowBuildInfoX64.GameObjectOwnerGUIDBase);
                    mOwnerGUID = WoWManager.WoWProcess.Memory.Read<UInt128>(tempOwner + WowBuildInfoX64.GameObjectOwnerGUIDOffset);
                }
                return mOwnerGUID;
            }
        }

        internal string Name
        {
            get
            {
                string temp;
                if (!Names.TryGetValue(GUID, out temp))
                {
                    try
                    {
                        IntPtr nameBase = WoWManager.WoWProcess.Memory.Read<IntPtr>(Address + WowBuildInfoX64.GameObjectNameBase);
                        IntPtr nameAddress = WoWManager.WoWProcess.Memory.Read<IntPtr>(nameBase + WowBuildInfoX64.GameObjectNameOffset);
                        temp = Encoding.UTF8.GetString(WoWManager.WoWProcess.Memory.ReadBytes(nameAddress, 80)).Split('\0')[0];
                        Names.Add(GUID, temp);
                    }
                    catch
                    {
                        return string.Empty;
                    }
                }
                return temp;
            }
        }

        private uint mEntryID;
        internal uint EntryID
        {
            get
            {
                if (mEntryID == 0)
                {
                    IntPtr descriptors = WoWManager.WoWProcess.Memory.Read<IntPtr>(Address + WowBuildInfoX64.GameObjectOwnerGUIDBase);
                    mEntryID = WoWManager.WoWProcess.Memory.Read<uint>(descriptors + WowBuildInfoX64.GameObjectEntryID);
                }
                return mEntryID;
            }
        }

    }
}