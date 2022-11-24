using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Paint.Source.Utils {
	static class ImageFilesService {
		public static void SaveFile(string path, Image image) {
			FileInfo file = new FileInfo(path);
			if (file.Exists) {
				file.Delete();
			}

			image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
		}

		public static Image OpenFile(string path) {
			FileStream fs = new FileStream(path, FileMode.Open);
			Image streamedImage = Image.FromStream(fs);
			fs.Close();
			return streamedImage;
		}
	}
}
