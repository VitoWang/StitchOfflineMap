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
using System.IO;

namespace StitchOfflineMapCSharp
{
    public partial class StitchOfflineMap : Form
    {
        #region private field

        /// <summary>
        /// 图像对象
        /// </summary>
        private Bitmap curBitmap;

        /// <summary>
        /// bottom map for merging
        /// </summary>
        private Bitmap mergeBottom;

        /// <summary>
        /// map for save merged maps
        /// </summary>
        private Bitmap mergeImage;
        #endregion

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
            if (directory == "")
                return;
            curBitmap = sptI.StitchMaps(directory);
            Result_groupBox.Invalidate();
        }

        private void Result_groupBox_Paint(object sender, PaintEventArgs e)
        {
            if (curBitmap == null)
                return;
            Graphics g = e.Graphics;
            g.DrawImage(curBitmap, 0, 0, curBitmap.Width, curBitmap.Height);
        }

        private void StitchOfflineMap_Load(object sender, EventArgs e)
        {
            mergeresources_listBox.Items.Add("program will merge  images by the sequence here");
        }

        private void save_stitch_Click(object sender, EventArgs e)
        {
            this.SaveFiles(curBitmap);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void addMergeResources_button_Click(object sender, EventArgs e)
        {
            if (mergeresources_listBox.Items.Count == 1 && mergeresources_listBox.Items.Contains("program will merge  images by the sequence here"))
            {
                mergeresources_listBox.Items.Clear();
            }
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Title = "please choose image";
            opnDlg.Filter = "图片文件 | *.bmp; *.tif; *.jpg; *.png";
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                mergeresources_listBox.Items.Add(opnDlg.FileName/*.Split('\\','.')[opnDlg.FileName.Split('\\','.').Length - 2]*/);  //show full file name or just file name
            }
        }

        private void startMerge_Click(object sender, EventArgs e)
        {
            if (mergeresources_listBox.Items.Count != 2)
            {
                MessageBox.Show("just support the merging of 2 images");
                return;
            }
            Bitmap bottomMap = (Bitmap)Bitmap.FromFile(mergeresources_listBox.Items[0].ToString());
            Bitmap upMap = (Bitmap)Bitmap.FromFile(mergeresources_listBox.Items[1].ToString());
            Color clr = new Color();
            //image merging
            mergeBottom = new Bitmap(bottomMap);
            for( int i = 0; i < upMap.Width; i++)
                for (int j = 0; j < upMap.Height; j++)
                {
                    clr = upMap.GetPixel(i, j);
                    if(clr.ToArgb() != Color.Black.ToArgb())
                    {
                        mergeBottom.SetPixel(i, j, clr);
                    }
                }
            mergeImage = mergeBottom;
        }

        private void mergeSave_button_Click(object sender, EventArgs e)
        {
            this.SaveFiles(mergeImage);
        }

        private Color getARGBBlack(int r, int g, int b)
        {
            Color clr = new Color();
            return clr;
        }

        private bool SaveFiles(Bitmap file)
        {
            if (file == null)
                return false;
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "保存为";
            saveDlg.OverwritePrompt = true;
            saveDlg.Filter = "BMP文件(*.bmp) | *.bmp|" + "Gif文件文件(*.gif) | *.gif|" +
                "JPEG文件(*.jpg) | *.jpg|" + "PNG文件(*.png) | *.png |" + "Tiff文件(.tif) | *.tif";
            saveDlg.ShowHelp = true;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDlg.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        file.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        file.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        file.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        file.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        file.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }
    }
}
