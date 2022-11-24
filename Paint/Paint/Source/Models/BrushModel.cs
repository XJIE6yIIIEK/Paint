using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Source.Models {
	class BrushModel {
		private bool painting;
		private Pen pen;

		public bool Painting {
			get { return painting; }
			set { painting = value; } 
		}

		public Pen Pen {
			get { return pen; }
			set { pen = value; }
		}

		public BrushModel() {
			painting = false;
			pen = new Pen(Color.Black, 3f);
			pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
		}
	}
}
