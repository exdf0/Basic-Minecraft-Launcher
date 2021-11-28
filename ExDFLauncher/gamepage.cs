using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;
using MCServerStatus;
using MCServerStatus.Models;

namespace ExDFLauncher
{
    public partial class gamepage : Form
    {
        public gamepage()
        {
            InitializeComponent();

        }

        private void gamepage_Load(object sender, EventArgs e)
        {
            ServerStatus();
            guna2Panel1.BackColor = Color.FromArgb(155, Color.Black);
            label1.Text = mainpage.username;
          string   kadi = mainpage.username;
            var request = WebRequest.Create("https://minotar.net/cube/"+ kadi + "/60.png");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private async Task ServerStatus()
        {
            IMinecraftPinger pinger = new MinecraftPinger("play.craftrise.tc", 25565);
            var status = await pinger.RequestAsync();
            String server = status.Players.Online + "/" + status.Players.Online;
            label4.Text = server;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            gamelaunch playgame = new gamelaunch();
            playgame.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
