using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DllImportExample
{
    public class ImportedFunctions
    {
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern ushort GetVersion();

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern DriveType GetDriveType([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();
    }
}