using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace Paint.Source.Utils {
	static class DialogService {
		public static string SaveDialog() {
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
			dialog.DefaultExt = "png";

			if (dialog.ShowDialog() == DialogResult.OK) {
				return dialog.FileName;
			}

			return null;
		}

		public static string Open(string ext, string extFilter) {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = extFilter;
			dialog.DefaultExt = ext;

			if (dialog.ShowDialog() == DialogResult.OK) {
				return dialog.FileName;
			}

			return null;
		}

		public static Color ColorDialog() {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.FullOpen = false;
			colorDialog.ShowHelp = true;

			if (colorDialog.ShowDialog() == DialogResult.OK) {
				return colorDialog.Color;
			}

			return Color.Empty;
		}

		public static void ShowMessage(string msg) {
			MessageBox.Show(msg);
		}
	}
}
