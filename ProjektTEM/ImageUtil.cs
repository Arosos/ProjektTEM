using System.Drawing;

namespace ProjektTEM
{
    static class ImageUtil
    {
        public static int NeighborCount(Bitmap image, int x, int y, Color color)
        {
            int count = 0, compareColor = color.ToArgb();
            for (int i = x - 1; i <= x + 1; i++)
                if (i >= 0 && i < image.Width)
                    for (int j = y - 1; j <= y + 1; j++)
                        if (j >= 0 && j < image.Height)
                            if (image.GetPixel(i, j).ToArgb() == compareColor)
                                count++;
            return count;
        }

        public static string AddSuffix(string filename, string suffix)
        {
            string[] path = filename.Split('.');
            return path[0] + suffix + '.' + path[1];
        }

        public static Bitmap MinkowskiSum(Bitmap bmp, Color color)
        {
            Bitmap newBmp = (Bitmap)bmp.Clone();
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                    if (NeighborCount(bmp, x, y, color) > 0)
                        newBmp.SetPixel(x, y, color);
            return newBmp;
        }

        public static Bitmap HitOrMiss(Bitmap bmp, Color[,] pattern, Color colorToInsert)
        {
            Bitmap newBmp = (Bitmap)bmp.Clone();
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (IsPatternHit(bmp, x, y, pattern))
                        newBmp.SetPixel(x, y, colorToInsert);
                }
            }
            return newBmp;
        }

        static bool IsPatternHit(Bitmap bmp, int x, int y, Color[,] pattern)
        {
            int dX = (pattern.GetLength(0) - 1) / 2;
            int dY = (pattern.GetLength(1) - 1) / 2;
            for (int imageX = x - dX, patternX = 0; imageX <= x + dX; imageX++, patternX++)
                if (imageX >= 0 && imageX < bmp.Width)
                    for (int imageY = y - dY, patternY = 0; imageY <= y + dY; imageY++, patternY++)
                        if (imageY >= 0 && imageY < bmp.Height)
                            if (pattern[patternX, patternY].ToArgb() != Color.Blue.ToArgb())
                            {
                                if (bmp.GetPixel(imageX, imageY).ToArgb() != pattern[patternX, patternY].ToArgb())
                                    return false;
                            }
                            else
                                continue;
            return true;
        }
    }
}
