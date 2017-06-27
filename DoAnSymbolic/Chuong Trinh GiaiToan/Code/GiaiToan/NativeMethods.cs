﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiToan
{
    //class Native
        [System.Security.SuppressUnmanagedCodeSecurity()]

    internal class NativeMethods

    {

        private NativeMethods()

        { 
        }

        [System.Runtime.InteropServices.DllImport("MimeTeX.dll")]

        internal static extern int CreateGifFromEq(string expr, string fileName);

 

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]

        internal extern static IntPtr GetModuleHandle(string lpModuleName);

 

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]

        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]

        internal extern static bool FreeLibrary(IntPtr hLibModule);

    }
    
}
