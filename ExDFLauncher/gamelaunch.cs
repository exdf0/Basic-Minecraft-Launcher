using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;
using MCServerStatus;
using MCServerStatus.Models;

namespace ExDFLauncher
{
    public partial class gamelaunch : Form
    {
        public gamelaunch()
        {
            InitializeComponent();
            var session = MSession.GetOfflineSession(mainpage.username);
            Control.CheckForIllegalCrossThreadCalls = false;
            label3.Text = mainpage.username;
        }
        public static string version;
        MSession session;

        private void path()
        {

            System.Net.ServicePointManager.DefaultConnectionLimit = 256;

          
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount)) ;
            };
            launcher.ProgressChanged += (s, e) =>
            {
             //   Console.WriteLine("{0}%", e.ProgressPercentage);
            };

 
            foreach (var item in launcher.GetAllVersions())
            {
               
                guna2ComboBox1.Items.Add(item.Name);
            }
        }

        private void launch()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;


            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,
              


                ServerIp = "play.craftrise.tc"
            };
            version = guna2ComboBox1.SelectedItem.ToString();

            var process = launcher.CreateProcess(version, launchOption); // vanilla

            process.Start();
            Hide();
        }

        private void gamelaunch_Load(object sender, EventArgs e)
        {
            path();
            guna2Panel2.BackColor = Color.FromArgb(155, Color.Black);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            guna2GradientButton1.Enabled = false;
            Thread thread = new Thread(() => launch());
            thread.IsBackground = true;
            thread.Start();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
