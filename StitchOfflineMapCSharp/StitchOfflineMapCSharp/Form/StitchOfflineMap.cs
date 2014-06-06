using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StitchOfflineMapCSharp;

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



    }
}
