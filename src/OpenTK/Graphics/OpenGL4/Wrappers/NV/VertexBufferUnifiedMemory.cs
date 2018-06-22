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
        /// Contains native bindings to functions in the category "VertexBufferUnifiedMemory" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="address">
            /// </param>
            /// <param name="length">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glBufferAddressRangeNV")]
            public static void BufferAddressRange(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory pname, uint index, ulong address, int length)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="address">
            /// </param>
            /// <param name="length">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glBufferAddressRangeNV")]
            public static void BufferAddressRange(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory pname, uint index, ulong address, IntPtr length)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="size">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glColorFormatNV")]
            public static void ColorFormat(int size, OpenTK.Graphics.OpenGL4.PixelType type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glEdgeFlagFormatNV")]
            public static void EdgeFlagFormat(int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glFogCoordFormatNV")]
            public static void FogCoordFormat(OpenTK.Graphics.OpenGL4.PixelType type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="value">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="result">
            /// [length: COMPSIZE(value)]
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glGetIntegerui64i_vNV")]
            public static void GetIntegerui64(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory value, uint index, [OutAttribute, CountAttribute(Computed = "value")] ulong[] result)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="value">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="result">
            /// [length: COMPSIZE(value)]
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glGetIntegerui64i_vNV")]
            public static void GetIntegerui64(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory value, uint index, [OutAttribute, CountAttribute(Computed = "value")] out ulong result)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="value">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="result">
            /// [length: COMPSIZE(value)]
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glGetIntegerui64i_vNV")]
            public static unsafe void GetIntegerui64(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory value, uint index, [OutAttribute, CountAttribute(Computed = "value")] ulong* result)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glIndexFormatNV")]
            public static void IndexFormat(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glNormalFormatNV")]
            public static void NormalFormat(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="size">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glSecondaryColorFormatNV")]
            public static void SecondaryColorFormat(int size, OpenTK.Graphics.OpenGL4.ColorPointerType type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="size">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glTexCoordFormatNV")]
            public static void TexCoordFormat(int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// Specify the organization of vertex arrays
            /// </summary>
            /// <param name="index">
            /// The generic vertex attribute array being described.
            /// </param>
            /// <param name="size">
            /// The number of values per vertex that are stored in the array.
            /// </param>
            /// <param name="type">
            /// The type of the data stored in the array.
            /// </param>
            /// <param name="normalized">
            /// The distance between elements within the buffer.
            /// </param>
            /// <param name="stride">
            /// The distance between elements within the buffer.
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glVertexAttribFormatNV")]
            public static void VertexAttribFormat(uint index, int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, bool normalized, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="index">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glVertexAttribIFormatNV")]
            public static void VertexAttribIFormat(uint index, int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_vertex_buffer_unified_memory]
            /// </summary>
            /// <param name="size">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="stride">
            /// </param>
            [AutoGenerated(Category = "NV_vertex_buffer_unified_memory", Version = "", EntryPoint = "glVertexFormatNV")]
            public static void VertexFormat(int size, OpenTK.Graphics.OpenGL4.VertexPointerType type, int stride)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(55)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBufferAddressRangeNV(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory pname, uint index, ulong address, IntPtr length);

            [Slot(89)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glColorFormatNV(int size, OpenTK.Graphics.OpenGL4.PixelType type, int stride);

            [Slot(259)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEdgeFlagFormatNV(int stride);

            [Slot(283)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFogCoordFormatNV(OpenTK.Graphics.OpenGL4.PixelType type, int stride);

            [Slot(381)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetIntegerui64i_vNV(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory value, uint index, [OutAttribute, CountAttribute(Computed = "value")] ulong* result);

            [Slot(602)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glIndexFormatNV(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride);

            [Slot(786)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glNormalFormatNV(OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride);

            [Slot(1009)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColorFormatNV(int size, OpenTK.Graphics.OpenGL4.ColorPointerType type, int stride);

            [Slot(1040)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexCoordFormatNV(int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride);

            [Slot(1280)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glVertexAttribFormatNV(uint index, int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, bool normalized, int stride);

            [Slot(1302)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glVertexAttribIFormatNV(uint index, int size, OpenTK.Graphics.OpenGL4.NvVertexBufferUnifiedMemory type, int stride);

            [Slot(1343)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glVertexFormatNV(int size, OpenTK.Graphics.OpenGL4.VertexPointerType type, int stride);
        }
    }
}
