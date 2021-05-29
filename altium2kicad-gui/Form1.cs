using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace altium2kicad_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileAb_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = fileAp.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileAp.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void fileBb_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PCB Binary Files (*.PcbDoc)|*.PcbDoc|All Files|*.*";
            openFileDialog1.FileName = fileBp.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileBp.Text = openFileDialog1.FileName;
            }
            if (fileCp.Text.Length == 0)
            {
                string[] fileNameArr = getFileName(openFileDialog1.FileName);
                fileCp.Text = fileNameArr[0] + fileNameArr[1] + ".SCH";
            }
            if (fileDp.Text.Length == 0)
            {
                string[] fileNameArr = getFileName(openFileDialog1.FileName);
                fileDp.Text = fileNameArr[0] + fileNameArr[1] + "_KiCad\\";
            }
        }

        private void fileCb_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "P-CAD V16, V17 Schemaic (*.SCH)|*.SCH|SCH Document (*.SchDoc)|*.SchDoc|All Files|*.*";
            openFileDialog1.FileName = fileCp.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileCp.Text = openFileDialog1.FileName;
            }
        }

        private void fileDb_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = fileDp.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                fileDp.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private string[] getFileName(string filePath)
        {
            string[] pathArr = filePath.Split('\\');
            string fileFullName = pathArr[pathArr.Length - 1];
            string[] fileNameArr = fileFullName.Split('.');
            string filename = fileNameArr[0];
            string extname = fileNameArr[0];
            string path = "";
            for (int i = 0; i < pathArr.Length - 1; i++)
            {
                string subDir = pathArr[i];
                path = path + subDir + "\\";
            }
            string[] pathInfo = { path, filename, extname };
            return pathInfo;
        }

        private void fileAp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void fileAp_DragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void fileBp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void fileBp_DragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void fileCp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void fileCp_DragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void fileDp_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void fileDp_DragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void logAdd(string log)
        {
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            convLog.Items.Add("[" + dateStr + "] " + log);
            convLog.SelectedIndex = convLog.Items.Count - 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            convLog.Items.Clear();
            tabControl1.SelectTab(1);
            logAdd("正在准备开始...");
            if (fileAp.Text.Length == 0 || fileBp.Text.Length == 0 || fileCp.Text.Length == 0 || fileDp.Text.Length == 0)
            {
                logAdd("错误：请填写所有的路径框。");
            }
        }
    }
}
