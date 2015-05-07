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
        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x219;
            const int DBT_DEVICEARRIVAL = 0x8000;
            const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        case DBT_DEVICEARRIVAL:
                            DeviceChange(0);
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            DeviceChange(1);
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

        int shutdowntype_insert = 0;
        int shutdowntype_remove = 0;
        private void DeviceChange(int n)
        {
            ShutDown(n);
            ShowInfo();
        }
        private void ShowInfo()
        {
            String[] shutdownname = { "None", "Lock", "Hibernate", "Sign out", "Shut down" };
            if (radioButton00.Checked)
            {
                shutdowntype_insert = 0;
            }
            else if (radioButton01.Checked)
            {
                shutdowntype_insert = 1;
            }
            else if (radioButton02.Checked)
            {
                shutdowntype_insert = 2;
            }
            else if (radioButton03.Checked)
            {
                shutdowntype_insert = 3;
            }
            else if (radioButton04.Checked)
            {
                shutdowntype_insert = 4;
            }
            if (radioButton10.Checked)
            {
                shutdowntype_remove = 0;
            }
            else if (radioButton11.Checked)
            {
                shutdowntype_remove = 1;
            }
            else if (radioButton12.Checked)
            {
                shutdowntype_remove = 2;
            }
            else if (radioButton13.Checked)
            {
                shutdowntype_remove = 3;
            }
            else if (radioButton14.Checked)
            {
                shutdowntype_remove = 4;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("USB Kill Insert mode : " + shutdownname[shutdowntype_insert%10]);
            listBox1.Items.Add("USB Kill Remove mode : " + shutdownname[shutdowntype_remove%10]);
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.DriveType == DriveType.Removable)
                {
                    listBox1.Items.Add("Connect: " + di.Name);
                }
            }
        }
        private void ShutDown(int n)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            int shutdowntype = 0;
            if (n == 0)
            {
                shutdowntype = shutdowntype_insert;
            }
            else if (n == 1)
            {
                shutdowntype = shutdowntype_remove;
            }
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
