using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixSpriteEditor
{
	public partial class CanvasPixel : UserControl
	{
		public bool isAan;
		private Form1 form;

		public CanvasPixel(Form1 form)
		{
			this.form = form;
			InitializeComponent();
			BackColor = Color.Black;
		}

		private void pixelButton_Click(object sender, EventArgs e)
		{
			isAan = !isAan;
			if (isAan)
			{
				BackColor = Color.Orange;
			}
			else
			{
				BackColor = Color.Black;
			}
			form.Genereer();
		}
	}
}
