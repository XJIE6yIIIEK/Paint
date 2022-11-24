using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Paint.Source.Models;
using Paint.Source.Interfaces;

namespace Paint.Source.Presenters {
	class BrushPresenter {
		private BrushModel brush;

		private IMainView view;

		public BrushPresenter(BrushModel brush, IMainView view) {
			this.brush = brush;
			this.view = view;

			view.ChangeColor += SetBrushColor;
			view.BrushSizeChanged += SetBrushSize;
		}

		public void SetBrushColor(Color color) {
			brush.Pen.Color = color;
		}

		public void SetBrushSize(int size) {
			brush.Pen.Width = size;
			view.BrushSizeLabel = size.ToString();
		}
	}
}
