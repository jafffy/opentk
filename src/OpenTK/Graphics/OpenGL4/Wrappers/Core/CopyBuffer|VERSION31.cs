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
        /// [requires: v3.1 or ARB_copy_buffer|VERSION_3_1]
        /// Copy part of the data store of a buffer object to the data store of another buffer object
        /// </summary>
        /// <param name="readTarget">
        /// Specifies the target from whose data store data should be read.
        /// </param>
        /// <param name="writeTarget">
        /// Specifies the target to whose data store data should be written.
        /// </param>
        /// <param name="readOffset">
        /// Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read.
        /// </param>
        /// <param name="writeOffset">
        /// Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written.
        /// </param>
        /// <param name="size">
        /// Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget.
        /// </param>
        [AutoGenerated(Category = "ARB_copy_buffer|VERSION_3_1", Version = "3.1", EntryPoint = "glCopyBufferSubData")]
        public static void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, int size)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.1 or ARB_copy_buffer|VERSION_3_1]
        /// Copy part of the data store of a buffer object to the data store of another buffer object
        /// </summary>
        /// <param name="readTarget">
        /// Specifies the target from whose data store data should be read.
        /// </param>
        /// <param name="writeTarget">
        /// Specifies the target to whose data store data should be written.
        /// </param>
        /// <param name="readOffset">
        /// Specifies the offset, in basic machine units, within the data store of readtarget from which data should be read.
        /// </param>
        /// <param name="writeOffset">
        /// Specifies the offset, in basic machine units, within the data store of writetarget to which data should be written.
        /// </param>
        /// <param name="size">
        /// Specifies the size, in basic machine units, of the data to be copied from readtarget to writetarget.
        /// </param>
        [AutoGenerated(Category = "ARB_copy_buffer|VERSION_3_1", Version = "3.1", EntryPoint = "glCopyBufferSubData")]
        public static void CopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(133)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyBufferSubData(OpenTK.Graphics.OpenGL4.BufferTarget readTarget, OpenTK.Graphics.OpenGL4.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
    }
}
