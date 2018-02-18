using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyopenv1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;

            string title = textBox1.Text;
            string msg = textBox2.Text;
            notifyIcon1.ShowBalloonTip(600, title, msg, ToolTipIcon.Info);

        }
    }
}
