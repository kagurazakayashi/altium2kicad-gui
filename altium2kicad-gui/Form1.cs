using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace altium2kicad_gui
{
    public partial class Form1 : Form
    {
        private string perl = "";
        public Form1()
        {
            InitializeComponent();
            fileAp.Text = Directory.GetCurrentDirectory() + "\\altium2kicad";
            Process p = new Process();
            p.StartInfo.FileName = "where";
            p.StartInfo.Arguments = "perl";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            perl = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            perl = perl.Split('\n')[0];
            if (perl.Length < 5)
            {
                logAdd("错误： 找不到 Perl 运行时。");
                logAdd("请先安装 Perl ，然后退出并重新运行本软件。");
                return;
            }
            logAdd("Perl 运行时路径：" + perl);
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
            openFileDialog1.Filter = "PCB Binary Files (*.PcbDoc)|*.PcbDoc";
            openFileDialog1.FileName = fileBp.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileBp.Text = openFileDialog1.FileName;
                autoInput();
            }
        }

        private void autoInput()
        {
            if (fileCp.Text.Length == 0)
            {
                string[] fileNameArr = getFileName(fileBp.Text);
                fileCp.Text = fileNameArr[0] + fileNameArr[1] + ".SchDoc";
            }
            if (fileDp.Text.Length == 0)
            {
                string[] fileNameArr = getFileName(fileBp.Text);
                fileDp.Text = fileNameArr[0] + fileNameArr[1] + "_KiCad";
            }
        }

        private void fileCb_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Advanced Schematic binary (*.SchDoc)|*.SchDoc";
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
            string extname = fileNameArr[1];
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
            autoInput();
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

        void DeleteDirectory(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                DirectoryInfo[] childs = dir.GetDirectories();
                foreach (DirectoryInfo child in childs)
                {
                    child.Delete(true);
                }
                dir.Delete(true);
            }
        }

        private void start()
        {
            tabControl1.SelectTab(2);
            logAdd("正在准备开始...");
            if (perl.Length == 0)
            {
                return;
            }
            if (fileAp.Text.Length == 0)
            {
                logAdd("错误： 必须指定 altium2kicad 的文件夹路径。");
                return;
            }
            if (fileBp.Text.Length == 0 && fileCp.Text.Length == 0)
            {
                logAdd("错误： .PcbDoc 和 .SchDoc 至少要有一个。");
                return;
            }

            TextBox[] textBoxes = { fileAp, fileBp, fileCp, fileDp };
            bool[] isDir = { true, false, false, true };
            bool isErr = false;
            bool newDir = false;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                TextBox textBox = textBoxes[i];
                string text = textBox.Text;
                if (text.Length > 0)
                {
                    if (isDir[i] == true && !Directory.Exists(text) || isDir[i] == false && !File.Exists(text))
                    {
                        if (i == textBoxes.Length - 1)
                        {
                            newDir = true;
                        }
                        else
                        {
                            isErr = true;
                            logAdd("错误：找不到文件或文件夹 " + text + " 。");
                        }
                    }
                }
            }
            if (fileBp.Text.Length > 0)
            {
                string[] fileNameArr = fileBp.Text.Split('.');
                if (fileNameArr[fileNameArr.Length - 1] != "PcbDoc")
                {
                    isErr = true;
                    logAdd("错误：电路板文件必须是 .PcbDoc 文件，格式为 PCB Binary File 。");
                }
            }
            if (fileCp.Text.Length > 0)
            {
                string[] fileNameArr = fileCp.Text.Split('.');
                if (fileNameArr[fileNameArr.Length - 1] != "SchDoc")
                {
                    isErr = true;
                    logAdd("错误：原理图文件必须是 .SchDoc 文件，格式为 Advanced Schematic binary 。");
                }
            }
            if (isErr)
            {
                return;
            }

            string toFile1 = "";
            string toFile2 = "";
            string[] fileNpArr = { };

            if (fileBp.Text.Length > 0)
            {
                string[] fileBpArr = getFileName(fileBp.Text);
                string fromFile1 = fileBp.Text;
                toFile1 = fileAp.Text + "\\" + fileBpArr[1] + "." + fileBpArr[2];
                logAdd("复制临时文件 " + fromFile1 + " → " + toFile1 + " ...");
                try
                {
                    File.Copy(fromFile1, toFile1, true);
                }
                catch (Exception err)
                {
                    logAdd("错误： " + err.Message);
                    return;
                }
                fileNpArr = fileBpArr;
            }
            if (fileCp.Text.Length > 0)
            {
                string[] fileCpArr = getFileName(fileCp.Text);
                string fromFile2 = fileCp.Text;
                toFile2 = fileAp.Text + "\\" + fileCpArr[1] + "." + fileCpArr[2];
                logAdd("复制临时文件 " + fromFile2 + " → " + toFile2 + " ...");
                try
                {
                    File.Copy(fromFile2, toFile2, true);
                }
                catch (Exception err)
                {
                    logAdd("错误： " + err.Message);
                    return;
                }
                fileNpArr = fileCpArr;
            }
            string[] strOuput = { };
            Thread.Sleep(1000);
            logAdd("解压封包...");
            Process p = new Process();
            p.StartInfo.FileName = perl;
            p.StartInfo.Arguments = "unpack.pl";
            p.StartInfo.WorkingDirectory = fileAp.Text;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            strOuput = p.StandardOutput.ReadToEnd().Split('\n');
            p.WaitForExit();
            p.Close();
            for (int i = 0; i < strOuput.Length; i++)
            {
                logAdd(strOuput[i]);
            }
            logAdd("解压封包结束。");
            Thread.Sleep(1000);

            if (fileCp.Text.Length > 0)
            {
                logAdd("转换原理图...");
                p = new Process();
                p.StartInfo.FileName = perl;
                p.StartInfo.Arguments = "convertschema.pl";
                p.StartInfo.WorkingDirectory = fileAp.Text;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                strOuput = p.StandardOutput.ReadToEnd().Split('\n');
                p.WaitForExit();
                p.Close();
                for (int i = 0; i < strOuput.Length; i++)
                {
                    logAdd(strOuput[i]);
                }
                logAdd("转换原理图结束。");
                Thread.Sleep(1000);
            }
            if (fileBp.Text.Length > 0)
            {
                logAdd("转换 PCB ...");
                p = new Process();
                p.StartInfo.FileName = perl;
                p.StartInfo.Arguments = "convertpcb.pl";
                p.StartInfo.WorkingDirectory = fileAp.Text;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                strOuput = p.StandardOutput.ReadToEnd().Split('\n');
                p.WaitForExit();
                p.Close();
                for (int i = 0; i < strOuput.Length; i++)
                {
                    logAdd(strOuput[i]);
                }
                logAdd("转换 PCB 结束。");
            }

            Thread.Sleep(2000);
            string[] tmpFileName = { toFile1, toFile2, fileAp.Text + "\\Pads.html", fileAp.Text + "\\Pads.txt", fileAp.Text + "\\wrlshapes.kicad_pcb" };
            for (int i = 0; i < tmpFileName.Length; i++)
            {
                if (tmpFileName[i].Length == 0)
                {
                    continue;
                }
                try
                {
                    logAdd("删除临时文件 " + tmpFileName[i] + " ...");
                    File.Delete(tmpFileName[i]);
                }
                catch (Exception err)
                {
                    logAdd("警告： " + err.Message);
                }
            }
            string[] tmpDirName = { "-PcbDoc", "-SchDoc" };
            for (int i = 0; i < tmpDirName.Length; i++)
            {
                try
                {
                    string tdir = fileAp.Text + "\\" + fileNpArr[1] + tmpDirName[i];
                    logAdd("删除临时文件夹 " + tdir + " ...");
                    DeleteDirectory(tdir);
                }
                catch (Exception err)
                {
                    logAdd("警告： " + err.Message);
                }
            }

            string[] files = Directory.GetFiles(fileAp.Text, fileNpArr[1] + "*");
            if (newDir)
            {
                logAdd("正在创建目标文件夹 " + fileDp.Text + " ...");
                Directory.CreateDirectory(fileDp.Text);
            }

            Thread.Sleep(1000);
            foreach (string file in files)
            {
                string[] fArr = getFileName(file);
                string toFile = fileDp.Text + "\\" + fArr[1] + "." + fArr[2];
                logAdd("导出文件 " + file + " → " + toFile + " ...");
                try
                {
                    File.Copy(file, toFile, true);
                    File.Delete(file);
                }
                catch (Exception err)
                {
                    logAdd("错误： " + err.Message);
                }
            }
            logAdd("运行结束。");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            convLog.Items.Clear();
            workAlert.Visible = true;
            UseWaitCursor = true;
            start();
            UseWaitCursor = false;
            workAlert.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fileBp.Text = "";
            fileCp.Text = "";
            fileDp.Text = "";
            convLog.Items.Clear();
        }
    }
}
