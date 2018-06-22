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
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Bind a framebuffer to a framebuffer target
        /// </summary>
        /// <param name="target">
        /// Specifies the framebuffer target of the binding operation.
        /// </param>
        /// <param name="framebuffer">
        /// Specifies the name of the framebuffer object to bind.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glBindFramebuffer")]
        public static void BindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint framebuffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Bind a renderbuffer to a renderbuffer target
        /// </summary>
        /// <param name="target">
        /// Specifies the renderbuffer target of the binding operation. target must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer">
        /// Specifies the name of the renderbuffer object to bind.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glBindRenderbuffer")]
        public static void BindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, uint renderbuffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Copy a block of pixels from the read framebuffer to the draw framebuffer
        /// </summary>
        /// <param name="srcX0">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcY0">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcX1">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="srcY1">
        /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
        /// </param>
        /// <param name="dstX0">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstY0">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstX1">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="dstY1">
        /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
        /// </param>
        /// <param name="mask">
        /// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are ColorBufferBit, DepthBufferBit and StencilBufferBit.
        /// </param>
        /// <param name="filter">
        /// Specifies the interpolation to be applied if the image is stretched. Must be Nearest or Linear.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glBlitFramebuffer")]
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Check the completeness status of a framebuffer
        /// </summary>
        /// <param name="target">
        /// Specify the target of the framebuffer completeness check.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glCheckFramebufferStatus")]
        public static OpenTK.Graphics.OpenGL4.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete framebuffer objects
        /// </summary>
        /// <param name="framebuffers">
        /// [length: n]
        /// A pointer to an array containing n framebuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteFramebuffers")]
        public static void DeleteFramebuffer([CountAttribute(Parameter = "n")] uint framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete framebuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// A pointer to an array containing n framebuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteFramebuffers")]
        public static void DeleteFramebuffers(int n, [CountAttribute(Parameter = "n")] uint[] framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete framebuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// A pointer to an array containing n framebuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteFramebuffers")]
        public static void DeleteFramebuffers(int n, [CountAttribute(Parameter = "n")] ref uint framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete framebuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer objects to be deleted.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// A pointer to an array containing n framebuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteFramebuffers")]
        public static unsafe void DeleteFramebuffers(int n, [CountAttribute(Parameter = "n")] uint* framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete renderbuffer objects
        /// </summary>
        /// <param name="renderbuffers">
        /// [length: n]
        /// A pointer to an array containing n renderbuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteRenderbuffers")]
        public static void DeleteRenderbuffer([CountAttribute(Parameter = "n")] uint renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete renderbuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// A pointer to an array containing n renderbuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteRenderbuffers")]
        public static void DeleteRenderbuffers(int n, [CountAttribute(Parameter = "n")] uint[] renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete renderbuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// A pointer to an array containing n renderbuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteRenderbuffers")]
        public static void DeleteRenderbuffers(int n, [CountAttribute(Parameter = "n")] ref uint renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Delete renderbuffer objects
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer objects to be deleted.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// A pointer to an array containing n renderbuffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glDeleteRenderbuffers")]
        public static unsafe void DeleteRenderbuffers(int n, [CountAttribute(Parameter = "n")] uint* renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Attach a renderbuffer as a logical buffer to the currently bound framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the framebuffer target. target must be DrawFramebuffer, ReadFramebuffer, or Framebuffer. Framebuffer is equivalent to DrawFramebuffer.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment point of the framebuffer.
        /// </param>
        /// <param name="renderbuffertarget">
        /// Specifies the renderbuffer target and must be Renderbuffer.
        /// </param>
        /// <param name="renderbuffer">
        /// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glFramebufferRenderbuffer")]
        public static void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, uint renderbuffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="attachment">
        /// </param>
        /// <param name="textarget">
        /// </param>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glFramebufferTexture1D")]
        public static void FramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="attachment">
        /// </param>
        /// <param name="textarget">
        /// </param>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glFramebufferTexture2D")]
        public static void FramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="attachment">
        /// </param>
        /// <param name="textarget">
        /// </param>
        /// <param name="texture">
        /// </param>
        /// <param name="level">
        /// </param>
        /// <param name="zoffset">
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glFramebufferTexture3D")]
        public static void FramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level, int zoffset)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
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
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glFramebufferTextureLayer")]
        public static void FramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, int layer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate framebuffer object names
        /// </summary>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenFramebuffers")]
        public static uint GenFramebuffer()
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer object names to generate.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenFramebuffers")]
        public static void GenFramebuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer object names to generate.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenFramebuffers")]
        public static void GenFramebuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate framebuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of framebuffer object names to generate.
        /// </param>
        /// <param name="framebuffers">
        /// [length: n]
        /// Specifies an array in which the generated framebuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenFramebuffers")]
        public static unsafe void GenFramebuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* framebuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate renderbuffer object names
        /// </summary>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenRenderbuffers")]
        public static uint GenRenderbuffer()
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer object names to generate.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenRenderbuffers")]
        public static void GenRenderbuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer object names to generate.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenRenderbuffers")]
        public static void GenRenderbuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate renderbuffer object names
        /// </summary>
        /// <param name="n">
        /// Specifies the number of renderbuffer object names to generate.
        /// </param>
        /// <param name="renderbuffers">
        /// [length: n]
        /// Specifies an array in which the generated renderbuffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenRenderbuffers")]
        public static unsafe void GenRenderbuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* renderbuffers)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Generate mipmaps for a specified texture target
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture whose mimaps to generate is bound. target must be Texture1D, Texture2D, Texture3D, Texture1DArray, Texture2DArray or TextureCubeMap.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGenerateMipmap")]
        public static void GenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about attachments of a bound framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment within target
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of attachment to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a variable receive the value of pname for attachment.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about attachments of a bound framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment within target
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of attachment to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a variable receive the value of pname for attachment.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about attachments of a bound framebuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation.
        /// </param>
        /// <param name="attachment">
        /// Specifies the attachment within target
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of attachment to query.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a variable receive the value of pname for attachment.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static unsafe void GetFramebufferAttachmentParameter(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about a bound renderbuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation. target must be Renderbuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of an array to receive the value of the queried parameter.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetRenderbufferParameteriv")]
        public static void GetRenderbufferParameter(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about a bound renderbuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation. target must be Renderbuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of an array to receive the value of the queried parameter.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetRenderbufferParameteriv")]
        public static void GetRenderbufferParameter(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Retrieve information about a bound renderbuffer object
        /// </summary>
        /// <param name="target">
        /// Specifies the target of the query operation. target must be Renderbuffer.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of an array to receive the value of the queried parameter.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glGetRenderbufferParameteriv")]
        public static unsafe void GetRenderbufferParameter(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Determine if a name corresponds to a framebuffer object
        /// </summary>
        /// <param name="framebuffer">
        /// Specifies a value that may be the name of a framebuffer object.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glIsFramebuffer")]
        public static bool IsFramebuffer(uint framebuffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Determine if a name corresponds to a renderbuffer object
        /// </summary>
        /// <param name="renderbuffer">
        /// Specifies a value that may be the name of a renderbuffer object.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glIsRenderbuffer")]
        public static bool IsRenderbuffer(uint renderbuffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Establish data storage, format and dimensions of a renderbuffer object's image
        /// </summary>
        /// <param name="target">
        /// Specifies a binding to which the target of the allocation and must be Renderbuffer.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format to use for the renderbuffer object's image.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the renderbuffer, in pixels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the renderbuffer, in pixels.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glRenderbufferStorage")]
        public static void RenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, int width, int height)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_framebuffer_object|VERSION_3_0]
        /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
        /// </summary>
        /// <param name="target">
        /// Specifies a binding to which the target of the allocation and must be Renderbuffer.
        /// </param>
        /// <param name="samples">
        /// Specifies the number of samples to be used for the renderbuffer object's storage.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format to use for the renderbuffer object's image.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the renderbuffer, in pixels.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the renderbuffer, in pixels.
        /// </param>
        [AutoGenerated(Category = "ARB_framebuffer_object|VERSION_3_0", Version = "3.0", EntryPoint = "glRenderbufferStorageMultisample")]
        public static void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, int samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, int width, int height)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(21)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindFramebuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, uint framebuffer);

        [Slot(27)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindRenderbuffer(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, uint renderbuffer);

        [Slot(53)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.OpenGL4.ClearBufferMask mask, OpenTK.Graphics.OpenGL4.BlitFramebufferFilter filter);

        [Slot(61)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern OpenTK.Graphics.OpenGL4.FramebufferErrorCode glCheckFramebufferStatus(OpenTK.Graphics.OpenGL4.FramebufferTarget target);

        [Slot(195)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glDeleteFramebuffers(int n, [CountAttribute(Parameter = "n")] uint* framebuffers);

        [Slot(204)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glDeleteRenderbuffers(int n, [CountAttribute(Parameter = "n")] uint* renderbuffers);

        [Slot(289)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferRenderbuffer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.RenderbufferTarget renderbuffertarget, uint renderbuffer);

        [Slot(293)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture1D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level);

        [Slot(294)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture2D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level);

        [Slot(295)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture3D(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.TextureTarget textarget, uint texture, int level, int zoffset);

        [Slot(298)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTextureLayer(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, uint texture, int level, int layer);

        [Slot(307)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGenFramebuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* framebuffers);

        [Slot(313)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGenRenderbuffers(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* renderbuffers);

        [Slot(303)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGenerateMipmap(OpenTK.Graphics.OpenGL4.GenerateMipmapTarget target);

        [Slot(366)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetFramebufferAttachmentParameteriv(OpenTK.Graphics.OpenGL4.FramebufferTarget target, OpenTK.Graphics.OpenGL4.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL4.FramebufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

        [Slot(524)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetRenderbufferParameteriv(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

        [Slot(619)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern byte glIsFramebuffer(uint framebuffer);

        [Slot(631)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern byte glIsRenderbuffer(uint renderbuffer);

        [Slot(990)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glRenderbufferStorage(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, int width, int height);

        [Slot(991)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glRenderbufferStorageMultisample(OpenTK.Graphics.OpenGL4.RenderbufferTarget target, int samples, OpenTK.Graphics.OpenGL4.RenderbufferStorage internalformat, int width, int height);
    }
}
