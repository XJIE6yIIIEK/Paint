using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Paint.Source.Models;
using Paint.Source.Utils;
using Paint.Source.Interfaces;

namespace Paint.Source.Presenters {
	class ImagePresenter {
		private BrushModel brush;
		private ImageModel image;

		private PointBuffer buffer;
		private Graphics graphics;

		private IMainView view;

		public ImagePresenter(BrushModel brush, ImageModel image, IMainView view) {
			this.brush = brush;
			this.image = image;

			buffer = new PointBuffer(2);

			this.view = view;
			view.BeginPaint += StartPaint;
			view.Painting += Paint;
			view.EndPaint += EndPaint;

			view.HeightChanged += HeightChanged;
			view.WidthChanged += WidthChanged;

			view.RequireCanvasUpdate += UpdateGraphics;

			view.CreateNewImage += ResetCanvas;

			graphics = Graphics.FromImage(image.Image);
			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, image.Width, image.Height);
			UpdateCanvasWithImage();
		}

		public void ResetCanvas() {
			image.Width = 600;
			image.Height = 600;

			image.Image = new Bitmap(image.Width, image.Height);
			graphics = Graphics.FromImage(image.Image);
			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, image.Width, image.Height);

			UpdateCanvasWithImage();
			UpdateCanvasParameters();
			UpdateGraphics();
		}

		public void UpdateGraphics() {
			graphics = Graphics.FromImage(image.Image);
			UpdateCanvasParameters();
			UpdateCanvasWithImage();
		}

		public void UpdateCanvasWithImage() {
			view.Canvas.Image = image.Image;
		}

		public void UpdateCanvasParameters() {
			view.WidthTextBox = image.Image.Width.ToString();
			view.HeightTextBox = image.Image.Height.ToString();

			view.WidthTrackBarValue = image.Image.Width;
			view.Canvas.Width = image.Image.Width;

			view.HeightTrackBarValue = image.Image.Height;
			view.Canvas.Height = image.Image.Height;
			GC.Collect();
		}

		public void StartPaint(int x, int y) {
			brush.Painting = true;
			buffer.AddPoint(x, y);
		}

		public void EndPaint() {
			brush.Painting = false;
			buffer.ResetBuffer();
		}

		public void Paint(int x, int y) {
			if (!brush.Painting) {
				return;
			}

			buffer.AddPoint(x, y);
			graphics.DrawLines(brush.Pen, buffer.Points);
			UpdateCanvasWithImage();
		}

		public void WidthChanged(int width) {
			if (width > 65535) {
				return;
			}

			Bitmap result = new Bitmap(width, image.Height);

			graphics = Graphics.FromImage(result);

			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, width, image.Height);
			graphics.DrawImage(image.Image, Point.Empty);

			image.Image = result;
			image.Width = width;

			UpdateCanvasWithImage();
			UpdateCanvasParameters();
		}

		public void HeightChanged(int height) {
			if (height > 65535) {
				return;
			}

			Bitmap result = new Bitmap(image.Width, height);
			graphics = Graphics.FromImage(result);

			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, image.Width, height);
			graphics.DrawImage(image.Image, Point.Empty);

			image.Image = result;
			image.Height = height;

			UpdateCanvasWithImage();
			UpdateCanvasParameters();
		}
	}
}
