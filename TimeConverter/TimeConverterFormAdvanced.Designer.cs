namespace TimeConverter
{
	partial class TimeConverterFormAdvanced
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.resetCol1Button = new System.Windows.Forms.Button();
			this.syncCol1Button = new System.Windows.Forms.Button();
			this.localTimeCol1Box = new System.Windows.Forms.TextBox();
			this.localTimeCol1Label = new System.Windows.Forms.Label();
			this.utcTimeCol1Box = new System.Windows.Forms.TextBox();
			this.utcTimeCol1Label = new System.Windows.Forms.Label();
			this.unixTimeCol1Label = new System.Windows.Forms.Label();
			this.unixTimeCol1Box = new System.Windows.Forms.TextBox();
			this.resetCol2Button = new System.Windows.Forms.Button();
			this.syncCol2Button = new System.Windows.Forms.Button();
			this.localTimeCol2Box = new System.Windows.Forms.TextBox();
			this.localTimeCol2Label = new System.Windows.Forms.Label();
			this.utcTimeCol2Box = new System.Windows.Forms.TextBox();
			this.utcTimeCol2Label = new System.Windows.Forms.Label();
			this.unixTimeCol2Label = new System.Windows.Forms.Label();
			this.unixTimeCol2Box = new System.Windows.Forms.TextBox();
			this.resetCol3Button = new System.Windows.Forms.Button();
			this.syncCol3Button = new System.Windows.Forms.Button();
			this.localTimeCol3Box = new System.Windows.Forms.TextBox();
			this.localTimeCol3Label = new System.Windows.Forms.Label();
			this.utcTimeCol3Box = new System.Windows.Forms.TextBox();
			this.utcTimeCol3Label = new System.Windows.Forms.Label();
			this.unixTimeCol3Label = new System.Windows.Forms.Label();
			this.unixTimeCol3Box = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// resetCol1Button
			// 
			this.resetCol1Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resetCol1Button.Location = new System.Drawing.Point(3, 96);
			this.resetCol1Button.MinimumSize = new System.Drawing.Size(65, 36);
			this.resetCol1Button.Name = "resetCol1Button";
			this.resetCol1Button.Size = new System.Drawing.Size(65, 38);
			this.resetCol1Button.TabIndex = 15;
			this.resetCol1Button.Text = "Reset Column";
			this.resetCol1Button.UseVisualStyleBackColor = true;
			this.resetCol1Button.Click += new System.EventHandler(this._SetTimeToNow);
			// 
			// syncCol1Button
			// 
			this.syncCol1Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.syncCol1Button.Location = new System.Drawing.Point(68, 96);
			this.syncCol1Button.MinimumSize = new System.Drawing.Size(110, 36);
			this.syncCol1Button.Name = "syncCol1Button";
			this.syncCol1Button.Size = new System.Drawing.Size(115, 38);
			this.syncCol1Button.TabIndex = 14;
			this.syncCol1Button.Text = "Synchronize Column";
			this.syncCol1Button.UseVisualStyleBackColor = true;
			this.syncCol1Button.Click += new System.EventHandler(this._Synchronize);
			// 
			// localTimeCol1Box
			// 
			this.localTimeCol1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.localTimeCol1Box.Location = new System.Drawing.Point(68, 67);
			this.localTimeCol1Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.localTimeCol1Box.Name = "localTimeCol1Box";
			this.localTimeCol1Box.Size = new System.Drawing.Size(115, 20);
			this.localTimeCol1Box.TabIndex = 13;
			this.localTimeCol1Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// localTimeCol1Label
			// 
			this.localTimeCol1Label.AutoSize = true;
			this.localTimeCol1Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.localTimeCol1Label.Location = new System.Drawing.Point(3, 62);
			this.localTimeCol1Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.localTimeCol1Label.Name = "localTimeCol1Label";
			this.localTimeCol1Label.Size = new System.Drawing.Size(65, 31);
			this.localTimeCol1Label.TabIndex = 12;
			this.localTimeCol1Label.Text = "Local Time:";
			this.localTimeCol1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// utcTimeCol1Box
			// 
			this.utcTimeCol1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.utcTimeCol1Box.Location = new System.Drawing.Point(68, 36);
			this.utcTimeCol1Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.utcTimeCol1Box.Name = "utcTimeCol1Box";
			this.utcTimeCol1Box.Size = new System.Drawing.Size(115, 20);
			this.utcTimeCol1Box.TabIndex = 11;
			this.utcTimeCol1Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// utcTimeCol1Label
			// 
			this.utcTimeCol1Label.AutoSize = true;
			this.utcTimeCol1Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcTimeCol1Label.Location = new System.Drawing.Point(3, 31);
			this.utcTimeCol1Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.utcTimeCol1Label.Name = "utcTimeCol1Label";
			this.utcTimeCol1Label.Size = new System.Drawing.Size(65, 31);
			this.utcTimeCol1Label.TabIndex = 10;
			this.utcTimeCol1Label.Text = "UTC Time:";
			this.utcTimeCol1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol1Label
			// 
			this.unixTimeCol1Label.AutoSize = true;
			this.unixTimeCol1Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unixTimeCol1Label.Location = new System.Drawing.Point(3, 0);
			this.unixTimeCol1Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.unixTimeCol1Label.Name = "unixTimeCol1Label";
			this.unixTimeCol1Label.Size = new System.Drawing.Size(65, 31);
			this.unixTimeCol1Label.TabIndex = 9;
			this.unixTimeCol1Label.Text = "Unix Time:";
			this.unixTimeCol1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol1Box
			// 
			this.unixTimeCol1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.unixTimeCol1Box.Location = new System.Drawing.Point(68, 5);
			this.unixTimeCol1Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.unixTimeCol1Box.Name = "unixTimeCol1Box";
			this.unixTimeCol1Box.Size = new System.Drawing.Size(115, 20);
			this.unixTimeCol1Box.TabIndex = 8;
			this.unixTimeCol1Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// resetCol2Button
			// 
			this.resetCol2Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resetCol2Button.Location = new System.Drawing.Point(189, 96);
			this.resetCol2Button.MinimumSize = new System.Drawing.Size(65, 36);
			this.resetCol2Button.Name = "resetCol2Button";
			this.resetCol2Button.Size = new System.Drawing.Size(65, 38);
			this.resetCol2Button.TabIndex = 15;
			this.resetCol2Button.Text = "Reset Column";
			this.resetCol2Button.UseVisualStyleBackColor = true;
			this.resetCol2Button.Click += new System.EventHandler(this._SetTimeToNow);
			// 
			// syncCol2Button
			// 
			this.syncCol2Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.syncCol2Button.Location = new System.Drawing.Point(254, 96);
			this.syncCol2Button.MinimumSize = new System.Drawing.Size(110, 36);
			this.syncCol2Button.Name = "syncCol2Button";
			this.syncCol2Button.Size = new System.Drawing.Size(115, 38);
			this.syncCol2Button.TabIndex = 14;
			this.syncCol2Button.Text = "Synchronize Column";
			this.syncCol2Button.UseVisualStyleBackColor = true;
			this.syncCol2Button.Click += new System.EventHandler(this._Synchronize);
			// 
			// localTimeCol2Box
			// 
			this.localTimeCol2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.localTimeCol2Box.Location = new System.Drawing.Point(254, 67);
			this.localTimeCol2Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.localTimeCol2Box.Name = "localTimeCol2Box";
			this.localTimeCol2Box.Size = new System.Drawing.Size(115, 20);
			this.localTimeCol2Box.TabIndex = 13;
			this.localTimeCol2Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// localTimeCol2Label
			// 
			this.localTimeCol2Label.AutoSize = true;
			this.localTimeCol2Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.localTimeCol2Label.Location = new System.Drawing.Point(189, 62);
			this.localTimeCol2Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.localTimeCol2Label.Name = "localTimeCol2Label";
			this.localTimeCol2Label.Size = new System.Drawing.Size(65, 31);
			this.localTimeCol2Label.TabIndex = 12;
			this.localTimeCol2Label.Text = "Local Time:";
			this.localTimeCol2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// utcTimeCol2Box
			// 
			this.utcTimeCol2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.utcTimeCol2Box.Location = new System.Drawing.Point(254, 36);
			this.utcTimeCol2Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.utcTimeCol2Box.Name = "utcTimeCol2Box";
			this.utcTimeCol2Box.Size = new System.Drawing.Size(115, 20);
			this.utcTimeCol2Box.TabIndex = 11;
			this.utcTimeCol2Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// utcTimeCol2Label
			// 
			this.utcTimeCol2Label.AutoSize = true;
			this.utcTimeCol2Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcTimeCol2Label.Location = new System.Drawing.Point(189, 31);
			this.utcTimeCol2Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.utcTimeCol2Label.Name = "utcTimeCol2Label";
			this.utcTimeCol2Label.Size = new System.Drawing.Size(65, 31);
			this.utcTimeCol2Label.TabIndex = 10;
			this.utcTimeCol2Label.Text = "UTC Time:";
			this.utcTimeCol2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol2Label
			// 
			this.unixTimeCol2Label.AutoSize = true;
			this.unixTimeCol2Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unixTimeCol2Label.Location = new System.Drawing.Point(189, 0);
			this.unixTimeCol2Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.unixTimeCol2Label.Name = "unixTimeCol2Label";
			this.unixTimeCol2Label.Size = new System.Drawing.Size(65, 31);
			this.unixTimeCol2Label.TabIndex = 9;
			this.unixTimeCol2Label.Text = "Unix Time:";
			this.unixTimeCol2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol2Box
			// 
			this.unixTimeCol2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.unixTimeCol2Box.Location = new System.Drawing.Point(254, 5);
			this.unixTimeCol2Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.unixTimeCol2Box.Name = "unixTimeCol2Box";
			this.unixTimeCol2Box.Size = new System.Drawing.Size(115, 20);
			this.unixTimeCol2Box.TabIndex = 8;
			this.unixTimeCol2Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// resetCol3Button
			// 
			this.resetCol3Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resetCol3Button.Location = new System.Drawing.Point(375, 96);
			this.resetCol3Button.MinimumSize = new System.Drawing.Size(65, 36);
			this.resetCol3Button.Name = "resetCol3Button";
			this.resetCol3Button.Size = new System.Drawing.Size(65, 38);
			this.resetCol3Button.TabIndex = 15;
			this.resetCol3Button.Text = "Reset Column";
			this.resetCol3Button.UseVisualStyleBackColor = true;
			this.resetCol3Button.Click += new System.EventHandler(this._SetTimeToNow);
			// 
			// syncCol3Button
			// 
			this.syncCol3Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.syncCol3Button.Location = new System.Drawing.Point(440, 96);
			this.syncCol3Button.MinimumSize = new System.Drawing.Size(110, 36);
			this.syncCol3Button.Name = "syncCol3Button";
			this.syncCol3Button.Size = new System.Drawing.Size(116, 38);
			this.syncCol3Button.TabIndex = 14;
			this.syncCol3Button.Text = "Synchronize Column";
			this.syncCol3Button.UseVisualStyleBackColor = true;
			this.syncCol3Button.Click += new System.EventHandler(this._Synchronize);
			// 
			// localTimeCol3Box
			// 
			this.localTimeCol3Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.localTimeCol3Box.Location = new System.Drawing.Point(440, 67);
			this.localTimeCol3Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.localTimeCol3Box.Name = "localTimeCol3Box";
			this.localTimeCol3Box.Size = new System.Drawing.Size(116, 20);
			this.localTimeCol3Box.TabIndex = 13;
			this.localTimeCol3Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// localTimeCol3Label
			// 
			this.localTimeCol3Label.AutoSize = true;
			this.localTimeCol3Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.localTimeCol3Label.Location = new System.Drawing.Point(375, 62);
			this.localTimeCol3Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.localTimeCol3Label.Name = "localTimeCol3Label";
			this.localTimeCol3Label.Size = new System.Drawing.Size(65, 31);
			this.localTimeCol3Label.TabIndex = 12;
			this.localTimeCol3Label.Text = "Local Time:";
			this.localTimeCol3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// utcTimeCol3Box
			// 
			this.utcTimeCol3Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.utcTimeCol3Box.Location = new System.Drawing.Point(440, 36);
			this.utcTimeCol3Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.utcTimeCol3Box.Name = "utcTimeCol3Box";
			this.utcTimeCol3Box.Size = new System.Drawing.Size(116, 20);
			this.utcTimeCol3Box.TabIndex = 11;
			this.utcTimeCol3Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// utcTimeCol3Label
			// 
			this.utcTimeCol3Label.AutoSize = true;
			this.utcTimeCol3Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcTimeCol3Label.Location = new System.Drawing.Point(375, 31);
			this.utcTimeCol3Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.utcTimeCol3Label.Name = "utcTimeCol3Label";
			this.utcTimeCol3Label.Size = new System.Drawing.Size(65, 31);
			this.utcTimeCol3Label.TabIndex = 10;
			this.utcTimeCol3Label.Text = "UTC Time:";
			this.utcTimeCol3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol3Label
			// 
			this.unixTimeCol3Label.AutoSize = true;
			this.unixTimeCol3Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unixTimeCol3Label.Location = new System.Drawing.Point(375, 0);
			this.unixTimeCol3Label.MinimumSize = new System.Drawing.Size(65, 15);
			this.unixTimeCol3Label.Name = "unixTimeCol3Label";
			this.unixTimeCol3Label.Size = new System.Drawing.Size(65, 31);
			this.unixTimeCol3Label.TabIndex = 9;
			this.unixTimeCol3Label.Text = "Unix Time:";
			this.unixTimeCol3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// unixTimeCol3Box
			// 
			this.unixTimeCol3Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.unixTimeCol3Box.Location = new System.Drawing.Point(440, 5);
			this.unixTimeCol3Box.MinimumSize = new System.Drawing.Size(110, 20);
			this.unixTimeCol3Box.Name = "unixTimeCol3Box";
			this.unixTimeCol3Box.Size = new System.Drawing.Size(116, 20);
			this.unixTimeCol3Box.TabIndex = 8;
			this.unixTimeCol3Box.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.ColumnCount = 6;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.Controls.Add(this.resetCol1Button, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.resetCol2Button, 2, 3);
			this.tableLayoutPanel.Controls.Add(this.syncCol1Button, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.syncCol3Button, 5, 3);
			this.tableLayoutPanel.Controls.Add(this.syncCol2Button, 3, 3);
			this.tableLayoutPanel.Controls.Add(this.resetCol3Button, 4, 3);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol1Label, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol1Label, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol3Box, 5, 0);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol3Box, 5, 1);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol3Box, 5, 2);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol2Box, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol3Label, 4, 2);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol2Box, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol2Box, 3, 2);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol3Label, 4, 1);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol1Box, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol3Label, 4, 0);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol1Label, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol1Box, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.utcTimeCol2Label, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol1Box, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.unixTimeCol2Label, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.localTimeCol2Label, 2, 2);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(540, 125);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(559, 137);
			this.tableLayoutPanel.TabIndex = 17;
			// 
			// TimeConverterFormAdvanced
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 137);
			this.Controls.Add(this.tableLayoutPanel);
			this.MinimumSize = new System.Drawing.Size(575, 175);
			this.Name = "TimeConverterFormAdvanced";
			this.Text = "TimeConverterFormAdvanced";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resetCol1Button;
		private System.Windows.Forms.Button syncCol1Button;
		private System.Windows.Forms.TextBox localTimeCol1Box;
		private System.Windows.Forms.Label localTimeCol1Label;
		private System.Windows.Forms.TextBox utcTimeCol1Box;
		private System.Windows.Forms.Label utcTimeCol1Label;
		private System.Windows.Forms.Label unixTimeCol1Label;
		private System.Windows.Forms.TextBox unixTimeCol1Box;
		private System.Windows.Forms.Button resetCol2Button;
		private System.Windows.Forms.Button syncCol2Button;
		private System.Windows.Forms.TextBox localTimeCol2Box;
		private System.Windows.Forms.Label localTimeCol2Label;
		private System.Windows.Forms.TextBox utcTimeCol2Box;
		private System.Windows.Forms.Label utcTimeCol2Label;
		private System.Windows.Forms.Label unixTimeCol2Label;
		private System.Windows.Forms.TextBox unixTimeCol2Box;
		private System.Windows.Forms.Button resetCol3Button;
		private System.Windows.Forms.Button syncCol3Button;
		private System.Windows.Forms.TextBox localTimeCol3Box;
		private System.Windows.Forms.Label localTimeCol3Label;
		private System.Windows.Forms.TextBox utcTimeCol3Box;
		private System.Windows.Forms.Label utcTimeCol3Label;
		private System.Windows.Forms.Label unixTimeCol3Label;
		private System.Windows.Forms.TextBox unixTimeCol3Box;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
	}
}