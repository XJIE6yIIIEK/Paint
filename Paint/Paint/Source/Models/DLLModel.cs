using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

using Paint;
using Paint.Source.Presenters;
using Paint.Source.Models;
using Paint.Source.Interfaces;
using Paint.Source.Utils;

namespace Paint.Source.Models {
	class DLLModel {
		private string libName;
		private string funcNativeName;
		private int hLib;

		public string LibName {
			get {
				return libName;
			}
		}

		public delegate void LibExecute(IntPtr image, int width, int height, int stride, int mode);
		public LibExecute Execute; 

		private delegate void GetName(StringBuilder str, int length);

		public DLLModel(int HModule, string path) {
			hLib = HModule;

			IntPtr LibraryNamePtr = DLLLoader.GetProcAddress(HModule, "LibraryName");
			IntPtr NameFuncPtr = DLLLoader.GetProcAddress(HModule, "FunctionName");

			if (LibraryNamePtr == IntPtr.Zero || NameFuncPtr == IntPtr.Zero) {
				throw new InvalidDLL(path);
			}

			int strLength = 256;

			StringBuilder libName = new StringBuilder(strLength);
			StringBuilder funcNativeName = new StringBuilder(strLength);

			GetName GetLibName = (GetName)Marshal.GetDelegateForFunctionPointer(LibraryNamePtr, typeof(GetName));
			GetName GetFuncName = (GetName)Marshal.GetDelegateForFunctionPointer(NameFuncPtr, typeof(GetName));

			GetLibName(libName, strLength);
			GetFuncName(funcNativeName, strLength);

			this.libName = libName.ToString();
			this.funcNativeName = funcNativeName.ToString();

			IntPtr execute = DLLLoader.GetProcAddress(HModule, this.funcNativeName);

			if (execute == IntPtr.Zero) {
				throw new InvalidDLL(path);
			}

			Execute = (LibExecute)Marshal.GetDelegateForFunctionPointer(execute, typeof(LibExecute));
		}

		~DLLModel() {
			DLLLoader.FreeLibrary(hLib);
		}

		public static DLLModel CreateModel(string path) {
			int HModule = DLLLoader.LoadLibrary(path);

			if (HModule == 0) {
				throw new InvalidDLL(path);
			}

			return new DLLModel(HModule, path);
		}
	}
}
