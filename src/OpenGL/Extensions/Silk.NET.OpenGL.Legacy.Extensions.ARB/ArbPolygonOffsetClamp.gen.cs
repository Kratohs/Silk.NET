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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_polygon_offset_clamp")]
    public abstract unsafe partial class ArbPolygonOffsetClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_polygon_offset_clamp";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="units">
        /// To be added.
        /// </param>
        /// <param name="clamp">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
        public abstract void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        public ArbPolygonOffsetClamp(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

