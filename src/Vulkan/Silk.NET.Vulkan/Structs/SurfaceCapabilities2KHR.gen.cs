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
    public unsafe struct SurfaceCapabilities2KHR
    {
        public SurfaceCapabilities2KHR
        (
            StructureType sType = StructureType.SurfaceCapabilities2Khr,
            void* pNext = default,
            SurfaceCapabilitiesKHR surfaceCapabilities = default
        )
        {
           SType = sType;
           PNext = pNext;
           SurfaceCapabilities = surfaceCapabilities;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SurfaceCapabilitiesKHR SurfaceCapabilities;
    }
}
