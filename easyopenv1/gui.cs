using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Net;
using System.Threading;

namespace easyopenv1
{
    public partial class eoform3 : Form
    {
        public eoform3()
        {
            InitializeComponent();

        }
        public string id = ""
; private string Get(string get)
        {
            try
            {
                WebClient wc = new WebClient();
                if (get == "Id")
                {
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(wc.DownloadString("https://api.roblox.com/users/get-by-username?username=" + usernameBox.Text))))
                    {
                        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(ROBLOXDataFromUsername));
                        ROBLOXDataFromUsername RDFUObj = (ROBLOXDataFromUsername)deserializer.ReadObject(ms);
                        id = RDFUObj.Id;
                        wc.Dispose();
                        return RDFUObj.Id;
                    }
                }
                else if (get == "Picture")
                {
                    wc.Dispose();
                    return "https://assetgame.roblox.com/Thumbs/Avatar.ashx?x=250&y=250&Format=Png&username=" + usernameBox.Text;
                }
                else if (get == "Online")
                {
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(wc.DownloadString("https://api.roblox.com/users/get-by-username?username=" + usernameBox.Text))))
                    {
                        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(ROBLOXDataFromUsername));
                        ROBLOXDataFromUsername RDFUObj = (ROBLOXDataFromUsername)deserializer.ReadObject(ms);
                        wc.Dispose();
                        return RDFUObj.IsOnline;
                    }
                }
                else if (get == "Badges")
                {
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(wc.DownloadString("https://www.roblox.com/badges/roblox?userId=" + id + "&imgWidth=110&imgHeight=110&imgFormat=png"))))
                    {
                        DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(ROBLOXDataFromUsername));
                        ROBLOXDataFromUsername RDFUObj = (ROBLOXDataFromUsername)deserializer.ReadObject(ms);
                        wc.Dispose();
                        return RDFUObj.IsOnline;
                    }
                }
                else if (get == "bc")
                {
                    wc.Dispose();
                    return "https://www.roblox.com/Thumbs/BCOverlay.ashx?username=" + usernameBox.Text;
                }

                else
                {
                    return "Error finding info.";
                }
            }
            catch
            {
                return "Error finding info.";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Welcome", "Hello welcome to GetInfo!", ToolTipIcon.Info);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userID.Text = "ID: " + Get("Id");
            userPicture.Load(Get("Picture"));
            isOnline.Text = "Online: " + Get("Online");
            bcPic.Load(Get("bc"));



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ROBLOX API Help/Code help by GtaMasterYT Coded/Server Hoster by Bob5918");
        }

        private void mOTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var motd = "dead";
            MessageBox.Show(motd);


                }

        private void mAINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void memesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;

        }
    }
}
