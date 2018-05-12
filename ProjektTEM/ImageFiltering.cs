using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTEM
{
    public static class ImageFiltering
    {
        public static string Threshold(string filename)
        {
            Bitmap bmp = new Bitmap(Image.FromFile(filename));
            Bitmap newBmp = (Bitmap)bmp.Clone();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int averageColor = (color.R + color.G + color.B) / 3;
                    if (averageColor <= 255 / 1.75)
                        color = Color.Black;
                    else
                        color = Color.White;
                    newBmp.SetPixel(i, j, color);
                }
            }
            string[] path = filename.Split('.');
            string newFilename = path[0] + "Thresholded." + path[1];
            newBmp.Save(newFilename);
            return newFilename;
        }
    }
}
