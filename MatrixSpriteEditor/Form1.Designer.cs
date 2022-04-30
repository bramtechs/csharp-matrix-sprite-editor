namespace MatrixSpriteEditor
{
	partial class Form1
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.canvasLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxExport = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBoxExport);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.canvasLayout);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 266;
			this.splitContainer1.TabIndex = 0;
			// 
			// canvasLayout
			// 
			this.canvasLayout.Location = new System.Drawing.Point(111, 71);
			this.canvasLayout.Name = "canvasLayout";
			this.canvasLayout.Size = new System.Drawing.Size(320, 301);
			this.canvasLayout.TabIndex = 0;
			// 
			// textBoxExport
			// 
			this.textBoxExport.BackColor = System.Drawing.Color.Azure;
			this.textBoxExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxExport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxExport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxExport.Location = new System.Drawing.Point(0, 0);
			this.textBoxExport.Name = "textBoxExport";
			this.textBoxExport.ReadOnly = true;
			this.textBoxExport.Size = new System.Drawing.Size(266, 450);
			this.textBoxExport.TabIndex = 0;
			this.textBoxExport.Text = "";
			this.textBoxExport.WordWrap = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Matrix Sprite Editor";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.FlowLayoutPanel canvasLayout;
		private System.Windows.Forms.RichTextBox textBoxExport;
	}
}

