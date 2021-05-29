
namespace altium2kicad_gui
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileAp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileAb = new System.Windows.Forms.Button();
            this.fileBb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileBp = new System.Windows.Forms.TextBox();
            this.fileCb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileCp = new System.Windows.Forms.TextBox();
            this.fileDb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fileDp = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.convLog = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileAp
            // 
            this.fileAp.AllowDrop = true;
            this.fileAp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileAp.BackColor = System.Drawing.Color.Gray;
            this.fileAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileAp.ForeColor = System.Drawing.Color.White;
            this.fileAp.Location = new System.Drawing.Point(30, 49);
            this.fileAp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileAp.Name = "fileAp";
            this.fileAp.Size = new System.Drawing.Size(500, 26);
            this.fileAp.TabIndex = 0;
            this.fileAp.Text = "C:\\adtools\\altium2kicad";
            this.fileAp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileAp_DragDrop);
            this.fileAp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileAp_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "指定 altium2kicad 项目文件夹：";
            // 
            // fileAb
            // 
            this.fileAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileAb.BackColor = System.Drawing.Color.Gray;
            this.fileAb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileAb.Location = new System.Drawing.Point(541, 49);
            this.fileAb.Name = "fileAb";
            this.fileAb.Size = new System.Drawing.Size(149, 26);
            this.fileAb.TabIndex = 2;
            this.fileAb.Text = "浏览文件夹(&A)...";
            this.fileAb.UseVisualStyleBackColor = false;
            this.fileAb.Click += new System.EventHandler(this.fileAb_Click);
            // 
            // fileBb
            // 
            this.fileBb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBb.BackColor = System.Drawing.Color.Gray;
            this.fileBb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileBb.Location = new System.Drawing.Point(541, 125);
            this.fileBb.Name = "fileBb";
            this.fileBb.Size = new System.Drawing.Size(149, 26);
            this.fileBb.TabIndex = 5;
            this.fileBb.Text = "浏览文件(&P)...";
            this.fileBb.UseVisualStyleBackColor = false;
            this.fileBb.Click += new System.EventHandler(this.fileBb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "\r\n指定 .PcbDoc 电路板文件（PCB Binary File）：";
            // 
            // fileBp
            // 
            this.fileBp.AllowDrop = true;
            this.fileBp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBp.BackColor = System.Drawing.Color.Gray;
            this.fileBp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileBp.ForeColor = System.Drawing.Color.White;
            this.fileBp.Location = new System.Drawing.Point(30, 125);
            this.fileBp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileBp.Name = "fileBp";
            this.fileBp.Size = new System.Drawing.Size(500, 26);
            this.fileBp.TabIndex = 3;
            this.fileBp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileBp_DragDrop);
            this.fileBp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileBp_DragEnter);
            // 
            // fileCb
            // 
            this.fileCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileCb.BackColor = System.Drawing.Color.Gray;
            this.fileCb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileCb.Location = new System.Drawing.Point(541, 201);
            this.fileCb.Name = "fileCb";
            this.fileCb.Size = new System.Drawing.Size(149, 26);
            this.fileCb.TabIndex = 8;
            this.fileCb.Text = "浏览文件(&S)...";
            this.fileCb.UseVisualStyleBackColor = false;
            this.fileCb.Click += new System.EventHandler(this.fileCb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "\r\n指定 .SCH 原理图文件：";
            // 
            // fileCp
            // 
            this.fileCp.AllowDrop = true;
            this.fileCp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileCp.BackColor = System.Drawing.Color.Gray;
            this.fileCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileCp.ForeColor = System.Drawing.Color.White;
            this.fileCp.Location = new System.Drawing.Point(30, 201);
            this.fileCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileCp.Name = "fileCp";
            this.fileCp.Size = new System.Drawing.Size(500, 26);
            this.fileCp.TabIndex = 6;
            this.fileCp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileCp_DragDrop);
            this.fileCp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileCp_DragEnter);
            // 
            // fileDb
            // 
            this.fileDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDb.BackColor = System.Drawing.Color.Gray;
            this.fileDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileDb.Location = new System.Drawing.Point(541, 277);
            this.fileDb.Name = "fileDb";
            this.fileDb.Size = new System.Drawing.Size(149, 26);
            this.fileDb.TabIndex = 11;
            this.fileDb.Text = "浏览文件夹(&K)...";
            this.fileDb.UseVisualStyleBackColor = false;
            this.fileDb.Click += new System.EventHandler(this.fileDb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "\r\n指定 KiCad 项目输出文件夹：";
            // 
            // fileDp
            // 
            this.fileDp.AllowDrop = true;
            this.fileDp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDp.BackColor = System.Drawing.Color.Gray;
            this.fileDp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileDp.ForeColor = System.Drawing.Color.White;
            this.fileDp.Location = new System.Drawing.Point(30, 277);
            this.fileDp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileDp.Name = "fileDp";
            this.fileDp.Size = new System.Drawing.Size(500, 26);
            this.fileDp.TabIndex = 9;
            this.fileDp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileDp_DragDrop);
            this.fileDp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileDp_DragEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 462);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.fileDb);
            this.tabPage1.Controls.Add(this.fileAp);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fileAb);
            this.tabPage1.Controls.Add(this.fileDp);
            this.tabPage1.Controls.Add(this.fileBp);
            this.tabPage1.Controls.Add(this.fileCb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.fileBb);
            this.tabPage1.Controls.Add(this.fileCp);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "控制面板";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.convLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "处理日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(541, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 49);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "开始转换(&S)";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // convLog
            // 
            this.convLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.convLog.FormattingEnabled = true;
            this.convLog.ItemHeight = 20;
            this.convLog.Location = new System.Drawing.Point(3, 3);
            this.convLog.Name = "convLog";
            this.convLog.Size = new System.Drawing.Size(717, 423);
            this.convLog.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::altium2kicad_gui.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(30, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 462);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Altium Designer 到 KiCad 转换器";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fileAp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileAb;
        private System.Windows.Forms.Button fileBb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileBp;
        private System.Windows.Forms.Button fileCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileCp;
        private System.Windows.Forms.Button fileDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileDp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox convLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

