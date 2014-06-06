using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StitchOfflineMapCSharp.Interface;
using System.IO;

namespace StitchOfflineMapCSharp.Implementation
{
    /// <summary>
    /// handle the algorithms(implementation)
    /// </summary>
    public class supportImplementation : supportInterface
    {
        /// <summary>
        /// get names of small maps through it's directory
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public string[] getMapsNames(string directory)
        {
            string[] fileNames = Directory.GetFiles(directory);
            return fileNames;
        }

        /// <summary>
        /// get size of array
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public long[] getMinAndMaxCoordinates(string directory)
        {
            long[] extremeValues = new long[2] { 0, 0 };
            string[] filenames = Directory.GetFiles(directory), filenamescut = Directory.GetFiles(directory);
            for (int i = 0; i < filenames.Length; i++)
            {
                //filenamescut[i] = filenamescut[i].
            }

            long min = Convert.ToInt64(filenames[0].Split('_')[0]), max = Convert.ToInt64(filenames[0].Split('_')[1]);
            foreach (var item in filenames)
            {
                if (Convert.ToInt64(item.Split('_')[0]) < min)
                    min = Convert.ToInt64(item.Split('_')[0]);
                if (Convert.ToInt64(item.Split('_')[1]) > max)
                    max = Convert.ToInt64(item.Split('_')[1]);
            }
            extremeValues[0] = min;
            extremeValues[1] = max;
            return extremeValues;
        }

        /// <summary>
        /// get coordinates array which corresponde to the real position of maps
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public string[][] getMapsCoordinates(string directory)
        {
            return null;
        }

        /// <summary>
        /// stitch the small maps into a big one
        /// output it in a parallized directory
        /// </summary>
        /// <param name="directory"></param>
        public void StitchMaps(string directory)
        {
            return;
        }
    }
}
