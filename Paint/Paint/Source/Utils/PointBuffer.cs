using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Source.Utils {
	class PointBuffer {
		private Point[] points;
		private int size;
		private int index;
		private int emptySlots;

		public Point[] Points {
			get { return points; }
		}

		public PointBuffer(int size) {
			index = 0;
			this.size = size;
			emptySlots = size;
			points = new Point[size];
		}

		public void AddPoint(int x, int y) {
			Point point = new Point(x, y);
			
			points[index] = point;

			index = (index + 1) % size;
			if (emptySlots > 0) {
				emptySlots--;
			}
		}

		public void ResetBuffer() {
			emptySlots = size;
			index = 0;
		}

		public bool HasEmpty() {
			return emptySlots > 0;
		}
	}
}
