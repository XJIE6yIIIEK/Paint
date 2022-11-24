using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing.Imaging;

using Paint.Source.Interfaces;
using Paint.Source.Presenters;
using Paint.Source.Models;
using Paint.Source.Utils;


namespace Paint {
	public partial class Form1 : Form, IMainView {
		public event Action<int, int> BeginPaint;
		public event Action<int, int> Painting;
		public event Action EndPaint;

		public event Action<int> WidthChanged;
		public event Action<int> HeightChanged;

		public event Action<Color> ChangeColor;
		public event Action<int> BrushSizeChanged;

		public event Action Save;
		public event Action SaveAs;
		public event Action Open;

		public event Action CreateNewImage;

		public event Action RequireCanvasUpdate;

		public event Action AddLibrary;

		public Form MainForm { get; set; }

		public void ImageUpdated() {
			RequireCanvasUpdate?.Invoke();
		}

		public void InitializePresenters() {
			ImageModel image = new ImageModel(600, 600);
			BrushModel brush = new BrushModel();
			FileModel file = new FileModel();

			FilePresenter filePresenter = new FilePresenter(file, image, this);
			BrushPresenter brushPresenter = new BrushPresenter(brush, this);
			ImagePresenter imagePresenter = new ImagePresenter(brush, image, this);
			DLLPresenter dllPresenter = new DLLPresenter(image, this);

			Canvas.MouseDown += (sender, e) => BeginPaint?.Invoke(e.X, e.Y);
			Canvas.MouseMove += (sender, e) => Painting?.Invoke(e.X, e.Y);
			Canvas.MouseUp += (sender, e) => EndPaint?.Invoke();

			WidthTrackBar.Scroll += (sender, e) => {
				WidthChanged?.Invoke(WidthTrackBar.Value);
				WidthTextBox = WidthTrackBar.Value.ToString();
			};

			HeightTrackBar.Scroll += (sender, e) => {
				HeightChanged?.Invoke(HeightTrackBar.Value);
				HeightTextBox = HeightTrackBar.Value.ToString();
			};

			BrushColorButton.Click += (sender, e) => {
				Color color = DialogService.ColorDialog();

				if (color != Color.Empty) {
					BrushColorButton.BackColor = color;
					ChangeColor?.Invoke(color);
				}
			};

			BrushSizeTrackBar.Scroll += (sender, e) => BrushSizeChanged?.Invoke(BrushSizeTrackBar.Value);

			SaveFileMenuItem.Click += (sender, e) => Save?.Invoke();
			SaveAsFileMenuItem.Click += (sender, e) => SaveAs?.Invoke();
			OpenFileMenuItem.Click += (sender, e) => Open?.Invoke();

			NewFileMenuItem.Click += (sender, e) => CreateNewImage?.Invoke();

			AddPluginButton.Click += (sender, e) => AddLibrary?.Invoke();
		}
	}
}
