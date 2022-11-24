using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Source.Models {
	class ImageModel {
		private Bitmap image { get; set; }
		private int width;
		private int height;
		
		public Bitmap Image {
			get { return image; }
			set { image = value; }
		}

		public int Width {
			get { return width; }
			set { width = value; }
		}

		public int Height {
			get { return height; }
			set { height = value; }
		}

		public IntPtr HBITMAP {
			get {
				return image.GetHbitmap();
			}
		}

		public ImageModel(int width, int height) {
			image = new Bitmap(width, height);
			this.width = width;
			this.height = height;
		}
	}
}
