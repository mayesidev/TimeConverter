namespace TimeConverter
{
	partial class TimeConverterControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.syncButton = new System.Windows.Forms.Button();
			this.localTimeBox = new System.Windows.Forms.TextBox();
			this.universalTimeBox = new System.Windows.Forms.TextBox();
			this.unixTimeBox = new System.Windows.Forms.TextBox();
			this.resetButton = new System.Windows.Forms.Button();
			this.localTimeLabel = new System.Windows.Forms.Label();
			this.utcTimeLabel = new System.Windows.Forms.Label();
			this.unixTimeLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.syncButton, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.localTimeBox, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.universalTimeBox, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.unixTimeBox, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.resetButton, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.localTimeLabel, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.utcTimeLabel, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.unixTimeLabel, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(275, 150);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// syncButton
			// 
			this.syncButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.syncButton.Location = new System.Drawing.Point(103, 75);
			this.syncButton.MinimumSize = new System.Drawing.Size(110, 36);
			this.syncButton.Name = "syncButton";
			this.syncButton.Size = new System.Drawing.Size(169, 72);
			this.syncButton.TabIndex = 20;
			this.syncButton.Text = "&Synchronize (F5)";
			this.syncButton.UseVisualStyleBackColor = true;
			this.syncButton.Click += new System.EventHandler(this._OnSychronizeClick);
			// 
			// localTimeBox
			// 
			this.localTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.localTimeBox.Location = new System.Drawing.Point(103, 51);
			this.localTimeBox.MinimumSize = new System.Drawing.Size(110, 20);
			this.localTimeBox.Name = "localTimeBox";
			this.localTimeBox.Size = new System.Drawing.Size(169, 20);
			this.localTimeBox.TabIndex = 19;
			this.localTimeBox.Tag = "local";
			this.localTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// universalTimeBox
			// 
			this.universalTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.universalTimeBox.Location = new System.Drawing.Point(103, 27);
			this.universalTimeBox.MinimumSize = new System.Drawing.Size(110, 20);
			this.universalTimeBox.Name = "universalTimeBox";
			this.universalTimeBox.Size = new System.Drawing.Size(169, 20);
			this.universalTimeBox.TabIndex = 18;
			this.universalTimeBox.Tag = "universal";
			this.universalTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// unixTimeBox
			// 
			this.unixTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.unixTimeBox.Location = new System.Drawing.Point(103, 3);
			this.unixTimeBox.MinimumSize = new System.Drawing.Size(110, 20);
			this.unixTimeBox.Name = "unixTimeBox";
			this.unixTimeBox.Size = new System.Drawing.Size(169, 20);
			this.unixTimeBox.TabIndex = 17;
			this.unixTimeBox.Tag = "unix";
			this.unixTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// resetButton
			// 
			this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resetButton.Location = new System.Drawing.Point(3, 75);
			this.resetButton.MinimumSize = new System.Drawing.Size(65, 36);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(94, 72);
			this.resetButton.TabIndex = 16;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this._OnResetClick);
			// 
			// localTimeLabel
			// 
			this.localTimeLabel.AutoSize = true;
			this.localTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.localTimeLabel.Location = new System.Drawing.Point(3, 48);
			this.localTimeLabel.MinimumSize = new System.Drawing.Size(65, 15);
			this.localTimeLabel.Name = "localTimeLabel";
			this.localTimeLabel.Size = new System.Drawing.Size(94, 24);
			this.localTimeLabel.TabIndex = 13;
			this.localTimeLabel.Text = "Local Time:";
			this.localTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// utcTimeLabel
			// 
			this.utcTimeLabel.AutoSize = true;
			this.utcTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcTimeLabel.Location = new System.Drawing.Point(3, 24);
			this.utcTimeLabel.MinimumSize = new System.Drawing.Size(65, 15);
			this.utcTimeLabel.Name = "utcTimeLabel";
			this.utcTimeLabel.Size = new System.Drawing.Size(94, 24);
			this.utcTimeLabel.TabIndex = 11;
			this.utcTimeLabel.Text = "UTC Time:";
			this.utcTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeLabel
			// 
			this.unixTimeLabel.AutoSize = true;
			this.unixTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unixTimeLabel.Location = new System.Drawing.Point(3, 0);
			this.unixTimeLabel.MinimumSize = new System.Drawing.Size(65, 15);
			this.unixTimeLabel.Name = "unixTimeLabel";
			this.unixTimeLabel.Size = new System.Drawing.Size(94, 24);
			this.unixTimeLabel.TabIndex = 10;
			this.unixTimeLabel.Text = "Unix Time:";
			this.unixTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TimeConverterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel);
			this.MinimumSize = new System.Drawing.Size(275, 150);
			this.Name = "TimeConverterControl";
			this.Size = new System.Drawing.Size(275, 150);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label unixTimeLabel;
		private System.Windows.Forms.Label utcTimeLabel;
		private System.Windows.Forms.Label localTimeLabel;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.TextBox unixTimeBox;
		private System.Windows.Forms.TextBox universalTimeBox;
		private System.Windows.Forms.TextBox localTimeBox;
		private System.Windows.Forms.Button syncButton;
	}
}
