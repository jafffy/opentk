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
        /// Contains native bindings to functions in the category "DrawVulkanImage" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_draw_vulkan_image]
            /// </summary>
            /// <param name="vkImage">
            /// </param>
            /// <param name="sampler">
            /// </param>
            /// <param name="x0">
            /// </param>
            /// <param name="y0">
            /// </param>
            /// <param name="x1">
            /// </param>
            /// <param name="y1">
            /// </param>
            /// <param name="z">
            /// </param>
            /// <param name="s0">
            /// </param>
            /// <param name="t0">
            /// </param>
            /// <param name="s1">
            /// </param>
            /// <param name="t1">
            /// </param>
            [AutoGenerated(Category = "NV_draw_vulkan_image", Version = "", EntryPoint = "glDrawVkImageNV")]
            public static void DrawVkImage(ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_vulkan_image]
            /// </summary>
            /// <param name="name">
            /// [length: COMPSIZE(name)]
            /// </param>
            [AutoGenerated(Category = "NV_draw_vulkan_image", Version = "", EntryPoint = "glGetVkProcAddrNV")]
            public static IntPtr GetVkProcAddr([CountAttribute(Computed = "name")] string name)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_vulkan_image]
            /// </summary>
            /// <param name="vkFence">
            /// </param>
            [AutoGenerated(Category = "NV_draw_vulkan_image", Version = "", EntryPoint = "glSignalVkFenceNV")]
            public static void SignalVkFence(ulong vkFence)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_vulkan_image]
            /// </summary>
            /// <param name="vkSemaphore">
            /// </param>
            [AutoGenerated(Category = "NV_draw_vulkan_image", Version = "", EntryPoint = "glSignalVkSemaphoreNV")]
            public static void SignalVkSemaphore(ulong vkSemaphore)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_vulkan_image]
            /// </summary>
            /// <param name="vkSemaphore">
            /// </param>
            [AutoGenerated(Category = "NV_draw_vulkan_image", Version = "", EntryPoint = "glWaitVkSemaphoreNV")]
            public static void WaitVkSemaphore(ulong vkSemaphore)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(258)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawVkImageNV(ulong vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

            [Slot(599)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern IntPtr glGetVkProcAddrNV([CountAttribute(Computed = "name")] IntPtr name);

            [Slot(1017)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSignalVkFenceNV(ulong vkFence);

            [Slot(1018)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSignalVkSemaphoreNV(ulong vkSemaphore);

            [Slot(1357)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWaitVkSemaphoreNV(ulong vkSemaphore);
        }
    }
}
