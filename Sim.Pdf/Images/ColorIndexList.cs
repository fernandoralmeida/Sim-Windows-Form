using System;
using System.Collections;

namespace Sim.Pdf.Images
{
    public class ColorIndexList : ArrayList
    {
        /// <summary>counts the alternative indices that have already been returned by GetIndex()</summary>
        private int maxIndexAlreadyUsed = 0;
        /// <summary>Used by GetIndex() to pick a random index</summary>
        private Random random;

        public ColorIndexList(Random random)
        {
            this.random = random;
        }

        /// <summary>Returns a color index that can be used to hide [messageBit]</summary>
        /// <param name="messageBit">One bit of the secret message</param>
        /// <returns>The first color index if [messageBit] is false, one of the alternative color indices if [messageBit] is true</returns>
        public byte GetIndex(bool messageBit)
        {
            if (messageBit)
            {
                //return the index of an odd color, this hides a "1"
                if (maxIndexAlreadyUsed < this.Count - 1)
                {
                    //one or more color indices have not been used yet
                    maxIndexAlreadyUsed++;
                    return (byte)this[maxIndexAlreadyUsed];
                }
                else
                {
                    //there are no unused indices - return a random index
                    return (byte)this[random.Next(1, this.Count - 1)];
                }
            }
            else
            {
                //return the index of the even color, this hides a "0"
                return (byte)this[0];
            }
        }

        /// <summary>Returns a random color index</summary>
        /// <returns>The next unused color index, or a random color index</returns>
        public byte GetIndex()
        {
            if (maxIndexAlreadyUsed < this.Count - 1)
            {
                //one or more color indices have not been used yet
                maxIndexAlreadyUsed++;
                return (byte)this[maxIndexAlreadyUsed];
            }
            else
            {
                //there are no unused indices - return a random index (original color preferred)
                int index = random.Next(0, this.Count) - 1;
                return (index < 0) ? (byte)this[0] : (byte)this[index];
            }
        }

    }
}
