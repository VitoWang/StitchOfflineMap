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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setThreadNumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Result_groupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Resources_groupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_stitch = new System.Windows.Forms.Button();
            this.StartStitch = new System.Windows.Forms.Button();
            this.ChoseDirectory_Button = new System.Windows.Forms.Button();
            this.ShowDirectory_Textbox = new System.Windows.Forms.TextBox();
            this.ChoseDirectory_Lable = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.startMerge = new System.Windows.Forms.Button();
            this.addMergeResources_button = new System.Windows.Forms.Button();
            this.mergeresources_listBox = new System.Windows.Forms.ListBox();
            this.mergeSave_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(854, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.panel1.Size = new System.Drawing.Size(854, 449);
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
            this.tabControl1.Size = new System.Drawing.Size(854, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seamless Splicing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 308);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Result_groupBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(411, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 308);
            this.panel5.TabIndex = 1;
            // 
            // Result_groupBox
            // 
            this.Result_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_groupBox.Location = new System.Drawing.Point(0, 0);
            this.Result_groupBox.Name = "Result_groupBox";
            this.Result_groupBox.Size = new System.Drawing.Size(429, 308);
            this.Result_groupBox.TabIndex = 0;
            this.Result_groupBox.TabStop = false;
            this.Result_groupBox.Text = "Result";
            this.Result_groupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Result_groupBox_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Resources_groupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 308);
            this.panel4.TabIndex = 0;
            // 
            // Resources_groupBox
            // 
            this.Resources_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resources_groupBox.Location = new System.Drawing.Point(0, 0);
            this.Resources_groupBox.Name = "Resources_groupBox";
            this.Resources_groupBox.Size = new System.Drawing.Size(406, 308);
            this.Resources_groupBox.TabIndex = 0;
            this.Resources_groupBox.TabStop = false;
            this.Resources_groupBox.Text = "Resources";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.save_stitch);
            this.panel2.Controls.Add(this.StartStitch);
            this.panel2.Controls.Add(this.ChoseDirectory_Button);
            this.panel2.Controls.Add(this.ShowDirectory_Textbox);
            this.panel2.Controls.Add(this.ChoseDirectory_Lable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 135);
            this.panel2.TabIndex = 0;
            // 
            // save_stitch
            // 
            this.save_stitch.Location = new System.Drawing.Point(446, 77);
            this.save_stitch.Name = "save_stitch";
            this.save_stitch.Size = new System.Drawing.Size(75, 23);
            this.save_stitch.TabIndex = 4;
            this.save_stitch.Text = "Save Result";
            this.save_stitch.UseVisualStyleBackColor = true;
            this.save_stitch.Click += new System.EventHandler(this.save_stitch_Click);
            // 
            // StartStitch
            // 
            this.StartStitch.Location = new System.Drawing.Point(310, 77);
            this.StartStitch.Name = "StartStitch";
            this.StartStitch.Size = new System.Drawing.Size(75, 23);
            this.StartStitch.TabIndex = 3;
            this.StartStitch.Text = "START";
            this.StartStitch.UseVisualStyleBackColor = true;
            this.StartStitch.Click += new System.EventHandler(this.StartStitch_Click);
            // 
            // ChoseDirectory_Button
            // 
            this.ChoseDirectory_Button.Location = new System.Drawing.Point(688, 24);
            this.ChoseDirectory_Button.Name = "ChoseDirectory_Button";
            this.ChoseDirectory_Button.Size = new System.Drawing.Size(75, 23);
            this.ChoseDirectory_Button.TabIndex = 2;
            this.ChoseDirectory_Button.Text = "OPEN";
            this.ChoseDirectory_Button.UseVisualStyleBackColor = true;
            this.ChoseDirectory_Button.Click += new System.EventHandler(this.ChoseDirectory_Button_Click_1);
            // 
            // ShowDirectory_Textbox
            // 
            this.ShowDirectory_Textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.ShowDirectory_Textbox.Location = new System.Drawing.Point(131, 26);
            this.ShowDirectory_Textbox.Name = "ShowDirectory_Textbox";
            this.ShowDirectory_Textbox.ReadOnly = true;
            this.ShowDirectory_Textbox.Size = new System.Drawing.Size(536, 21);
            this.ShowDirectory_Textbox.TabIndex = 1;
            // 
            // ChoseDirectory_Lable
            // 
            this.ChoseDirectory_Lable.AutoSize = true;
            this.ChoseDirectory_Lable.Location = new System.Drawing.Point(66, 29);
            this.ChoseDirectory_Lable.Name = "ChoseDirectory_Lable";
            this.ChoseDirectory_Lable.Size = new System.Drawing.Size(59, 12);
            this.ChoseDirectory_Lable.TabIndex = 0;
            this.ChoseDirectory_Lable.Text = "DIRECTORY";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mergeSave_button);
            this.tabPage2.Controls.Add(this.startMerge);
            this.tabPage2.Controls.Add(this.addMergeResources_button);
            this.tabPage2.Controls.Add(this.mergeresources_listBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // startMerge
            // 
            this.startMerge.Location = new System.Drawing.Point(269, 189);
            this.startMerge.Name = "startMerge";
            this.startMerge.Size = new System.Drawing.Size(75, 23);
            this.startMerge.TabIndex = 2;
            this.startMerge.Text = "start";
            this.startMerge.UseVisualStyleBackColor = true;
            this.startMerge.Click += new System.EventHandler(this.startMerge_Click);
            // 
            // addMergeResources_button
            // 
            this.addMergeResources_button.Location = new System.Drawing.Point(46, 125);
            this.addMergeResources_button.Name = "addMergeResources_button";
            this.addMergeResources_button.Size = new System.Drawing.Size(75, 23);
            this.addMergeResources_button.TabIndex = 1;
            this.addMergeResources_button.Text = "Add";
            this.addMergeResources_button.UseVisualStyleBackColor = true;
            this.addMergeResources_button.Click += new System.EventHandler(this.addMergeResources_button_Click);
            // 
            // mergeresources_listBox
            // 
            this.mergeresources_listBox.FormattingEnabled = true;
            this.mergeresources_listBox.ItemHeight = 12;
            this.mergeresources_listBox.Location = new System.Drawing.Point(3, 3);
            this.mergeresources_listBox.Name = "mergeresources_listBox";
            this.mergeresources_listBox.Size = new System.Drawing.Size(430, 88);
            this.mergeresources_listBox.TabIndex = 0;
            // 
            // mergeSave_button
            // 
            this.mergeSave_button.Location = new System.Drawing.Point(357, 189);
            this.mergeSave_button.Name = "mergeSave_button";
            this.mergeSave_button.Size = new System.Drawing.Size(75, 23);
            this.mergeSave_button.TabIndex = 3;
            this.mergeSave_button.Text = "save";
            this.mergeSave_button.UseVisualStyleBackColor = true;
            this.mergeSave_button.Click += new System.EventHandler(this.mergeSave_button_Click);
            // 
            // StitchOfflineMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StitchOfflineMap";
            this.Text = "StitchOfflineMap";
            this.Load += new System.EventHandler(this.StitchOfflineMap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox Resources_groupBox;
        private System.Windows.Forms.GroupBox Result_groupBox;
        private System.Windows.Forms.Button save_stitch;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addMergeResources_button;
        private System.Windows.Forms.ListBox mergeresources_listBox;
        private System.Windows.Forms.Button startMerge;
        private System.Windows.Forms.Button mergeSave_button;
    }
}