using System;
using System.Runtime.InteropServices;

namespace Paint.Source.Utils {
	public static class DLLLoader {
		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
		public static extern int LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

		[DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
		public static extern IntPtr GetProcAddress(int hModule, string lpProcName);

		[DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
		public static extern bool FreeLibrary(int hModule);
	}
}
