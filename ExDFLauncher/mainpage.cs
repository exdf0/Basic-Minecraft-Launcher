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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        public static string username;
        private void mainpage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            username = guna2TextBox1.Text;
            gamepage gamepage = new gamepage();
            gamepage.Show();
            Hide();
        }
    }
}
