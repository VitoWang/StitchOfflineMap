using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StitchOfflineMapCSharp;
using StitchOfflineMapCSharp.Interface;
using StitchOfflineMapCSharp.Implementation;

namespace StitchOfflineMapCSharp
{
    public partial class StitchOfflineMap : Form
    {
        public StitchOfflineMap()
        {
            InitializeComponent();
        }

        private void ChoseDirectory_Button_Click_1(object sender, EventArgs e)
        {
            ShowDirectory_Textbox.Text = auxiliary.getDirectory();
        }

        private void StartStitch_Click(object sender, EventArgs e)
        {
            string directory = ShowDirectory_Textbox.Text;
            supportInterface sptI = new supportImplementation();
            string[] filenames = sptI.getMapsNames(directory);
            //long[] extreme = sptI.getMinAndMaxCoordinates(directory);


        }



    }
}
