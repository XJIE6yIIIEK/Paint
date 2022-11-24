
namespace Paint {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pluginsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.brushOptionsPanel = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.heightSizeLabel = new System.Windows.Forms.Label();
			this.heightTrackBar = new System.Windows.Forms.TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.widthTrackBar = new System.Windows.Forms.TrackBar();
			this.widthSizeLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.brushSizeLabel = new System.Windows.Forms.Label();
			this.brushSizeTrackBar = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.brushColorButton = new System.Windows.Forms.Button();
			this.paintPanel = new System.Windows.Forms.Panel();
			this.canvas = new System.Windows.Forms.PictureBox();
			this.addPluginsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mainMenu.SuspendLayout();
			this.brushOptionsPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).BeginInit();
			this.panel1.SuspendLayout();
			this.paintPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.pluginsMenu});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(1298, 24);
			this.mainMenu.TabIndex = 1;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.saveFileMenuItem,
            this.saveAsFileMenuItem,
            this.openFileMenuItem});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(48, 20);
			this.fileMenu.Text = "Файл";
			// 
			// newFileMenuItem
			// 
			this.newFileMenuItem.Name = "newFileMenuItem";
			this.newFileMenuItem.Size = new System.Drawing.Size(160, 22);
			this.newFileMenuItem.Text = "Создать";
			// 
			// saveFileMenuItem
			// 
			this.saveFileMenuItem.Name = "saveFileMenuItem";
			this.saveFileMenuItem.Size = new System.Drawing.Size(160, 22);
			this.saveFileMenuItem.Text = "Сохранить";
			// 
			// saveAsFileMenuItem
			// 
			this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
			this.saveAsFileMenuItem.Size = new System.Drawing.Size(160, 22);
			this.saveAsFileMenuItem.Text = "Сохранить как..";
			// 
			// openFileMenuItem
			// 
			this.openFileMenuItem.Name = "openFileMenuItem";
			this.openFileMenuItem.Size = new System.Drawing.Size(160, 22);
			this.openFileMenuItem.Text = "Открыть";
			// 
			// pluginsMenu
			// 
			this.pluginsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPluginsMenuItem,
            this.toolStripSeparator1});
			this.pluginsMenu.Name = "pluginsMenu";
			this.pluginsMenu.Size = new System.Drawing.Size(69, 20);
			this.pluginsMenu.Text = "Плагины";
			// 
			// brushOptionsPanel
			// 
			this.brushOptionsPanel.Controls.Add(this.panel3);
			this.brushOptionsPanel.Controls.Add(this.panel2);
			this.brushOptionsPanel.Controls.Add(this.panel1);
			this.brushOptionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.brushOptionsPanel.Location = new System.Drawing.Point(1089, 24);
			this.brushOptionsPanel.Name = "brushOptionsPanel";
			this.brushOptionsPanel.Size = new System.Drawing.Size(209, 660);
			this.brushOptionsPanel.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 171);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(209, 215);
			this.panel3.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.heightSizeLabel);
			this.panel5.Controls.Add(this.heightTrackBar);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 134);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(209, 81);
			this.panel5.TabIndex = 11;
			// 
			// heightSizeLabel
			// 
			this.heightSizeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.heightSizeLabel.Location = new System.Drawing.Point(0, 58);
			this.heightSizeLabel.Name = "heightSizeLabel";
			this.heightSizeLabel.Size = new System.Drawing.Size(209, 23);
			this.heightSizeLabel.TabIndex = 7;
			this.heightSizeLabel.Text = "600";
			this.heightSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// heightTrackBar
			// 
			this.heightTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.heightTrackBar.Location = new System.Drawing.Point(0, 23);
			this.heightTrackBar.Maximum = 8192;
			this.heightTrackBar.Minimum = 1;
			this.heightTrackBar.Name = "heightTrackBar";
			this.heightTrackBar.Size = new System.Drawing.Size(209, 45);
			this.heightTrackBar.TabIndex = 9;
			this.heightTrackBar.Value = 600;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(209, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Высота";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.widthTrackBar);
			this.panel4.Controls.Add(this.widthSizeLabel);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(209, 98);
			this.panel4.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ширина";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// widthTrackBar
			// 
			this.widthTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.widthTrackBar.Location = new System.Drawing.Point(0, 30);
			this.widthTrackBar.Maximum = 8192;
			this.widthTrackBar.Minimum = 1;
			this.widthTrackBar.Name = "widthTrackBar";
			this.widthTrackBar.Size = new System.Drawing.Size(209, 45);
			this.widthTrackBar.TabIndex = 8;
			this.widthTrackBar.Value = 600;
			// 
			// widthSizeLabel
			// 
			this.widthSizeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.widthSizeLabel.Location = new System.Drawing.Point(0, 75);
			this.widthSizeLabel.Name = "widthSizeLabel";
			this.widthSizeLabel.Size = new System.Drawing.Size(209, 23);
			this.widthSizeLabel.TabIndex = 5;
			this.widthSizeLabel.Text = "600";
			this.widthSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "Размер полотна";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.brushSizeLabel);
			this.panel2.Controls.Add(this.brushSizeTrackBar);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(209, 85);
			this.panel2.TabIndex = 2;
			// 
			// brushSizeLabel
			// 
			this.brushSizeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.brushSizeLabel.Location = new System.Drawing.Point(0, 62);
			this.brushSizeLabel.Name = "brushSizeLabel";
			this.brushSizeLabel.Size = new System.Drawing.Size(209, 23);
			this.brushSizeLabel.TabIndex = 2;
			this.brushSizeLabel.Text = "3";
			this.brushSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// brushSizeTrackBar
			// 
			this.brushSizeTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.brushSizeTrackBar.Location = new System.Drawing.Point(0, 32);
			this.brushSizeTrackBar.Maximum = 64;
			this.brushSizeTrackBar.Minimum = 1;
			this.brushSizeTrackBar.Name = "brushSizeTrackBar";
			this.brushSizeTrackBar.Size = new System.Drawing.Size(209, 45);
			this.brushSizeTrackBar.TabIndex = 1;
			this.brushSizeTrackBar.TickFrequency = 8;
			this.brushSizeTrackBar.Value = 3;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Размер кисти";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.brushColorButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(209, 86);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Цвет кисти";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// brushColorButton
			// 
			this.brushColorButton.BackColor = System.Drawing.Color.Black;
			this.brushColorButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.brushColorButton.Location = new System.Drawing.Point(0, 37);
			this.brushColorButton.Name = "brushColorButton";
			this.brushColorButton.Size = new System.Drawing.Size(209, 49);
			this.brushColorButton.TabIndex = 0;
			this.brushColorButton.UseVisualStyleBackColor = false;
			// 
			// paintPanel
			// 
			this.paintPanel.AutoScroll = true;
			this.paintPanel.Controls.Add(this.canvas);
			this.paintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paintPanel.Location = new System.Drawing.Point(0, 24);
			this.paintPanel.Name = "paintPanel";
			this.paintPanel.Size = new System.Drawing.Size(1089, 660);
			this.paintPanel.TabIndex = 3;
			// 
			// canvas
			// 
			this.canvas.Location = new System.Drawing.Point(0, 0);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(1089, 660);
			this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.canvas.TabIndex = 2;
			this.canvas.TabStop = false;
			// 
			// addPluginsMenuItem
			// 
			this.addPluginsMenuItem.Name = "addPluginsMenuItem";
			this.addPluginsMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addPluginsMenuItem.Text = "Подключить";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1298, 684);
			this.Controls.Add(this.paintPanel);
			this.Controls.Add(this.brushOptionsPanel);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "Form1";
			this.Text = "Paint";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.brushOptionsPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.brushSizeTrackBar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.paintPanel.ResumeLayout(false);
			this.paintPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pluginsMenu;
		private System.Windows.Forms.Panel brushOptionsPanel;
		private System.Windows.Forms.Panel paintPanel;
		private System.Windows.Forms.PictureBox canvas;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button brushColorButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TrackBar brushSizeTrackBar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label brushSizeLabel;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label heightSizeLabel;
		private System.Windows.Forms.TrackBar heightTrackBar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar widthTrackBar;
		private System.Windows.Forms.Label widthSizeLabel;
		private System.Windows.Forms.ToolStripMenuItem addPluginsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

