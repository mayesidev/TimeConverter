namespace TimeConverter
{
	partial class TimeConverterForm
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
			this.unixTimeBox = new System.Windows.Forms.TextBox();
			this.unixTimeLabel = new System.Windows.Forms.Label();
			this.utcTimeLabel = new System.Windows.Forms.Label();
			this.utcTimeBox = new System.Windows.Forms.TextBox();
			this.localTimeLabel = new System.Windows.Forms.Label();
			this.localTimeBox = new System.Windows.Forms.TextBox();
			this.syncButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// unixTimeBox
			// 
			this.unixTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.unixTimeBox.Location = new System.Drawing.Point(80, 12);
			this.unixTimeBox.Name = "unixTimeBox";
			this.unixTimeBox.Size = new System.Drawing.Size(192, 20);
			this.unixTimeBox.TabIndex = 0;
			this.unixTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// unixTimeLabel
			// 
			this.unixTimeLabel.AutoSize = true;
			this.unixTimeLabel.Location = new System.Drawing.Point(12, 15);
			this.unixTimeLabel.Name = "unixTimeLabel";
			this.unixTimeLabel.Size = new System.Drawing.Size(57, 13);
			this.unixTimeLabel.TabIndex = 1;
			this.unixTimeLabel.Text = "Unix Time:";
			// 
			// utcTimeLabel
			// 
			this.utcTimeLabel.AutoSize = true;
			this.utcTimeLabel.Location = new System.Drawing.Point(12, 50);
			this.utcTimeLabel.Name = "utcTimeLabel";
			this.utcTimeLabel.Size = new System.Drawing.Size(58, 13);
			this.utcTimeLabel.TabIndex = 2;
			this.utcTimeLabel.Text = "UTC Time:";
			// 
			// utcTimeBox
			// 
			this.utcTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.utcTimeBox.Location = new System.Drawing.Point(80, 47);
			this.utcTimeBox.Name = "utcTimeBox";
			this.utcTimeBox.Size = new System.Drawing.Size(192, 20);
			this.utcTimeBox.TabIndex = 3;
			this.utcTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// localTimeLabel
			// 
			this.localTimeLabel.AutoSize = true;
			this.localTimeLabel.Location = new System.Drawing.Point(12, 85);
			this.localTimeLabel.Name = "localTimeLabel";
			this.localTimeLabel.Size = new System.Drawing.Size(62, 13);
			this.localTimeLabel.TabIndex = 4;
			this.localTimeLabel.Text = "Local Time:";
			// 
			// localTimeBox
			// 
			this.localTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.localTimeBox.Location = new System.Drawing.Point(80, 82);
			this.localTimeBox.Name = "localTimeBox";
			this.localTimeBox.Size = new System.Drawing.Size(192, 20);
			this.localTimeBox.TabIndex = 5;
			this.localTimeBox.TextChanged += new System.EventHandler(this._TimeBoxTextChanged);
			// 
			// syncButton
			// 
			this.syncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.syncButton.Location = new System.Drawing.Point(147, 117);
			this.syncButton.Name = "syncButton";
			this.syncButton.Size = new System.Drawing.Size(125, 43);
			this.syncButton.TabIndex = 6;
			this.syncButton.Text = "Synchronize";
			this.syncButton.UseVisualStyleBackColor = true;
			this.syncButton.Click += new System.EventHandler(this._Synchronize);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resetButton.Location = new System.Drawing.Point(12, 117);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(125, 43);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this._SetTimeToNow);
			// 
			// TimeConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 172);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.syncButton);
			this.Controls.Add(this.localTimeBox);
			this.Controls.Add(this.localTimeLabel);
			this.Controls.Add(this.utcTimeBox);
			this.Controls.Add(this.utcTimeLabel);
			this.Controls.Add(this.unixTimeLabel);
			this.Controls.Add(this.unixTimeBox);
			this.MinimumSize = new System.Drawing.Size(300, 210);
			this.Name = "TimeConverterForm";
			this.Text = "Time Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox unixTimeBox;
		private System.Windows.Forms.Label unixTimeLabel;
		private System.Windows.Forms.Label utcTimeLabel;
		private System.Windows.Forms.TextBox utcTimeBox;
		private System.Windows.Forms.Label localTimeLabel;
		private System.Windows.Forms.TextBox localTimeBox;
		private System.Windows.Forms.Button syncButton;
		private System.Windows.Forms.Button resetButton;
	}
}

