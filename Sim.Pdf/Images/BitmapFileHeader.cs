using System;
using System.Runtime.InteropServices;

namespace Sim.Pdf.Images
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BITMAPFILEHEADER
    {
        public Int16 bfType;
        public Int32 bfSize;
        public Int16 bfReserved1;
        public Int16 bfReserved2;
        public Int32 bfOffBits;
    }
}
