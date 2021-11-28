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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width>=350)
            {
                timer1.Stop();
                label2.Visible = true;
                label3.Text = "Oynama hazırsınız!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mainpage main = new mainpage();
            main.Show();
            Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
