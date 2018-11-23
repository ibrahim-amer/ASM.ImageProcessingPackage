using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace CsharpGUI
{
    

    public class UnsafeBitmap
    {
        /// <summary>
        /// Represents the original Bitmap object 
        /// </summary>
        private Bitmap originalBitmap;
        private bool bitsLocked = false;

        public bool BitsLocked
        {
            get { return bitsLocked; }
            private set { bitsLocked = value; }
        }

        public Bitmap OriginalBitmap
        {
            get { return originalBitmap; }
            private set { originalBitmap = value; }
        }

        public Bitmap BitmapObject
        {
            get { return originalBitmap; }
            set { originalBitmap = value; }
        }
        /// <summary>
        /// Represents BitmapData of the original Bitmap
        /// </summary>
        private BitmapData bitmapData;

        public BitmapData BitmapData
        {
            get { return bitmapData; }
            set { bitmapData = value; }
        }
        /// <summary>
        /// PixelFormat of the orignal Bitmap (24Bpp, 32Bpp, 8BppIndexed, 4BppIndexed, 1BppIndexed)
        /// </summary>
        private PixelFormat pixelFormat;
        /// <summary>
        /// PixelFormat of the orignal Bitmap (24Bpp, 32Bpp, 8BppIndexed, 4BppIndexed, 1BppIndexed)
        /// </summary>
        public PixelFormat PixelFormat
        {
            get { return pixelFormat; }
            private set { pixelFormat = value; }
        }
        /// <summary>
        /// How many bytes per pixel
        /// </summary>
        private double pixelSize;
        /// <summary>
        /// Width of the original Bitmap
        /// </summary>
        private int width;

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }
        /// <summary>
        /// Height of the original Bitmap
        /// </summary>
        private int height;

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }
        public UnsafeBitmap()
        {

        }
        /// <summary>
        ///  Creates a new UnsafeBitmap Object from a Bitmap Object.
        /// </summary>
        /// <param name="originalBitmap">Orignal Bitmap Object</param>
        /// <param name="lockBits">If true, it lock bits by default</param>
        public UnsafeBitmap(Bitmap originalBitmap, bool lockBits = true)
        {
            //this.originalBitmap = (Bitmap)originalBitmap.Clone();
            this.originalBitmap = originalBitmap;
            this.width = originalBitmap.Width;
            this.height = originalBitmap.Height;
            this.pixelFormat = this.originalBitmap.PixelFormat;
            if (this.pixelFormat == PixelFormat.Format32bppArgb)
                this.pixelSize = 4;

            else if (this.pixelFormat == PixelFormat.Format24bppRgb)
                this.pixelSize = 3;
            else
            {
                this.originalBitmap = (Bitmap)ConvertToNewFormat(this.originalBitmap, PixelFormat.Format24bppRgb).Clone();
                this.pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
                this.pixelSize = 3;
                this.pixelSize = 3;
            }

            if (lockBits)
                this.LockBits();
        }
        /// <summary>
        ///  Creates a new UnsafeBitmap Object using width and height.
        /// </summary>
        /// <param name="width">Width of the image</param>
        /// <param name="height">Height of the image</param>
        /// <param name="lockBits">If true, it lock bits by default</param>
        public UnsafeBitmap(int width, int height, bool lockBits = true)
        {
            this.width = width;
            this.height = height;
            this.originalBitmap = new Bitmap(width, height);
            this.pixelFormat = this.originalBitmap.PixelFormat;
            if (this.pixelFormat == PixelFormat.Format32bppArgb)
                this.pixelSize = 4;

            else if (this.pixelFormat == PixelFormat.Format24bppRgb)
                this.pixelSize = 3;
            else
            {
                this.originalBitmap = (Bitmap)ConvertToNewFormat(this.originalBitmap, PixelFormat.Format24bppRgb).Clone();
                this.pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
                this.pixelSize = 3;
                this.pixelSize = 3;
            }
            //else if (this.pixelFormat == PixelFormat.Format8bppIndexed)
            //    this.pixelSize = 1;
            //else if (this.pixelFormat == PixelFormat.Format4bppIndexed)
            //    this.pixelSize = 0.5;
            //else if (this.pixelFormat == PixelFormat.Format1bppIndexed)
            //    this.pixelSize = 0.125;
            //else
            //    throw new NotSupportedException(this.pixelFormat.ToString() + " Type is currently not supported");

            if (lockBits)
                this.LockBits();
        }
        /// <summary>
        ///  Creates a new UnsafeBitmap Object from a file.
        /// </summary>
        /// <param name="filename">filename of the location of the Bitmap Object</param>
        /// <param name="lockBits">If true, it lock bits by default</param>
        public UnsafeBitmap(string filename, bool lockBits = true)
        {
            this.originalBitmap = (Bitmap)Bitmap.FromFile(filename);
            this.width = originalBitmap.Width;
            this.height = originalBitmap.Height;
            this.pixelFormat = this.originalBitmap.PixelFormat;
            if (this.pixelFormat == PixelFormat.Format32bppArgb)
                this.pixelSize = 4;

            else if (this.pixelFormat == PixelFormat.Format24bppRgb)
                this.pixelSize = 3;

            else
            {
                this.originalBitmap = (Bitmap)ConvertToNewFormat(this.originalBitmap, PixelFormat.Format24bppRgb).Clone();
                this.pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
                this.pixelSize = 3;
            }
            //else if (this.pixelFormat == PixelFormat.Format8bppIndexed)
            //    this.pixelSize = 1;
            //else if (this.pixelFormat == PixelFormat.Format4bppIndexed)
            //    this.pixelSize = 0.5;
            //else if (this.pixelFormat == PixelFormat.Format1bppIndexed)
            //    this.pixelSize = 0.125;
            //else
            //    throw new NotSupportedException(this.pixelFormat.ToString() + " Type is currently not supported");
            if (lockBits)
                this.LockBits();
        }
        /// <summary>
        /// Cretes new UnsafeBitmap object from file location
        /// </summary>
        /// <param name="filename">file location of the image</param>
        /// <returns></returns>
        public static UnsafeBitmap FromFile(string filename)
        {
            return new UnsafeBitmap(filename, true);
        }
        /// <summary>
        /// Gets the color of the specified pixel in this Bitmap.
        /// </summary>
        /// <param name="x">The x-coordinate of the pixel to retrieve.</param>
        /// <param name="y">The y-coordinate of the pixel to retrieve.</param>
        /// <returns>A Color structure that represents the color of the specified pixel.</returns>
        public Color GetPixel(int x, int y)
        {
            if (x >= this.width || y >= this.height)
                throw new IndexOutOfRangeException();

            Color color = new Color();
            int R, G, B, alpha;
            unsafe
            {
                byte* row = (byte*)bitmapData.Scan0 + (y * bitmapData.Stride);
                if (this.pixelFormat == PixelFormat.Format32bppArgb)
                {
                    B = row[(int)(x * this.pixelSize)];
                    G = row[(int)(x * this.pixelSize + 1)];
                    R = row[(int)(x * this.pixelSize + 2)];
                    alpha = row[(int)(x * this.pixelSize + 3)];
                    color = Color.FromArgb(alpha, R, G, B);
                }
                else if (this.pixelFormat == PixelFormat.Format24bppRgb)
                {
                    B = row[(int)(x * this.pixelSize)];
                    G = row[(int)(x * this.pixelSize + 1)];
                    R = row[(int)(x * this.pixelSize + 2)];
                    color = Color.FromArgb(R, G, B);
                }
                else
                {
                    B = row[(int)(x * this.pixelSize)];
                    color = Color.FromArgb(B, B, B);
                }

            }
            return color;
        }
        /// <summary>
        /// Sets the color of the specified pixel in this Bitmap.
        /// </summary>
        /// <param name="x">The x-coordinate of the pixel to set.</param>
        /// <param name="y">The y-coordinate of the pixel to set.</param>
        /// <param name="color">A Color structure that represents the color to assign to the specified pixel.</param>
        public void SetPixel(int x, int y, Color color)
        {
            if (x >= this.width || y >= this.height)
                throw new IndexOutOfRangeException();

            unsafe
            {
                byte* row = (byte*)bitmapData.Scan0 + (y * bitmapData.Stride);
                if (this.pixelFormat == PixelFormat.Format32bppArgb)
                {
                    row[(int)(x * this.pixelSize)] = color.B;
                    row[(int)(x * this.pixelSize + 1)] = color.G;
                    row[(int)(x * this.pixelSize + 2)] = color.R;
                    row[(int)(x * this.pixelSize + 3)] = color.A;
                }
                else if (this.pixelFormat == PixelFormat.Format24bppRgb)
                {
                    row[(int)(x * this.pixelSize)] = color.B;
                    row[(int)(x * this.pixelSize + 1)] = color.G;
                    row[(int)(x * this.pixelSize + 2)] = color.R;
                }
                else
                {
                    row[(int)(x * this.pixelSize)] = color.B;
                }
            }
        }


        public BitmapData LockBits()
        {
            if (!this.bitsLocked)
            {
                this.bitmapData = this.originalBitmap.LockBits(new Rectangle(0, 0, this.width, this.height),
                        ImageLockMode.ReadWrite, this.pixelFormat);
                this.bitsLocked = true;
            }
            else
                throw new Exception("Bitmap region is already locked");
            return this.bitmapData;
        }

        public void UnlockBits()
        {
            if (this.bitsLocked)
            {
                this.originalBitmap.UnlockBits(this.bitmapData);
                this.bitsLocked = false;
            }
            else
                throw new Exception("Bitmap region is already unlocked");
        }

        public Color[,] GetBuffer()
        {
            Color[,] buffer = new Color[this.width, this.height];
            for (int i = 0; i < this.width; i++)
                for (int j = 0; j < this.height; j++)
                    buffer[i, j] = this.GetPixel(i, j);

            return buffer;
        }
        public static Bitmap ConvertToNewFormat(Bitmap image, PixelFormat newFormat)
        {
            Bitmap ret = new Bitmap(image.Width, image.Height);
            using (Bitmap newBmp = new Bitmap(image))
            using (Bitmap targetBmp = newBmp.Clone(new Rectangle(0, 0, newBmp.Width, newBmp.Height), PixelFormat.Format24bppRgb))
            {
                ret = (Bitmap)targetBmp.Clone();
            }
            return ret;
        }
    }
}
