using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace usbkill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        int shutdowntype = 0;
        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x219;
            const int DBT_DEVICEARRIVAL = 0x8000;
            const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

            object ojb = new object();
            try
            {
                // WM_DEVICECHANGE Message : 電腦硬體裝置改變時產生的訊息
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        // DBT_DEVICEARRIVAL Event : 裝置插入並且可以使用時，產生的系統訊息
                        case DBT_DEVICEARRIVAL:
                        // DBT_DEVICEREMOVECOMPLETE Event : 裝置卸載或移除時產生的系統訊息
                        case DBT_DEVICEREMOVECOMPLETE:
                            DeviceChange();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }

        private void DeviceChange()
        {
            ShutDown();
            ShowInfo();
        }
        private void ShowInfo()
        {
            String[] shutdownname = { "無", "鎖定", "休眠", "登出", "關機" };
            if (radioButton0.Checked)
            {
                shutdowntype = 0;
            }
            else if (radioButton1.Checked)
            {
                shutdowntype = 1;
            }
            else if (radioButton2.Checked)
            {
                shutdowntype = 2;
            }
            else if (radioButton3.Checked)
            {
                shutdowntype = 3;
            }
            else if (radioButton4.Checked)
            {
                shutdowntype = 4;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("USB Kill 模式已改為：" + shutdownname[shutdowntype]);
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.DriveType == DriveType.Removable)
                {
                    listBox1.Items.Add("偵測到" + di.Name + "抽取式存放裝置");
                }
            }
        }
        private void ShutDown()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            switch (shutdowntype)
            {
                case 1:
                    p.StandardInput.WriteLine("rundll32.exe user32.dll,LockWorkStation");
                    break;
                case 2:
                    p.StandardInput.WriteLine("shutdown -h");
                    break;
                case 3:
                    p.StandardInput.WriteLine("shutdown -l");
                    break;
                case 4:
                    p.StandardInput.WriteLine("shutdown -s -t 0");
                    break;
            }
            p.StandardInput.WriteLine("exit");
            string sOutput = p.StandardOutput.ReadToEnd();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
