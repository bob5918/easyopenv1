using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace easyopenv1
{
    public partial class eoform2 : Form
    {
        public eoform2()
        {
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Console by Bob5918 Mini Gui by Bob5918");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = HWIDGen.Value();
            

        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                WebClient client = new WebClient();
                var text = client.DownloadString("");
                label2.Text = text;
            }
            catch
            {
                label2.Text = "Failed to get msg!";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                WebClient client = new WebClient();
                var text = client.DownloadString("");
                label2.Text = text;
            }
            catch
            {
                label2.Text = "Failed to get msg!";
            }

            }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.me/easyopener");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    WebClient client = new WebClient();
                    var uni = client.DownloadString("");

                    string[] Titles = { uni };

                    textBox2.Text = Titles[new Random().Next(0, Titles.Length)];
                }
            }
            finally
            {
               if (checkBox1.Checked == false)
                {
                    WebClient client = new WebClient();
                    var non = client.DownloadString("");
                    string[] Titles2 = { non };
                    textBox2.Text = Titles2[new Random().Next(0, Titles2.Length)];
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
