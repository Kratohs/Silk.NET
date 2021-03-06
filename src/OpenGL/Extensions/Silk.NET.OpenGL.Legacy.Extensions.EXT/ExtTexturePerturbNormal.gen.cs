// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_texture_perturb_normal")]
    public abstract unsafe partial class ExtTexturePerturbNormal : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_perturb_normal";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureNormalEXT")]
        public abstract void TextureNormal([Flow(FlowDirection.In)] EXT mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureNormalEXT")]
        public abstract void TextureNormal([Flow(FlowDirection.In)] TextureNormalModeEXT mode);

        public ExtTexturePerturbNormal(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

