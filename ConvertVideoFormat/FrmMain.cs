using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertVideoFormat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOFD = new OpenFileDialog();
            objOFD.Filter = "视频文件 | *.avi;*.mkv;*.wmv;*.mp4;*.flv";
            objOFD.InitialDirectory = "./";
            objOFD.Multiselect = true;
            objOFD.Title = "请选择需要转换的视频文件";
            DialogResult dialogResult = objOFD.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                List<string> Files = objOFD.FileNames.ToList();
                this.dataGridView1.DataSource = new FileService().GetFiles(Files);
                this.richTextBox1.Text = DateTime.Now.ToString() + ": " + "文件加载完成\n";
            }
            
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.richTextBox1.Text = this.richTextBox1.Text += DateTime.Now.ToString() + ": " + "选择文件已清空";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objFBD = new FolderBrowserDialog();
            objFBD.ShowNewFolderButton = true;
            objFBD.Description = "请选择保存路径";
            DialogResult dialogResult = objFBD.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.textBox1.Text = objFBD.SelectedPath;
                this.richTextBox1.Text = this.richTextBox1.Text += DateTime.Now.ToString() + ": " + "输出路径已配置\n";
            }
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                string fileName = item.Cells[0].Value.ToString();
                Console.WriteLine(fileName);
                this.richTextBox1.Text = this.richTextBox1.Text += DateTime.Now.ToString() + ": " + "正在转换:" + fileName+"\n";
                string extension = GetExtFormat();
                if (extension.Length > 4)
                {
                    MessageBox.Show("请先选中需要转换的格式!","错误提示");
                    return;
                }
                string outputName = fileName.Substring(0, fileName.LastIndexOf("."))+"_new."+extension;
                new FFMpegHelper().Convert(fileName, outputName);
                this.richTextBox1.Text = this.richTextBox1.Text += DateTime.Now.ToString() + ": " + "转换完成:" + outputName + "\n";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.btnRun.Text = "正在转换";
                this.btnRun.Enabled = false;
                this.backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("请先选择需要转换的文件");
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnRun.Text = "开始转换";
            this.btnRun.Enabled = true;
        }

        private string GetExtFormat()
        {
            foreach (Control control in this.gpOutputFormat.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Checked)
                {
                    return rd.Text;
                }
            }
            return "请先选中格式！";
        }
    }
}
