using System;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Sim.Pdf.Images
{
    public class Utilities
    {
        /// <summary>
        /// Creates an image with a stretched palette, converts the pixels of the
        /// original image for that new palette, and hides a message in the converted pixels
        /// </summary>
        /// <param name="bmp">The original image</param>
        /// <param name="palette">The new palette</param>
        /// <param name="colorIndexToNewIndices">
        /// Hashtable which maps every index in the original palette
        /// to a list of indices in the new palette.
        /// </param>
        /// <param name="messageStream">The secret message</param>
        /// <param name="keyStream">A key that specifies the distances between two pixels used to hide a bit</param>
        /// <returns>The new bitmap</returns>
        internal Bitmap CreateBitmap(Bitmap bmp, ArrayList palette, Hashtable colorIndexToNewIndices)
        {

            BitmapData bmpData = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

            //size of the image data in bytes
            int imageSize = (bmpData.Height * bmpData.Stride) + (palette.Count * 4);

            //copy all pixels
            byte[] pixels = new byte[imageSize];
            Marshal.Copy(bmpData.Scan0, pixels, 0, (bmpData.Height * bmpData.Stride));
                       
            //Now we have the palette and the new pixels - enough data to write the bitmap!

            BinaryWriter bw = new BinaryWriter(new MemoryStream());

            //write bitmap file header
            bw.Write(System.Text.ASCIIEncoding.ASCII.GetBytes("BM")); //BITMAPFILEHEADER.bfType;
            bw.Write((Int32)(55 + imageSize)); //BITMAPFILEHEADER.bfSize;
            bw.Write((Int16)0); //BITMAPFILEHEADER.bfReserved1;
            bw.Write((Int16)0); //BITMAPFILEHEADER.bfReserved2;
            bw.Write(
                (Int32)(
                Marshal.SizeOf(typeof(BITMAPINFOHEADER))
                + Marshal.SizeOf(typeof(BITMAPFILEHEADER))
                + palette.Count * 4)
                ); //BITMAPFILEHEADER.bfOffBits;

            //write bitmap info header
            bw.Write((Int32)Marshal.SizeOf(typeof(BITMAPINFOHEADER)));
            bw.Write((Int32)bmp.Width); //BITMAPINFOHEADER.biWidth
            bw.Write((Int32)bmp.Height); //BITMAPINFOHEADER.biHeight
            bw.Write((Int16)1); //BITMAPINFOHEADER.biPlanes
            bw.Write((Int16)8); //BITMAPINFOHEADER.biBitCount
            bw.Write((UInt32)0); //BITMAPINFOHEADER.biCompression
            bw.Write((Int32)(bmpData.Height * bmpData.Stride) + (palette.Count * 4)); //BITMAPINFOHEADER.biSizeImage
            bw.Write((Int32)0); //BITMAPINFOHEADER.biXPelsPerMeter
            bw.Write((Int32)0); //BITMAPINFOHEADER.biYPelsPerMeter
            bw.Write((UInt32)palette.Count); //BITMAPINFOHEADER.biClrUsed
            bw.Write((UInt32)palette.Count); //BITMAPINFOHEADER.biClrImportant

            //write palette
            foreach (Color color in palette)
            {
                bw.Write((UInt32)color.ToArgb());
            }
            //write pixels
            bw.Write(pixels);

            bmp.UnlockBits(bmpData);
            
            Bitmap newImage = new Bitmap(Image.FromStream(bw.BaseStream));
            newImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            /*
            using (MemoryStream ms = new MemoryStream(bw.BaseStream.ReadByte()))
            {
                Bitmap newImage = new Bitmap(Image.FromStream(ms));
                newImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                //Bitmap bmp = new Bitmap(ms);
                return newImage;
            }
            */
            bw.Close();
            return newImage;

        }

        /// <summary>Get the next value from the key stream</summary>
        /// <param name="keyStream">The key</param>
        /// <returns>Next value from [key]</returns>
        private byte GetKey(Stream keyStream)
        {
            int keyByte = keyStream.ReadByte();
            if (keyByte < 0)
            {
                keyStream.Seek(0, SeekOrigin.Begin);
                keyByte = keyStream.ReadByte();
            }
            if (keyByte == 0) { keyByte = 1; }

            return (byte)keyByte;
        }
    }
}
