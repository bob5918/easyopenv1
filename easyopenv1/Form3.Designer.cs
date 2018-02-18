namespace easyopenv1
{
    partial class eoform1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eoform1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMOTDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHWIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hWIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Whitelist needed!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.whitelistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getMOTDToolStripMenuItem,
            this.changeColorToolStripMenuItem,
            this.resetColorToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // getMOTDToolStripMenuItem
            // 
            this.getMOTDToolStripMenuItem.Name = "getMOTDToolStripMenuItem";
            this.getMOTDToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.getMOTDToolStripMenuItem.Text = "GetMOTD";
            this.getMOTDToolStripMenuItem.Click += new System.EventHandler(this.getMOTDToolStripMenuItem_Click);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // resetColorToolStripMenuItem
            // 
            this.resetColorToolStripMenuItem.Name = "resetColorToolStripMenuItem";
            this.resetColorToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.resetColorToolStripMenuItem.Text = "Reset Color";
            this.resetColorToolStripMenuItem.Click += new System.EventHandler(this.resetColorToolStripMenuItem_Click);
            // 
            // whitelistToolStripMenuItem
            // 
            this.whitelistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkHWIDToolStripMenuItem,
            this.getToolStripMenuItem});
            this.whitelistToolStripMenuItem.Name = "whitelistToolStripMenuItem";
            this.whitelistToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.whitelistToolStripMenuItem.Text = "Whitelist";
            // 
            // checkHWIDToolStripMenuItem
            // 
            this.checkHWIDToolStripMenuItem.Name = "checkHWIDToolStripMenuItem";
            this.checkHWIDToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.checkHWIDToolStripMenuItem.Text = "Check HWID";
            this.checkHWIDToolStripMenuItem.Click += new System.EventHandler(this.checkHWIDToolStripMenuItem_Click);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hWIDToolStripMenuItem});
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.getToolStripMenuItem.Text = "Get";
            // 
            // hWIDToolStripMenuItem
            // 
            this.hWIDToolStripMenuItem.Name = "hWIDToolStripMenuItem";
            this.hWIDToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.hWIDToolStripMenuItem.Text = "HWID";
            this.hWIDToolStripMenuItem.Click += new System.EventHandler(this.hWIDToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 299);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(286, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(509, 344);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 94);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Codes!\n-\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(567, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 307);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HWIDs..";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(308, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(302, 272);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox3.Size = new System.Drawing.Size(302, 272);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // eoform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "eoform1";
            this.Text = "Staff Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMOTDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem resetColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkHWIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hWIDToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}