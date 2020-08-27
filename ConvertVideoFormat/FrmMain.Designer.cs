namespace ConvertVideoFormat
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolbar1label = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpOutputFormat = new System.Windows.Forms.GroupBox();
            this.rdFLV = new System.Windows.Forms.RadioButton();
            this.rdWMV = new System.Windows.Forms.RadioButton();
            this.rdMPEG = new System.Windows.Forms.RadioButton();
            this.rdMP4 = new System.Windows.Forms.RadioButton();
            this.rdAVI = new System.Windows.Forms.RadioButton();
            this.rdMKV = new System.Windows.Forms.RadioButton();
            this.gpDisplay = new System.Windows.Forms.GroupBox();
            this.rd1080 = new System.Windows.Forms.RadioButton();
            this.rd720P = new System.Windows.Forms.RadioButton();
            this.rd640 = new System.Windows.Forms.RadioButton();
            this.gpOutputInfo = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpStatus = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpOutputFormat.SuspendLayout();
            this.gpDisplay.SuspendLayout();
            this.gpOutputInfo.SuspendLayout();
            this.gpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.选项ToolStripMenuItem.Text = "文件";
            // 
            // 选项ToolStripMenuItem1
            // 
            this.选项ToolStripMenuItem1.Name = "选项ToolStripMenuItem1";
            this.选项ToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.选项ToolStripMenuItem1.Text = "选项...";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbar1label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 851);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1368, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolbar1label
            // 
            this.toolbar1label.Name = "toolbar1label";
            this.toolbar1label.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearData);
            this.groupBox1.Controls.Add(this.btnSelectFiles);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(58, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件列表";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(563, 36);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "清空列表";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(6, 36);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(86, 23);
            this.btnSelectFiles.TabIndex = 1;
            this.btnSelectFiles.Text = "选择文件";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileFormat,
            this.FileSize,
            this.CreateDate});
            this.dataGridView1.Location = new System.Drawing.Point(6, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(645, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.Width = 300;
            // 
            // FileFormat
            // 
            this.FileFormat.DataPropertyName = "FileFormat";
            this.FileFormat.HeaderText = "文件格式";
            this.FileFormat.Name = "FileFormat";
            // 
            // FileSize
            // 
            this.FileSize.DataPropertyName = "FileSize";
            this.FileSize.HeaderText = "文件大小";
            this.FileSize.Name = "FileSize";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "创建日期";
            this.CreateDate.Name = "CreateDate";
            // 
            // gpOutputFormat
            // 
            this.gpOutputFormat.Controls.Add(this.rdFLV);
            this.gpOutputFormat.Controls.Add(this.rdWMV);
            this.gpOutputFormat.Controls.Add(this.rdMPEG);
            this.gpOutputFormat.Controls.Add(this.rdMP4);
            this.gpOutputFormat.Controls.Add(this.rdAVI);
            this.gpOutputFormat.Controls.Add(this.rdMKV);
            this.gpOutputFormat.Location = new System.Drawing.Point(74, 280);
            this.gpOutputFormat.Name = "gpOutputFormat";
            this.gpOutputFormat.Size = new System.Drawing.Size(302, 100);
            this.gpOutputFormat.TabIndex = 3;
            this.gpOutputFormat.TabStop = false;
            this.gpOutputFormat.Text = "输出格式选择";
            // 
            // rdFLV
            // 
            this.rdFLV.AutoSize = true;
            this.rdFLV.Location = new System.Drawing.Point(247, 44);
            this.rdFLV.Name = "rdFLV";
            this.rdFLV.Size = new System.Drawing.Size(41, 16);
            this.rdFLV.TabIndex = 0;
            this.rdFLV.TabStop = true;
            this.rdFLV.Text = "flv";
            this.rdFLV.UseVisualStyleBackColor = true;
            // 
            // rdWMV
            // 
            this.rdWMV.AutoSize = true;
            this.rdWMV.Location = new System.Drawing.Point(200, 44);
            this.rdWMV.Name = "rdWMV";
            this.rdWMV.Size = new System.Drawing.Size(41, 16);
            this.rdWMV.TabIndex = 0;
            this.rdWMV.TabStop = true;
            this.rdWMV.Text = "wmv";
            this.rdWMV.UseVisualStyleBackColor = true;
            // 
            // rdMPEG
            // 
            this.rdMPEG.AutoSize = true;
            this.rdMPEG.Location = new System.Drawing.Point(147, 44);
            this.rdMPEG.Name = "rdMPEG";
            this.rdMPEG.Size = new System.Drawing.Size(47, 16);
            this.rdMPEG.TabIndex = 0;
            this.rdMPEG.TabStop = true;
            this.rdMPEG.Text = "mpeg";
            this.rdMPEG.UseVisualStyleBackColor = true;
            // 
            // rdMP4
            // 
            this.rdMP4.AutoSize = true;
            this.rdMP4.Location = new System.Drawing.Point(100, 44);
            this.rdMP4.Name = "rdMP4";
            this.rdMP4.Size = new System.Drawing.Size(41, 16);
            this.rdMP4.TabIndex = 0;
            this.rdMP4.TabStop = true;
            this.rdMP4.Text = "mp4";
            this.rdMP4.UseVisualStyleBackColor = true;
            // 
            // rdAVI
            // 
            this.rdAVI.AutoSize = true;
            this.rdAVI.Location = new System.Drawing.Point(53, 44);
            this.rdAVI.Name = "rdAVI";
            this.rdAVI.Size = new System.Drawing.Size(41, 16);
            this.rdAVI.TabIndex = 0;
            this.rdAVI.TabStop = true;
            this.rdAVI.Text = "avi";
            this.rdAVI.UseVisualStyleBackColor = true;
            // 
            // rdMKV
            // 
            this.rdMKV.AutoSize = true;
            this.rdMKV.Location = new System.Drawing.Point(6, 44);
            this.rdMKV.Name = "rdMKV";
            this.rdMKV.Size = new System.Drawing.Size(41, 16);
            this.rdMKV.TabIndex = 0;
            this.rdMKV.TabStop = true;
            this.rdMKV.Text = "mkv";
            this.rdMKV.UseVisualStyleBackColor = true;
            // 
            // gpDisplay
            // 
            this.gpDisplay.Controls.Add(this.rd1080);
            this.gpDisplay.Controls.Add(this.rd720P);
            this.gpDisplay.Controls.Add(this.rd640);
            this.gpDisplay.Location = new System.Drawing.Point(67, 428);
            this.gpDisplay.Name = "gpDisplay";
            this.gpDisplay.Size = new System.Drawing.Size(296, 100);
            this.gpDisplay.TabIndex = 4;
            this.gpDisplay.TabStop = false;
            this.gpDisplay.Text = "分辨率";
            // 
            // rd1080
            // 
            this.rd1080.AutoSize = true;
            this.rd1080.Location = new System.Drawing.Point(155, 42);
            this.rd1080.Name = "rd1080";
            this.rd1080.Size = new System.Drawing.Size(77, 16);
            this.rd1080.TabIndex = 0;
            this.rd1080.TabStop = true;
            this.rd1080.Text = "1920x1080";
            this.rd1080.UseVisualStyleBackColor = true;
            // 
            // rd720P
            // 
            this.rd720P.AutoSize = true;
            this.rd720P.Location = new System.Drawing.Point(78, 42);
            this.rd720P.Name = "rd720P";
            this.rd720P.Size = new System.Drawing.Size(71, 16);
            this.rd720P.TabIndex = 0;
            this.rd720P.TabStop = true;
            this.rd720P.Text = "1280x720";
            this.rd720P.UseVisualStyleBackColor = true;
            // 
            // rd640
            // 
            this.rd640.AutoSize = true;
            this.rd640.Location = new System.Drawing.Point(7, 42);
            this.rd640.Name = "rd640";
            this.rd640.Size = new System.Drawing.Size(65, 16);
            this.rd640.TabIndex = 0;
            this.rd640.TabStop = true;
            this.rd640.Text = "640x480";
            this.rd640.UseVisualStyleBackColor = true;
            // 
            // gpOutputInfo
            // 
            this.gpOutputInfo.Controls.Add(this.btnRun);
            this.gpOutputInfo.Controls.Add(this.textBox1);
            this.gpOutputInfo.Controls.Add(this.gpDisplay);
            this.gpOutputInfo.Controls.Add(this.button1);
            this.gpOutputInfo.Controls.Add(this.label1);
            this.gpOutputInfo.Controls.Add(this.gpOutputFormat);
            this.gpOutputInfo.Location = new System.Drawing.Point(871, 50);
            this.gpOutputInfo.Name = "gpOutputInfo";
            this.gpOutputInfo.Size = new System.Drawing.Size(454, 746);
            this.gpOutputInfo.TabIndex = 5;
            this.gpOutputInfo.TabStop = false;
            this.gpOutputInfo.Text = "输出参数设置";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRun.Location = new System.Drawing.Point(68, 568);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(295, 114);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "开始转换";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出路径：";
            // 
            // gpStatus
            // 
            this.gpStatus.Controls.Add(this.richTextBox1);
            this.gpStatus.Location = new System.Drawing.Point(58, 478);
            this.gpStatus.Name = "gpStatus";
            this.gpStatus.Size = new System.Drawing.Size(757, 318);
            this.gpStatus.TabIndex = 6;
            this.gpStatus.TabStop = false;
            this.gpStatus.Text = "状态:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(711, 291);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 873);
            this.Controls.Add(this.gpStatus);
            this.Controls.Add(this.gpOutputInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频格式转换工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpOutputFormat.ResumeLayout(false);
            this.gpOutputFormat.PerformLayout();
            this.gpDisplay.ResumeLayout(false);
            this.gpDisplay.PerformLayout();
            this.gpOutputInfo.ResumeLayout(false);
            this.gpOutputInfo.PerformLayout();
            this.gpStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolbar1label;
        private System.Windows.Forms.GroupBox gpOutputFormat;
        private System.Windows.Forms.RadioButton rdFLV;
        private System.Windows.Forms.RadioButton rdWMV;
        private System.Windows.Forms.RadioButton rdMPEG;
        private System.Windows.Forms.RadioButton rdMP4;
        private System.Windows.Forms.RadioButton rdAVI;
        private System.Windows.Forms.RadioButton rdMKV;
        private System.Windows.Forms.GroupBox gpDisplay;
        private System.Windows.Forms.RadioButton rd640;
        private System.Windows.Forms.RadioButton rd1080;
        private System.Windows.Forms.RadioButton rd720P;
        private System.Windows.Forms.GroupBox gpOutputInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}

