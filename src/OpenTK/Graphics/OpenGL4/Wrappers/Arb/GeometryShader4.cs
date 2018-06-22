//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "GeometryShader4" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_geometry_shader4]
            /// Attach a level of a texture object as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// Specifies the framebuffer target. target must be DrawFramebuffer, ReadFramebuffer, or Framebuffer. Framebuffer is equivalent to DrawFramebuffer.
            /// </param>
            /// <param name="attachment">
            /// Specifies the attachment point of the framebuffer. attachment must be ColorAttachmenti, DepthAttachment, StencilAttachment or DepthStencilAttachment.
            /// </param>
            /// <param name="texture">
            /// Specifies the texture object to attach to the framebuffer attachment point named by attachment.
            /// </param>
            /// <param name="level">
            /// Specifies the mipmap level of texture to attach.
            /// </param>
            [AutoGenerated(Category = "ARB_geometry_shader4", Version = "", EntryPoint = "glFramebufferTextureARB")]
            public static void FramebufferTexture(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_geometry_shader4]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="attachment">
            /// </param>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="face">
            /// </param>
            [AutoGenerated(Category = "ARB_geometry_shader4", Version = "", EntryPoint = "glFramebufferTextureFaceARB")]
            public static void FramebufferTextureFace(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, OpenTK.Graphics.OpenGL4.TextureTarget face)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_geometry_shader4]
            /// Attach a single layer of a texture to a framebuffer
            /// </summary>
            /// <param name="target">
            /// Specifies the framebuffer target. target must be DrawFramebuffer, ReadFramebuffer, or Framebuffer. Framebuffer is equivalent to DrawFramebuffer.
            /// </param>
            /// <param name="attachment">
            /// Specifies the attachment point of the framebuffer. attachment must be ColorAttachmenti, DepthAttachment, StencilAttachment or DepthStencilAttachment.
            /// </param>
            /// <param name="texture">
            /// Specifies the texture object to attach to the framebuffer attachment point named by attachment.
            /// </param>
            /// <param name="level">
            /// Specifies the mipmap level of texture to attach.
            /// </param>
            /// <param name="layer">
            /// Specifies the layer of texture to attach.
            /// </param>
            [AutoGenerated(Category = "ARB_geometry_shader4", Version = "", EntryPoint = "glFramebufferTextureLayerARB")]
            public static void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, int layer)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_geometry_shader4]
            /// Specify a parameter for a program object
            /// </summary>
            /// <param name="program">
            /// Specifies the name of a program object whose parameter to modify.
            /// </param>
            /// <param name="pname">
            /// Specifies the name of the parameter to modify.
            /// </param>
            /// <param name="value">
            /// Specifies the new value of the parameter specified by pname for program.
            /// </param>
            [AutoGenerated(Category = "ARB_geometry_shader4", Version = "", EntryPoint = "glProgramParameteriARB")]
            public static void ProgramParameter(uint program, OpenTK.Graphics.OpenGL4.AssemblyProgramParameterArb pname, int value)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(296)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureARB(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level);

            [Slot(297)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureFaceARB(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, OpenTK.Graphics.OpenGL4.TextureTarget face);

            [Slot(299)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureLayerARB(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, int layer);

            [Slot(836)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glProgramParameteriARB(uint program, OpenTK.Graphics.OpenGL4.AssemblyProgramParameterArb pname, int value);
        }
    }
}
