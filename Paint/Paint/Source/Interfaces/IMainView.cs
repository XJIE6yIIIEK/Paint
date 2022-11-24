using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Paint.Source.Interfaces {
	interface IMainView {
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
		public void ImageUpdated();

		public event Action AddLibrary;

		public PictureBox Canvas { get; }
		public TrackBar WidthTrackBar { get; }
		public TrackBar HeightTrackBar { get; }
		public Button BrushColorButton { get; }
		public TrackBar BrushSizeTrackBar { get; }
		public ToolStripMenuItem SaveFileMenuItem { get; }
		public ToolStripMenuItem SaveAsFileMenuItem { get; }
		public ToolStripMenuItem OpenFileMenuItem { get; }
		public ToolStripMenuItem NewFileMenuItem { get; }
		public ToolStripMenuItem PluginsMenu { get; }

		public string WidthTextBox { set; }
		public string HeightTextBox { set; }
		public string BrushSizeLabel { set; }
		public int WidthTrackBarValue { set; }
		public int HeightTrackBarValue { set; }
	}
}
