using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

using Paint;
using Paint.Source.Presenters;
using Paint.Source.Models;
using Paint.Source.Interfaces;
using Paint.Source.Utils;

namespace Paint.Source.Presenters {
	class DLLPresenter {
		private ImageModel image;
		private List<DLLModel> dlls;

		private IMainView view;

		private Action ImageHandled;

		public DLLPresenter(ImageModel image, IMainView view) {
			this.image = image;
			this.view = view;

			dlls = new List<DLLModel>(0);

			ImageHandled += view.ImageUpdated;
			view.AddLibrary += AddLibrary;

			AddLibraries();
		}

		public void AddLibrary(string path) {
			try {
				DLLModel dll = DLLModel.CreateModel(path);

				if (dll == null) {
					return;
				}

				dlls.Add(dll);
				AddToolstripItem(dll);
			} catch (Exception e) {
				ErrorsService.ShowError(e);
			}
		}

		public void AddLibrary() {
			string path = DialogService.Open("dll", "DLL Files (*.dll)|*.dll");
			AddLibrary(path);
		}

		public void AddLibraries() {
			List<string> dllPaths = FileSystemUtility.GetFilesInAppDirectory("plugins", "dll");

			if (dllPaths == null) {
				return;
			}

			for (int i = 0; i < dllPaths.Count; i++) {
				AddLibrary(dllPaths[i]);
			}
		}

		private void ExecuteDLL(DLLModel dll) {
			BitmapData bitmapData = image.Image.LockBits(
				new Rectangle(0, 0, image.Width, image.Height), 
				System.Drawing.Imaging.ImageLockMode.ReadWrite,
				System.Drawing.Imaging.PixelFormat.Format32bppArgb
			);

			try {
				dll.Execute(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, 4);
			} catch (Exception e) {
				ErrorsService.ShowError(new RuntimeDLLError(dll.LibName));
			}

			image.Image.UnlockBits(bitmapData);
			ImageHandled();
		}

		private void AddToolstripItem(DLLModel dll) {
			ToolStripMenuItem dllItem = new ToolStripMenuItem(dll.LibName);
			ToolStripMenuItem executeDllItem = new ToolStripMenuItem("Выполнить");

			dllItem.DropDownItems.Add(executeDllItem);

			executeDllItem.Click += (sender, e) => ExecuteDLL(dll);

			view.PluginsMenu.DropDownItems.Add(dllItem);
		}
	}
}
