namespace TimeConverter
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.timeConverterControl1 = new TimeConverter.TimeConverterControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.timeConverterControl1, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(296, 187);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// timeConverterControl1
			// 
			this.timeConverterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeConverterControl1.Location = new System.Drawing.Point(3, 3);
			this.timeConverterControl1.MinimumSize = new System.Drawing.Size(275, 150);
			this.timeConverterControl1.Name = "timeConverterControl1";
			this.timeConverterControl1.Size = new System.Drawing.Size(290, 181);
			this.timeConverterControl1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(296, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConverterToolStripMenuItem,
            this.removeConverterToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.fileToolStripMenuItem.Text = "Controls";
			// 
			// addConverterToolStripMenuItem
			// 
			this.addConverterToolStripMenuItem.Name = "addConverterToolStripMenuItem";
			this.addConverterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.addConverterToolStripMenuItem.Text = "Add converter";
			this.addConverterToolStripMenuItem.Click += new System.EventHandler(this._OnAddConverterToolStripMenuItemClick);
			// 
			// removeConverterToolStripMenuItem
			// 
			this.removeConverterToolStripMenuItem.Name = "removeConverterToolStripMenuItem";
			this.removeConverterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.removeConverterToolStripMenuItem.Text = "Remove converter";
			this.removeConverterToolStripMenuItem.Click += new System.EventHandler(this._OnRemoveConverterToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 211);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(300, 250);
			this.Name = "MainForm";
			this.Text = "Time Converter";
			this.tableLayoutPanel.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private TimeConverterControl timeConverterControl1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addConverterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeConverterToolStripMenuItem;
	}
}