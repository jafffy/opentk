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
        /// Contains native bindings to functions in the category "DrawInstanced" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a range of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, TrianglesLinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
            /// </param>
            /// <param name="first">
            /// Specifies the starting index in the enabled arrays.
            /// </param>
            /// <param name="count">
            /// Specifies the number of indices to be rendered.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawArraysInstancedARB")]
            public static void DrawArraysInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int first, int count, int primcount)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a set of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
            /// </param>
            /// <param name="count">
            /// Specifies the number of elements to be rendered.
            /// </param>
            /// <param name="type">
            /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// Specifies a pointer to the location where the indices are stored.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawElementsInstancedARB")]
            public static void DrawElementsInstanced(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int primcount)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a set of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
            /// </param>
            /// <param name="count">
            /// Specifies the number of elements to be rendered.
            /// </param>
            /// <param name="type">
            /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// Specifies a pointer to the location where the indices are stored.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawElementsInstancedARB")]
            public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[] indices, int primcount)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a set of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
            /// </param>
            /// <param name="count">
            /// Specifies the number of elements to be rendered.
            /// </param>
            /// <param name="type">
            /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// Specifies a pointer to the location where the indices are stored.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawElementsInstancedARB")]
            public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,] indices, int primcount)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a set of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
            /// </param>
            /// <param name="count">
            /// Specifies the number of elements to be rendered.
            /// </param>
            /// <param name="type">
            /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// Specifies a pointer to the location where the indices are stored.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawElementsInstancedARB")]
            public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,,] indices, int primcount)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_draw_instanced]
            /// Draw multiple instances of a set of elements
            /// </summary>
            /// <param name="mode">
            /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
            /// </param>
            /// <param name="count">
            /// Specifies the number of elements to be rendered.
            /// </param>
            /// <param name="type">
            /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// Specifies a pointer to the location where the indices are stored.
            /// </param>
            /// <param name="primcount">
            /// Specifies the number of instances of the specified range of indices to be rendered.
            /// </param>
            /// <typeparam name="T3"></typeparam>
            [AutoGenerated(Category = "ARB_draw_instanced", Version = "", EntryPoint = "glDrawElementsInstancedARB")]
            public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] ref T3 indices, int primcount)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(234)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawArraysInstancedARB(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int first, int count, int primcount);

            [Slot(247)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementsInstancedARB(OpenTK.Graphics.OpenGL4.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL4.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int primcount);
        }
    }
}
