using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace easyopenv1
{
    public partial class c_11 : Form
    {
        public c_11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            button1.Visible = false;
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            button4.Visible = false;
            button1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void c_11_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to c-11, beta build!", "c-11 welcome");
            time.Text = System.DateTime.Now.ToShortTimeString();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void notificationHubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToShortTimeString();

        }
    }
}
