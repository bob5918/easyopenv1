namespace easyopenv1
{
    partial class eoform3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eoform3));
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bcPic = new System.Windows.Forms.PictureBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.isOnline = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOTDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(2, 31);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(244, 199);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bcPic
            // 
            this.bcPic.Location = new System.Drawing.Point(2, 236);
            this.bcPic.Name = "bcPic";
            this.bcPic.Size = new System.Drawing.Size(244, 45);
            this.bcPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bcPic.TabIndex = 2;
            this.bcPic.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(0, 287);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(244, 22);
            this.usernameBox.TabIndex = 3;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(252, 31);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(29, 17);
            this.userID.TabIndex = 4;
            this.userID.Text = "NIL";
            // 
            // isOnline
            // 
            this.isOnline.AutoSize = true;
            this.isOnline.Location = new System.Drawing.Point(249, 102);
            this.isOnline.Name = "isOnline";
            this.isOnline.Size = new System.Drawing.Size(29, 17);
            this.isOnline.TabIndex = 5;
            this.isOnline.Text = "NIL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(255, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ontop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAINToolStripMenuItem
            // 
            this.mAINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.mOTDToolStripMenuItem,
            this.memesToolStripMenuItem});
            this.mAINToolStripMenuItem.Name = "mAINToolStripMenuItem";
            this.mAINToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.mAINToolStripMenuItem.Text = "MAIN";
            this.mAINToolStripMenuItem.Click += new System.EventHandler(this.mAINToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // mOTDToolStripMenuItem
            // 
            this.mOTDToolStripMenuItem.Name = "mOTDToolStripMenuItem";
            this.mOTDToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.mOTDToolStripMenuItem.Text = "MOTD";
            this.mOTDToolStripMenuItem.Click += new System.EventHandler(this.mOTDToolStripMenuItem_Click);
            // 
            // memesToolStripMenuItem
            // 
            this.memesToolStripMenuItem.Name = "memesToolStripMenuItem";
            this.memesToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.memesToolStripMenuItem.Text = "Memes";
            this.memesToolStripMenuItem.Click += new System.EventHandler(this.memesToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // eoform3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 365);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.isOnline);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.bcPic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "eoform3";
            this.Text = "ROBLOX GetInfo by GtaMasterYT and Bob5918!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox bcPic;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label isOnline;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOTDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

