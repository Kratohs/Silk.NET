// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct ExportSemaphoreWin32HandleInfoKHR
    {
        public ExportSemaphoreWin32HandleInfoKHR
        (
            StructureType sType = StructureType.ExportSemaphoreWin32HandleInfoKhr,
            void* pNext = default,
            IntPtr* pAttributes = default,
            int dwAccess = default,
            IntPtr name = default
        )
        {
           SType = sType;
           PNext = pNext;
           PAttributes = pAttributes;
           DwAccess = dwAccess;
           Name = name;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public IntPtr* PAttributes;
/// <summary></summary>
        public int DwAccess;
/// <summary></summary>
        public IntPtr Name;
    }
}
