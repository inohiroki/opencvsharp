﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenCvSharp
{
#if LANG_JP
    /// <summary>
    /// 
    /// </summary>
    /// <param name="struct_ptr"></param>
    /// <returns></returns>
#else
    /// <summary>
    /// 
    /// </summary>
    /// <param name="struct_ptr"></param>
    /// <returns></returns>
#endif
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int CvIsInstanceFunc(IntPtr struct_ptr);

}
