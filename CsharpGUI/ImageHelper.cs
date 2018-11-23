using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CsharpGUI
{
    public class ImageBuffers
    {
        public int []RedChannel { get; set; }
        public int []BlueChannel { get; set; }
        public int []GreenChannel { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public static class ImageHelper
    {

        public static ImageBuffers CreateNewImageBuffersObject(int []redChannel, int[]greenChannel, int[]blueChannel, int width, int height)
        {
            try
            {
                return new ImageBuffers
                {
                    RedChannel = redChannel,
                    GreenChannel = greenChannel,
                    BlueChannel = blueChannel,
                    Width = width,
                    Height = height
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static ImageBuffers GetBuffersFromImage(Bitmap bmp)
        {
            try
            {
                UnsafeBitmap unsafeBitmap = new UnsafeBitmap(bmp);
                ImageBuffers buffers = new ImageBuffers();
                buffers.RedChannel = new int[bmp.Width * bmp.Height];
                buffers.GreenChannel = new int[bmp.Width * bmp.Height];
                buffers.BlueChannel = new int[bmp.Width * bmp.Height];

                buffers.Width = bmp.Width;
                buffers.Height = bmp.Height;

                int count = 0;

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        buffers.RedChannel[count] = unsafeBitmap.GetPixel(i, j).R;
                        buffers.GreenChannel[count] = unsafeBitmap.GetPixel(i, j).G;
                        buffers.BlueChannel[count++] = unsafeBitmap.GetPixel(i, j).B;
                    }
                }
                unsafeBitmap.UnlockBits();
                return buffers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static UnsafeBitmap GetImageFromBuffers(ImageBuffers buffers)
        {
            try
            {
                UnsafeBitmap bmp = new UnsafeBitmap(buffers.Width, buffers.Height);
                int count = 0;

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        int R = buffers.RedChannel[count];
                        int G = buffers.GreenChannel[count];
                        int B = buffers.BlueChannel[count++];

                        bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
                bmp.UnlockBits();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
