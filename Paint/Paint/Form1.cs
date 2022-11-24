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
		public string WidthTextBox {
			set { widthSizeLabel.Text = value; }
		}

		public string HeightTextBox {
			set { heightSizeLabel.Text = value; }
		}

		public string BrushSizeLabel {
			set { brushSizeLabel.Text = value; }
		}

		public int WidthTrackBarValue {
			set { widthTrackBar.Value = value; }
		}

		public int HeightTrackBarValue {
			set { heightTrackBar.Value = value; }
		}

		public TrackBar WidthTrackBar {
			get { return widthTrackBar; }
		}

		public TrackBar HeightTrackBar {
			get { return heightTrackBar; }
		}

		public PictureBox Canvas {
			get { return canvas; }
		}

		public Button BrushColorButton {
			get { return brushColorButton; }
		}

		public TrackBar BrushSizeTrackBar {
			get { return brushSizeTrackBar; }
		}

		public ToolStripMenuItem AddPluginButton {
			get { return addPluginsMenuItem; }
		}

		public ToolStripMenuItem SaveFileMenuItem {
			get { return saveFileMenuItem; }
		}

		public ToolStripMenuItem SaveAsFileMenuItem {
			get { return saveAsFileMenuItem; }
		}

		public ToolStripMenuItem OpenFileMenuItem {
			get { return openFileMenuItem; }
		}

		public ToolStripMenuItem NewFileMenuItem {
			get { return newFileMenuItem; }
		}

		public ToolStripMenuItem PluginsMenu {
			get { return pluginsMenu; }
		}

		public Form1() {
			InitializeComponent();
			InitializePresenters();
		}
	}
}
