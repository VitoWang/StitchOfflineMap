using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StitchOfflineMapCSharp
{
    /// <summary>
    /// to support the forms
    /// </summary>
    public class auxiliary
    {
        /// <summary>
        /// chose a directory which has stored the small images
        /// </summary>
        /// <returns></returns>
        public static string getDirectory()
        {
            string directory = string.Empty;
            FolderBrowserDialog FdBrsDlg = new FolderBrowserDialog();
            FdBrsDlg.Description = "please chose folder";
            FdBrsDlg.ShowNewFolderButton = false;
            //FdBrsDlg.RootFolder = Environment.SpecialFolder.Programs;
            FdBrsDlg.ShowDialog();
            if (FdBrsDlg.SelectedPath == null)
                return null;
            directory = FdBrsDlg.SelectedPath;
            return directory;
        }

    }
}
