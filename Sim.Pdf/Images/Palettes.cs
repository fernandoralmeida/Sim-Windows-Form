using System;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Sim.Pdf.Images
{
    public class Palettes
    {
        /// <summary>Creates a larger palette by duplicating and changing the colors of another palette</summary>
		/// <param name="oldPalette">The palette to stretch</param>
		/// <param name="maxPaletteSize">Count of colors in the new palette</param>
		/// <param name="newPalette">Receives the new palette entries</param>
		/// <param name="colorIndexToNewIndices">
		/// Receives a Hashtable with the original indices as the keys,
		/// and the corresponding new indices as the values
		/// </param>
        internal void StretchPalette(ColorPalette oldPalette, int maxPaletteSize, ref ArrayList newPalette, ref Hashtable colorIndexToNewIndices)
        {
            newPalette = new ArrayList(maxPaletteSize);
            colorIndexToNewIndices = new Hashtable(oldPalette.Entries.Length);

            Random random = new Random();
            byte indexInNewPalette;
            Color color, newColor;
            ColorIndexList colorIndexList;

            while (newPalette.Count < maxPaletteSize)
            { //repeat the palette if necessary
                for (byte n = 0; n < oldPalette.Entries.Length; n++)
                { //loop over old palette entries
                    color = oldPalette.Entries[n]; //original color

                    if (colorIndexToNewIndices.ContainsKey(n))
                    {
                        //this color from the original palette already has one or more copies in the new palette
                        colorIndexList = (ColorIndexList)colorIndexToNewIndices[n];
                    }
                    else
                    {
                        if (color.B % 2 > 0)
                        { //make even
                            color = Color.FromArgb(color.R, color.G, color.B - 1);
                        }
                        indexInNewPalette = (byte)newPalette.Add(color); //add color
                        colorIndexList = new ColorIndexList(random);
                        colorIndexList.Add(indexInNewPalette);
                        colorIndexToNewIndices.Add(n, colorIndexList);
                    }

                    if (newPalette.Count < maxPaletteSize)
                    {
                        //create a non-exact copy of the color
                        newColor = GetSimilarColor(random, newPalette, color);

                        if (newColor.B % 2 == 0)
                        { //make odd
                            newColor = Color.FromArgb(newColor.R, newColor.G, newColor.B + 1);
                        }

                        //add the changed color to the new palette
                        indexInNewPalette = (byte)newPalette.Add(newColor);
                        //add the new index to the list of alternative indices
                        colorIndexList.Add(indexInNewPalette);
                    }

                    //update the Hashtable
                    colorIndexToNewIndices[n] = colorIndexList;

                    if (newPalette.Count == maxPaletteSize)
                    {
                        break; //the new palette is full - cancel
                    }
                }
            }
        }
        /// <summary>Calculates a color that looks nearly the same</summary>
        /// <param name="random"></param>
        /// <param name="excludeColors">List of colors that may not be returned again</param>
        /// <param name="color">Original color</param>
        /// <returns>A new color that differs a little from [color]</returns>
        private Color GetSimilarColor(Random random, ArrayList excludeColors, Color color)
        {
            Color newColor = color;
            int countLoops = 0, red, green, blue;
            do
            {
                red = GetSimilarColorComponent(random, newColor.R);
                green = GetSimilarColorComponent(random, newColor.G);
                blue = GetSimilarColorComponent(random, newColor.B);
                newColor = Color.FromArgb(red, green, blue);
                countLoops++;
            } while (excludeColors.Contains(newColor) && (countLoops < 10)); //make sure that there are no duplicate colors

            return newColor;
        }
        /// <summary>Calculates a color component that looks nearly the same</summary>
        /// <param name="random"></param>
        /// <param name="colorValue">Original color component</param>
        /// <returns>[colorValue]*1.0x if [colorValue] is less than 128, or [colorValue]/1.0x for higher values</returns>
        private byte GetSimilarColorComponent(Random random, byte colorValue)
        {
            if (colorValue < 128)
            {
                colorValue = (byte)(colorValue * (1 + random.Next(1, 8) / (float)100));
            }
            else
            {
                colorValue = (byte)(colorValue / (1 + random.Next(1, 8) / (float)100));
            }
            return colorValue;
        }
    }
}
