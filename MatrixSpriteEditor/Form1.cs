using System.Windows.Forms;

namespace MatrixSpriteEditor
{
	public partial class Form1 : Form
	{
		private CanvasPixel[,] pixels;

		public Form1()
		{
			InitializeComponent();
			pixels = new CanvasPixel[8,8];

			// canvas instellen
			for (int y = 0; y < 8; y++)
			{
				for (int x = 0; x < 8; x++)
				{
					CanvasPixel pixel = new CanvasPixel(this);
					canvasLayout.Controls.Add(pixel);
					pixels[x,y] = pixel;
				}
			}
			Genereer();
		}

		public void Genereer()
		{
			string result = "";
			for (int y = 0; y < 8; y++)
			{
				result += "0b";
				for (int x = 0; x < 8; x++)
				{
					if (pixels[x,y].isAan)
					{
						result += "1";
					}
					else
					{
						result += "0";
					}
				}
				if (y != 7) { 
					result += ",\n";
				}
			}
			textBoxExport.Text = result;
		}
	}
}
