﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus
{
    static partial class NativeMethods
    {
        #region CvAdaptiveSkinDetector
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr contrib_CvAdaptiveSkinDetector_new(int samplingDivider, int morphingMethod);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void contrib_CvAdaptiveSkinDetector_delete(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void contrib_CvAdaptiveSkinDetector_process(IntPtr self, IntPtr inputBgrImage, IntPtr outputHueMask);
        #endregion
    }
}