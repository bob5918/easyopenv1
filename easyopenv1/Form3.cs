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

namespace easyopenv1
{
    public partial class eoform1 : Form
    {
        public eoform1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var un = client.DownloadString("");
            var non = client.DownloadString("");
            richTextBox1.AppendText(un + " :: " + non);
            var hwids = client.DownloadString("");
            richTextBox2.Visible = false;
            richTextBox2.AppendText(hwids);
            richTextBox1.Visible = false;
            button1.Visible = false;
            mainToolStripMenuItem.Visible = false;
            richTextBox3.Visible = false;

            progressBar1.Visible = false;
            trackBar1.Visible = false;
            tabControl1.Visible = false;
            
        }

        private void Main_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void getMOTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var motd = client.DownloadString("http://teamnukepvp.com/message.txt");
            MessageBox.Show("MOTD is :: " + motd);

        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
           
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
                menuStrip1.BackColor = cd.Color;



            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = eoform1.DefaultBackColor;
            menuStrip1.BackColor = this.BackColor;


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void checkHWIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           
            
            
                richTextBox1.Visible = true;
                button1.Visible = true;
                mainToolStripMenuItem.Visible = true;

                progressBar1.Visible = true;
                trackBar1.Visible = true;
                label1.Text = "EO Staff Panel";
                whitelistToolStripMenuItem.Visible = false;
                richTextBox3.Visible = true;
                richTextBox2.Visible = true;
                tabControl1.Visible = true;
            

           
        }

        private void hWIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hwid = HWIDGen.Value();
            MessageBox.Show(hwid);
        }
    }
}
