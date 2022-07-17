﻿using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Sim.Pdf
{
    class Render
    {
        
        public static Bitmap Page(IntPtr context, IntPtr document, IntPtr page, Rectangle pageBound)
        {
            Matrix ctm = new Matrix();
            IntPtr pix = IntPtr.Zero;
            IntPtr dev = IntPtr.Zero;

            int width = (int)((pageBound.Right - pageBound.Left) * 1.5F); // gets the size of the page
            int height = (int)((pageBound.Bottom - pageBound.Top) * 1.5F);
            ctm.A = ctm.D = 1.5F; // sets the matrix as the identity matrix (1,0,0,1,0,0)

            // creates a pixmap the same size as the width and height of the page
            pix = NativeMethods.NewPixmap(context, NativeMethods.LookupDeviceColorSpace(context, "DeviceRGB"), width, height);
            // sets white color as the background color of the pixmap
            NativeMethods.ClearPixmap(context, pix, 0xFF);

            // creates a drawing device
            dev = NativeMethods.NewDrawDevice(context, pix);
            // draws the page on the device created from the pixmap
            NativeMethods.RunPage(document, page, dev, ref ctm, IntPtr.Zero);

            NativeMethods.FreeDevice(dev); // frees the resources consumed by the device
            dev = IntPtr.Zero;

            // creates a colorful bitmap of the same size of the pixmap
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            var imageData = bmp.LockBits(new System.Drawing.Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            { // converts the pixmap data to Bitmap data
                byte* ptrSrc = (byte*)NativeMethods.GetSamples(context, pix); // gets the rendered data from the pixmap
                byte* ptrDest = (byte*)imageData.Scan0;
                for (int y = 0; y < height; y++)
                {
                    byte* pl = ptrDest;
                    byte* sl = ptrSrc;
                    for (int x = 0; x < width; x++)
                    {
                        //Swap these here instead of in MuPDF because most pdf images will be rgb or cmyk.
                        //Since we are going through the pixels one by one anyway swap here to save a conversion from rgb to bgr.
                        pl[2] = sl[0]; //b-r
                        pl[1] = sl[1]; //g-g
                        pl[0] = sl[2]; //r-b
                                       //sl[3] is the alpha channel, we will skip it here
                        pl += 3;
                        sl += 4;
                    }
                    ptrDest += imageData.Stride;
                    ptrSrc += width * 4;
                }
            }
            NativeMethods.DropPixmap(context, pix);
            return bmp;
        }
    }
}
