// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_line_rasterization")]
    public abstract unsafe partial class ExtLineRasterization : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_line_rasterization";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineStippleEXT")]
        public abstract void CmdSetLineStipple([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint lineStippleFactor, [Count(Count = 0)] ushort lineStipplePattern);

        public ExtLineRasterization(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

