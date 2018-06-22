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
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjecti64v")]
        public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] long[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjecti64v")]
        public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] out long @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjecti64v")]
        public static unsafe void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjectui64v")]
        public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong[] @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjectui64v")]
        public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] out ulong @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Return parameters of a query object
        /// </summary>
        /// <param name="id">
        /// Specifies the name of a query object.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
        /// </param>
        /// <param name="params">
        /// [length: COMPSIZE(pname)]
        /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glGetQueryObjectui64v")]
        public static unsafe void GetQueryObject(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.3 or ARB_timer_query|VERSION_3_3]
        /// Record the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
        /// </summary>
        /// <param name="id">
        /// Specify the name of a query object into which to record the GL time.
        /// </param>
        /// <param name="target">
        /// Specify the counter to query. target must be Timestamp.
        /// </param>
        [AutoGenerated(Category = "ARB_timer_query|VERSION_3_3", Version = "3.3", EntryPoint = "glQueryCounter")]
        public static void QueryCounter(uint id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target)
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(520)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetQueryObjecti64v(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params);

        [Slot(522)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetQueryObjectui64v(uint id, OpenTK.Graphics.OpenGL4.GetQueryObjectParam pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong* @params);

        [Slot(982)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glQueryCounter(uint id, OpenTK.Graphics.OpenGL4.QueryCounterTarget target);
    }
}
