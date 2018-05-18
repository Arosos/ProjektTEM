using System;
using System.Drawing;
using System.Reflection;

namespace ProjektTEM
{
    static class ImageFiltering
    {
        public static Color[,] pattern = new Color[3, 3]
        {
            { Color.Black, Color.Black, Color.Black },
            { Color.Black, Color.Blue, Color.Black },
            { Color.Black, Color.Black, Color.Black }
        };

        public static string Threshold(string filename, float thresholdFactor)
        {
            Bitmap bmp = new Bitmap(Image.FromFile(filename));
            Bitmap newBmp = (Bitmap)bmp.Clone();
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    int averageColor = (color.R + color.G + color.B) / 3;
                    if (averageColor <= 255 / thresholdFactor)
                        color = Color.Black;
                    else
                        color = Color.White;
                    newBmp.SetPixel(x, y, color);
                }
            }
            return ImageUtil.SaveImage(filename, newBmp, "Thresholded");
        }

        public static string Filter(string filename, Morphology type)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(filename);
            MethodInfo method = typeof(ImageFiltering).GetMethod(type.ToString());
            Bitmap newBmp = (Bitmap)method.Invoke(null, new object[] { bmp });
            return ImageUtil.SaveImage(filename, newBmp, type.ToString());
        }

        public static Bitmap Erosion(Bitmap bmp)
        {
            return ImageUtil.MinkowskiSum(bmp, Color.White);
        }

        public static Bitmap Dilation(Bitmap bmp)
        {
            return ImageUtil.MinkowskiSum(bmp, Color.Black);
        }

        public static Bitmap Opening(Bitmap bmp)
        {
            return Dilation(Erosion(bmp));
        }

        public static Bitmap Closing(Bitmap bmp)
        {
            return Erosion(Dilation(bmp));
        }

        public static Bitmap Thinning(Bitmap bmp)
        {
            return ImageUtil.HitOrMiss(bmp, pattern, Color.White);
        }

        public static Bitmap Thickening(Bitmap bmp)
        {
            return ImageUtil.HitOrMiss(bmp, pattern, Color.Black);
        }
    }
}
