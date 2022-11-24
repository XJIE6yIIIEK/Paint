using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using Paint.Source.Interfaces;
using Paint.Source.Presenters;
using Paint.Source.Models;
using Paint.Source.Utils;

namespace Paint.Source.Presenters {
	class FilePresenter {
		private FileModel file;
		private ImageModel image;

		private IMainView view;

		private event Action ImageLoaded;

		public FilePresenter(FileModel file, ImageModel image, IMainView view) {
			this.view = view;
			this.file = file;
			this.image = image;

			view.Open += OpenImage;
			view.Save += SaveImage;
			view.SaveAs += SaveAsImage;

			ImageLoaded += view.ImageUpdated;
		}

		public void OpenImage() {
			file.Path = DialogService.Open("png", "Image Files (*.jpg;*.png;*.bmp;*.jpeg)|*.jpg;*.png;*.bmp;*.jpeg");

			if (file.Path == null) {
				return;
			}

			Image openedImage = ImageFilesService.OpenFile(file.Path);
			image.Image = (Bitmap)openedImage;
			image.Width = openedImage.Width;
			image.Height = openedImage.Height;

			ImageLoaded?.Invoke();
		}

		public void SaveImage() {
			if (file.Path == null) {
				SaveAsImage();
				return;
			}

			ImageFilesService.SaveFile(file.Path, image.Image);
		}

		public void SaveAsImage() {
			file.Path = DialogService.SaveDialog();

			if (file.Path != null) {
				ImageFilesService.SaveFile(file.Path, image.Image);
			}
		}
	}
}
