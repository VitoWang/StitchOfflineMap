using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StitchOfflineMapCSharp.Interface;
using System.IO;
using System.Drawing;

namespace StitchOfflineMapCSharp.Implementation
{
    /// <summary>
    /// handle the algorithms(implementation)
    /// </summary>
    public class supportImplementation : supportInterface
    {
        #region private field
        #endregion

        /// <summary>
        /// get names of small maps through it's directory
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public List<string> getMapsNames(string directory)
        {
            string[] fileNames = Directory.GetFiles(directory), myStr = null;
            List<string> fileNamesWithoutExtension = new List<string>();
            char[] splitChars = { '.', '\\' };
            string fileName = string.Empty;
            foreach (var item in fileNames)
            {
                myStr = item.Split(splitChars);
                fileName = myStr[myStr.Length - 2];
                fileNamesWithoutExtension.Add(myStr[myStr.Length - 2]);
            }
            return fileNamesWithoutExtension;
        }

        /// <summary>
        /// get size of array
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public long[] getMinAndMaxCoordinates(string directory)
        {
            long[] extremeValues = new long[4] { 0, 0, 0, 0 };
            List<string> filenames = getMapsNames(directory);
            long min_0 = Convert.ToInt64(filenames[0].Split('_')[0]),
                 max_0 = Convert.ToInt64(filenames[0].Split('_')[0]),
                 min_1 = Convert.ToInt64(filenames[0].Split('_')[1]),
                 max_1 = Convert.ToInt64(filenames[0].Split('_')[1]);
            string[] sequence;

            foreach (var item in filenames)
            {
                sequence = item.Split('\\')[item.Split('\\').Length - 1].Split('_');
                if (Convert.ToInt64(sequence[0]) < min_0)
                    min_0 = Convert.ToInt64(sequence[0]);
                if (Convert.ToInt64(sequence[0]) > max_0)
                    max_0 = Convert.ToInt64(sequence[0]);
                if (Convert.ToInt64(sequence[1]) < min_1)
                    min_1 = Convert.ToInt64(sequence[1]);
                if (Convert.ToInt64(sequence[1]) > max_1)
                    max_1 = Convert.ToInt64(sequence[1]);
            }
            extremeValues[0] = min_0;
            extremeValues[1] = max_0;
            extremeValues[2] = min_1;
            extremeValues[3] = max_1;
            return extremeValues;
        }

        /// <summary>
        /// get coordinates array which corresponde to the real position of maps
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public string[][] getMapsCoordinates(string directory)
        {
            long[] extremValue = getMinAndMaxCoordinates(directory);
            long[] arraySize = new long[2] { extremValue[1] - extremValue[0], extremValue[3] - extremValue[2] };


            return null;
        }

        /// <summary>
        /// stitch the small maps into a big one
        /// output it in a parallized directory
        /// </summary>
        /// <param name="directory"></param>
        public Bitmap StitchMaps(string directory)
        {
            string[] fileNames = Directory.GetFiles(directory);
            long[] extremValue = getMinAndMaxCoordinates(directory);
            Bitmap fullMap = new Bitmap((int)(extremValue[1] - extremValue[0] + 1) * 256, (int)(extremValue[3] - extremValue[2] + 1) * 256);
            Bitmap curBitMap = new Bitmap(Bitmap.FromFile(fileNames[0]));
            Graphics g = Graphics.FromImage(fullMap);
            g.Clear(System.Drawing.Color.Black);
            for (long i = extremValue[0]; i <= extremValue[1]; i++)
                for (long j = extremValue[2]; j <= extremValue[3]; j++)
                {
                    curBitMap = (Bitmap)Image.FromFile(directory + "\\" + i.ToString() + "_" + j.ToString() + ".png");
                    g.DrawImage(curBitMap, (int)(i - extremValue[0]) * 256, (int)(j - extremValue[2]) * 256, 256, 256);
                }
            g.Dispose();
            return fullMap;
        }
    }
}
