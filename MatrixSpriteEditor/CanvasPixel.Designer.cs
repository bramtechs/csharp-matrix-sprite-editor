namespace MatrixSpriteEditor
{
	partial class CanvasPixel
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
			this.pixelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pixelButton
			// 
			this.pixelButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pixelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pixelButton.Location = new System.Drawing.Point(0, 0);
			this.pixelButton.Name = "pixelButton";
			this.pixelButton.Size = new System.Drawing.Size(32, 32);
			this.pixelButton.TabIndex = 0;
			this.pixelButton.UseVisualStyleBackColor = true;
			this.pixelButton.Click += new System.EventHandler(this.pixelButton_Click);
			// 
			// CanvasPixel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pixelButton);
			this.Name = "CanvasPixel";
			this.Size = new System.Drawing.Size(32, 32);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button pixelButton;
	}
}
