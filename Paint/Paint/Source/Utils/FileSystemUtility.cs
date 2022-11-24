using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Paint.Source.Utils {
	static class FileSystemUtility {
		public static List<string> GetFilesInAppDirectory(string dir, string ext) {
			DirectoryInfo domainFolder = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + $"/{dir}");
			
			if (!domainFolder.Exists) {
				domainFolder.Create();
				return null;
			}

			List<FileInfo> files = domainFolder.GetFiles($"*.{ext}").ToList();
			List<string> filePaths = new List<string>(0);

			for (int i = 0; i < files.Count; i++) {
				filePaths.Add(files[i].FullName);
			}

			return filePaths;
		}
	}
}
