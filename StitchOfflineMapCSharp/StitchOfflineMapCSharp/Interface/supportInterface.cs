using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StitchOfflineMapCSharp.Interface
{
    /// <summary>
    /// handle the algorithms(interface)
    /// </summary>
    public interface supportInterface
    {
        /// <summary>
        /// get names of small maps through it's directory
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        string[] getMapsNames(string directory);

        /// <summary>
        /// get size of array
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        long[] getMinAndMaxCoordinates(string directory);

        /// <summary>
        /// get coordinates array which corresponde to the real position of maps
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        string[][] getMapsCoordinates(string directory);

        /// <summary>
        /// stitch the small maps into a big one
        /// output it in a parallized directory
        /// </summary>
        /// <param name="directory"></param>
        void StitchMaps(string directory);
    }
}
