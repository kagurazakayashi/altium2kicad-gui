
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBatch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.previewList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileEp = new System.Windows.Forms.TextBox();
            this.batchBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.convLog = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.workAlert = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.fileAp.Location = new System.Drawing.Point(30, 52);
            this.fileAp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileAp.Name = "fileAp";
            this.fileAp.Size = new System.Drawing.Size(500, 26);
            this.fileAp.TabIndex = 0;
            this.fileAp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileAp_DragDrop);
            this.fileAp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileAp_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\n指定 altium2kicad 项目文件夹：";
            // 
            // fileAb
            // 
            this.fileAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileAb.BackColor = System.Drawing.Color.Gray;
            this.fileAb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileAb.Location = new System.Drawing.Point(541, 52);
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
            this.fileBb.Location = new System.Drawing.Point(541, 128);
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
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "\r\n指定 .PcbDoc 电路板文件（PCB Binary File），留空则不转换：";
            // 
            // fileBp
            // 
            this.fileBp.AllowDrop = true;
            this.fileBp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBp.BackColor = System.Drawing.Color.Gray;
            this.fileBp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileBp.ForeColor = System.Drawing.Color.White;
            this.fileBp.Location = new System.Drawing.Point(30, 128);
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
            this.fileCb.Location = new System.Drawing.Point(541, 204);
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
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "\r\n指定 .SchDoc 原理图文件（Advanced Schematic binary），留空则不转换：";
            // 
            // fileCp
            // 
            this.fileCp.AllowDrop = true;
            this.fileCp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileCp.BackColor = System.Drawing.Color.Gray;
            this.fileCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileCp.ForeColor = System.Drawing.Color.White;
            this.fileCp.Location = new System.Drawing.Point(30, 204);
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
            this.fileDb.Location = new System.Drawing.Point(541, 280);
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
            this.label4.Location = new System.Drawing.Point(26, 235);
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
            this.fileDp.Location = new System.Drawing.Point(30, 280);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 470);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.label5);
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
            this.tabPage1.Size = new System.Drawing.Size(723, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "控制面板";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(477, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 49);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空(&C)";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(119, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 82);
            this.label5.TabIndex = 14;
            this.label5.Text = "所有输入框支持文件拖拽。如果是较旧版本的 .PCB 和 .SCH 文件，需要先在 Altium Designer 中转换为 .PcbDoc（PCB Binary " +
    "File）文件和 .SchDoc（Advanced Schematic binary）文件。";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::altium2kicad_gui.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(30, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(556, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 49);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "开始转换(&R)";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.btnBatch);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.previewList);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.fileEp);
            this.tabPage3.Controls.Add(this.batchBtn);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "批量处理";
            // 
            // btnBatch
            // 
            this.btnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatch.BackColor = System.Drawing.Color.Gray;
            this.btnBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatch.Location = new System.Drawing.Point(541, 378);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(149, 41);
            this.btnBatch.TabIndex = 8;
            this.btnBatch.Text = "开始批处理(&B)";
            this.btnBatch.UseVisualStyleBackColor = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(457, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "\r\n在选择文件夹后，请在这里确认要转换的文件，然后按开始批处理按钮。";
            // 
            // previewList
            // 
            this.previewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.previewList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.previewList.FormattingEnabled = true;
            this.previewList.ItemHeight = 20;
            this.previewList.Location = new System.Drawing.Point(32, 122);
            this.previewList.Name = "previewList";
            this.previewList.Size = new System.Drawing.Size(658, 242);
            this.previewList.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "\r\n将从下面的文件夹及其子文件夹中自动搜寻 .PcbDoc 和 .SchDoc 文件。";
            // 
            // fileEp
            // 
            this.fileEp.AllowDrop = true;
            this.fileEp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileEp.BackColor = System.Drawing.Color.Gray;
            this.fileEp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileEp.ForeColor = System.Drawing.Color.White;
            this.fileEp.Location = new System.Drawing.Point(32, 48);
            this.fileEp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileEp.Name = "fileEp";
            this.fileEp.Size = new System.Drawing.Size(500, 26);
            this.fileEp.TabIndex = 3;
            this.fileEp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileEp_DragDrop);
            this.fileEp.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileEp_DragEnter);
            // 
            // batchBtn
            // 
            this.batchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.batchBtn.BackColor = System.Drawing.Color.Gray;
            this.batchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.batchBtn.Location = new System.Drawing.Point(543, 48);
            this.batchBtn.Name = "batchBtn";
            this.batchBtn.Size = new System.Drawing.Size(149, 26);
            this.batchBtn.TabIndex = 5;
            this.batchBtn.Text = "浏览文件夹(&T)...";
            this.batchBtn.UseVisualStyleBackColor = false;
            this.batchBtn.Click += new System.EventHandler(this.batchBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.convLog);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "处理日志";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(723, 16);
            this.progressBar1.TabIndex = 1;
            // 
            // convLog
            // 
            this.convLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.convLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.convLog.FormattingEnabled = true;
            this.convLog.ItemHeight = 20;
            this.convLog.Location = new System.Drawing.Point(0, 17);
            this.convLog.Name = "convLog";
            this.convLog.Size = new System.Drawing.Size(723, 420);
            this.convLog.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // workAlert
            // 
            this.workAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workAlert.ForeColor = System.Drawing.Color.Red;
            this.workAlert.Location = new System.Drawing.Point(634, 4);
            this.workAlert.Name = "workAlert";
            this.workAlert.Size = new System.Drawing.Size(90, 22);
            this.workAlert.TabIndex = 13;
            this.workAlert.Text = "工作中";
            this.workAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workAlert.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(79, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 41);
            this.label8.TabIndex = 16;
            this.label8.Text = "批处理包括所有子文件夹，不建议单次转换特别大量的文件。\r\n将在每个文件所在的文件夹创建 *_KiCad 输出文件夹。";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::altium2kicad_gui.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(32, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 470);
            this.Controls.Add(this.workAlert);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "altium2kicad-gui - Altium Designer 到 KiCad 转换器";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label workAlert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox previewList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileEp;
        private System.Windows.Forms.Button batchBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

