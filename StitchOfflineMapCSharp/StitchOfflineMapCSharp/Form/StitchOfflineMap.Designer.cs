namespace StitchOfflineMapCSharp
{
    partial class StitchOfflineMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StitchOfflineMap));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setThreadNumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChoseDirectory_Lable = new System.Windows.Forms.Label();
            this.ShowDirectory_Textbox = new System.Windows.Forms.TextBox();
            this.ChoseDirectory_Button = new System.Windows.Forms.Button();
            this.StartStitch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setThreadNumToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // setThreadNumToolStripMenuItem
            // 
            this.setThreadNumToolStripMenuItem.Name = "setThreadNumToolStripMenuItem";
            this.setThreadNumToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.setThreadNumToolStripMenuItem.Text = "Set Thread Num.";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 481);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seamless Splicing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StartStitch);
            this.panel2.Controls.Add(this.ChoseDirectory_Button);
            this.panel2.Controls.Add(this.ShowDirectory_Textbox);
            this.panel2.Controls.Add(this.ChoseDirectory_Lable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 135);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 308);
            this.panel3.TabIndex = 1;
            // 
            // ChoseDirectory_Lable
            // 
            this.ChoseDirectory_Lable.AutoSize = true;
            this.ChoseDirectory_Lable.Location = new System.Drawing.Point(66, 29);
            this.ChoseDirectory_Lable.Name = "ChoseDirectory_Lable";
            this.ChoseDirectory_Lable.Size = new System.Drawing.Size(53, 12);
            this.ChoseDirectory_Lable.TabIndex = 0;
            this.ChoseDirectory_Lable.Text = "选择路径";
            // 
            // ShowDirectory_Textbox
            // 
            this.ShowDirectory_Textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.ShowDirectory_Textbox.Location = new System.Drawing.Point(125, 26);
            this.ShowDirectory_Textbox.Name = "ShowDirectory_Textbox";
            this.ShowDirectory_Textbox.ReadOnly = true;
            this.ShowDirectory_Textbox.Size = new System.Drawing.Size(536, 21);
            this.ShowDirectory_Textbox.TabIndex = 1;
            // 
            // ChoseDirectory_Button
            // 
            this.ChoseDirectory_Button.Location = new System.Drawing.Point(688, 24);
            this.ChoseDirectory_Button.Name = "ChoseDirectory_Button";
            this.ChoseDirectory_Button.Size = new System.Drawing.Size(75, 23);
            this.ChoseDirectory_Button.TabIndex = 2;
            this.ChoseDirectory_Button.Text = "打开";
            this.ChoseDirectory_Button.UseVisualStyleBackColor = true;
            this.ChoseDirectory_Button.Click += new System.EventHandler(this.ChoseDirectory_Button_Click_1);
            // 
            // StartStitch
            // 
            this.StartStitch.Location = new System.Drawing.Point(365, 82);
            this.StartStitch.Name = "StartStitch";
            this.StartStitch.Size = new System.Drawing.Size(75, 23);
            this.StartStitch.TabIndex = 3;
            this.StartStitch.Text = "开始合并";
            this.StartStitch.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 308);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(412, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 308);
            this.panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "拼接结果";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "6570_1265.png");
            this.imageList1.Images.SetKeyName(1, "6570_1266.png");
            this.imageList1.Images.SetKeyName(2, "6570_1267.png");
            this.imageList1.Images.SetKeyName(3, "6570_1268.png");
            this.imageList1.Images.SetKeyName(4, "6570_1269.png");
            this.imageList1.Images.SetKeyName(5, "6570_1270.png");
            this.imageList1.Images.SetKeyName(6, "6571_1265.png");
            this.imageList1.Images.SetKeyName(7, "6571_1266.png");
            this.imageList1.Images.SetKeyName(8, "6571_1267.png");
            this.imageList1.Images.SetKeyName(9, "6571_1268.png");
            this.imageList1.Images.SetKeyName(10, "6571_1269.png");
            this.imageList1.Images.SetKeyName(11, "6571_1270.png");
            this.imageList1.Images.SetKeyName(12, "6572_1265.png");
            this.imageList1.Images.SetKeyName(13, "6572_1266.png");
            this.imageList1.Images.SetKeyName(14, "6572_1267.png");
            this.imageList1.Images.SetKeyName(15, "6572_1268.png");
            this.imageList1.Images.SetKeyName(16, "6572_1269.png");
            this.imageList1.Images.SetKeyName(17, "6572_1270.png");
            this.imageList1.Images.SetKeyName(18, "6573_1265.png");
            this.imageList1.Images.SetKeyName(19, "6573_1266.png");
            this.imageList1.Images.SetKeyName(20, "6573_1267.png");
            this.imageList1.Images.SetKeyName(21, "6573_1268.png");
            this.imageList1.Images.SetKeyName(22, "6573_1269.png");
            this.imageList1.Images.SetKeyName(23, "6573_1270.png");
            this.imageList1.Images.SetKeyName(24, "6574_1265.png");
            this.imageList1.Images.SetKeyName(25, "6574_1266.png");
            this.imageList1.Images.SetKeyName(26, "6574_1267.png");
            this.imageList1.Images.SetKeyName(27, "6574_1268.png");
            this.imageList1.Images.SetKeyName(28, "6574_1269.png");
            this.imageList1.Images.SetKeyName(29, "6574_1270.png");
            this.imageList1.Images.SetKeyName(30, "6575_1265.png");
            this.imageList1.Images.SetKeyName(31, "6575_1266.png");
            this.imageList1.Images.SetKeyName(32, "6575_1267.png");
            this.imageList1.Images.SetKeyName(33, "6575_1268.png");
            this.imageList1.Images.SetKeyName(34, "6575_1269.png");
            this.imageList1.Images.SetKeyName(35, "6575_1270.png");
            this.imageList1.Images.SetKeyName(36, "6576_1265.png");
            this.imageList1.Images.SetKeyName(37, "6576_1266.png");
            this.imageList1.Images.SetKeyName(38, "6576_1267.png");
            this.imageList1.Images.SetKeyName(39, "6576_1268.png");
            this.imageList1.Images.SetKeyName(40, "6576_1269.png");
            this.imageList1.Images.SetKeyName(41, "6576_1270.png");
            this.imageList1.Images.SetKeyName(42, "6577_1265.png");
            this.imageList1.Images.SetKeyName(43, "6577_1266.png");
            this.imageList1.Images.SetKeyName(44, "6577_1267.png");
            this.imageList1.Images.SetKeyName(45, "6577_1268.png");
            this.imageList1.Images.SetKeyName(46, "6577_1269.png");
            this.imageList1.Images.SetKeyName(47, "6577_1270.png");
            this.imageList1.Images.SetKeyName(48, "6578_1265.png");
            this.imageList1.Images.SetKeyName(49, "6578_1266.png");
            this.imageList1.Images.SetKeyName(50, "6578_1267.png");
            this.imageList1.Images.SetKeyName(51, "6578_1268.png");
            this.imageList1.Images.SetKeyName(52, "6578_1269.png");
            this.imageList1.Images.SetKeyName(53, "6578_1270.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StitchOfflineMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StitchOfflineMap";
            this.Text = "StitchOfflineMap";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setThreadNumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ChoseDirectory_Button;
        private System.Windows.Forms.TextBox ShowDirectory_Textbox;
        private System.Windows.Forms.Label ChoseDirectory_Lable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button StartStitch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}