namespace HomePage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Panel();
            this.cms_txt = new System.Windows.Forms.Label();
            this.extbtn = new System.Windows.Forms.Button();
            this.hmbtn = new System.Windows.Forms.Button();
            this.glrbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.rgtbtn = new System.Windows.Forms.Button();
            this.abtbtn = new System.Windows.Forms.Button();
            this.title_txt = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.utbbtn = new System.Windows.Forms.Button();
            this.fbbtn = new System.Windows.Forms.Button();
            this.lnkdbtn = new System.Windows.Forms.Button();
            this.instbtn = new System.Windows.Forms.Button();
            this.urlbtn = new System.Windows.Forms.Button();
            this.cprgts_txt = new System.Windows.Forms.Label();
            this.slidepic = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.dashboard.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidepic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(89, 66);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard.BackgroundImage")));
            this.dashboard.Controls.Add(this.cms_txt);
            this.dashboard.Controls.Add(this.extbtn);
            this.dashboard.Controls.Add(this.hmbtn);
            this.dashboard.Controls.Add(this.glrbtn);
            this.dashboard.Controls.Add(this.loginbtn);
            this.dashboard.Controls.Add(this.rgtbtn);
            this.dashboard.Controls.Add(this.abtbtn);
            this.dashboard.Controls.Add(this.title_txt);
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(1047, 169);
            this.dashboard.TabIndex = 4;
            this.dashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboard_Paint);
            // 
            // cms_txt
            // 
            this.cms_txt.AutoSize = true;
            this.cms_txt.BackColor = System.Drawing.Color.Transparent;
            this.cms_txt.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cms_txt.ForeColor = System.Drawing.SystemColors.Info;
            this.cms_txt.Location = new System.Drawing.Point(7, 69);
            this.cms_txt.Name = "cms_txt";
            this.cms_txt.Size = new System.Drawing.Size(70, 30);
            this.cms_txt.TabIndex = 8;
            this.cms_txt.Text = "CMS";
            this.cms_txt.Click += new System.EventHandler(this.cms_txt_Click);
            // 
            // extbtn
            // 
            this.extbtn.BackColor = System.Drawing.Color.Transparent;
            this.extbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.extbtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.extbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.extbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.extbtn.Location = new System.Drawing.Point(878, 118);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(174, 52);
            this.extbtn.TabIndex = 7;
            this.extbtn.Text = "EXIT";
            this.extbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.extbtn.UseVisualStyleBackColor = true;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // hmbtn
            // 
            this.hmbtn.BackColor = System.Drawing.Color.Transparent;
            this.hmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hmbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.hmbtn.Location = new System.Drawing.Point(-1, 118);
            this.hmbtn.Name = "hmbtn";
            this.hmbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.hmbtn.Size = new System.Drawing.Size(191, 52);
            this.hmbtn.TabIndex = 2;
            this.hmbtn.Text = "HOME";
            this.hmbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.hmbtn.UseVisualStyleBackColor = true;
            this.hmbtn.Click += new System.EventHandler(this.hmbtn_Click);
            // 
            // glrbtn
            // 
            this.glrbtn.BackColor = System.Drawing.Color.Transparent;
            this.glrbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.glrbtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.glrbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.glrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.glrbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glrbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.glrbtn.Location = new System.Drawing.Point(542, 118);
            this.glrbtn.Name = "glrbtn";
            this.glrbtn.Size = new System.Drawing.Size(174, 52);
            this.glrbtn.TabIndex = 6;
            this.glrbtn.Text = "GALLERY";
            this.glrbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.glrbtn.UseVisualStyleBackColor = true;
            this.glrbtn.Click += new System.EventHandler(this.glrbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.loginbtn.Location = new System.Drawing.Point(360, 118);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(182, 52);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // rgtbtn
            // 
            this.rgtbtn.BackColor = System.Drawing.Color.Transparent;
            this.rgtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rgtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgtbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgtbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.rgtbtn.Location = new System.Drawing.Point(177, 118);
            this.rgtbtn.Name = "rgtbtn";
            this.rgtbtn.Size = new System.Drawing.Size(204, 52);
            this.rgtbtn.TabIndex = 3;
            this.rgtbtn.Text = "REGISTER";
            this.rgtbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rgtbtn.UseVisualStyleBackColor = true;
            this.rgtbtn.Click += new System.EventHandler(this.rgtbtn_Click);
            // 
            // abtbtn
            // 
            this.abtbtn.BackColor = System.Drawing.Color.Transparent;
            this.abtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.abtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.abtbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.abtbtn.Location = new System.Drawing.Point(706, 118);
            this.abtbtn.Name = "abtbtn";
            this.abtbtn.Size = new System.Drawing.Size(180, 53);
            this.abtbtn.TabIndex = 5;
            this.abtbtn.Text = "ABOUT";
            this.abtbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.abtbtn.UseVisualStyleBackColor = false;
            this.abtbtn.Click += new System.EventHandler(this.abtbtn_Click);
            // 
            // title_txt
            // 
            this.title_txt.AutoSize = true;
            this.title_txt.BackColor = System.Drawing.Color.Transparent;
            this.title_txt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.title_txt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.title_txt.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title_txt.Location = new System.Drawing.Point(159, -32);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(796, 97);
            this.title_txt.TabIndex = 3;
            this.title_txt.Text = "\r\nCOMMUNITY  MANAGEMENT  SYSTEM";
            this.title_txt.UseCompatibleTextRendering = true;
            this.title_txt.UseWaitCursor = true;
            this.title_txt.Click += new System.EventHandler(this.title_txt_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Transparent;
            this.footer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("footer.BackgroundImage")));
            this.footer.Controls.Add(this.utbbtn);
            this.footer.Controls.Add(this.fbbtn);
            this.footer.Controls.Add(this.lnkdbtn);
            this.footer.Controls.Add(this.instbtn);
            this.footer.Controls.Add(this.urlbtn);
            this.footer.Controls.Add(this.cprgts_txt);
            this.footer.Location = new System.Drawing.Point(-1, 636);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1053, 56);
            this.footer.TabIndex = 13;
            this.footer.Paint += new System.Windows.Forms.PaintEventHandler(this.footer_Paint);
            // 
            // utbbtn
            // 
            this.utbbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("utbbtn.BackgroundImage")));
            this.utbbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.utbbtn.Location = new System.Drawing.Point(713, 3);
            this.utbbtn.Name = "utbbtn";
            this.utbbtn.Size = new System.Drawing.Size(31, 30);
            this.utbbtn.TabIndex = 18;
            this.utbbtn.UseVisualStyleBackColor = true;
            this.utbbtn.Click += new System.EventHandler(this.utbbtn_Click);
            // 
            // fbbtn
            // 
            this.fbbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fbbtn.BackgroundImage")));
            this.fbbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbbtn.Location = new System.Drawing.Point(290, 3);
            this.fbbtn.Name = "fbbtn";
            this.fbbtn.Size = new System.Drawing.Size(31, 30);
            this.fbbtn.TabIndex = 17;
            this.fbbtn.UseVisualStyleBackColor = true;
            this.fbbtn.Click += new System.EventHandler(this.fbbtn_Click);
            // 
            // lnkdbtn
            // 
            this.lnkdbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnkdbtn.BackgroundImage")));
            this.lnkdbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lnkdbtn.Location = new System.Drawing.Point(574, 2);
            this.lnkdbtn.Name = "lnkdbtn";
            this.lnkdbtn.Size = new System.Drawing.Size(31, 31);
            this.lnkdbtn.TabIndex = 16;
            this.lnkdbtn.UseVisualStyleBackColor = true;
            this.lnkdbtn.Click += new System.EventHandler(this.lnkdbtn_Click);
            // 
            // instbtn
            // 
            this.instbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instbtn.BackgroundImage")));
            this.instbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instbtn.Location = new System.Drawing.Point(426, 3);
            this.instbtn.Name = "instbtn";
            this.instbtn.Size = new System.Drawing.Size(31, 30);
            this.instbtn.TabIndex = 15;
            this.instbtn.UseVisualStyleBackColor = true;
            this.instbtn.Click += new System.EventHandler(this.instbtn_Click);
            // 
            // urlbtn
            // 
            this.urlbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlbtn.BackgroundImage")));
            this.urlbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urlbtn.Location = new System.Drawing.Point(179, 3);
            this.urlbtn.Name = "urlbtn";
            this.urlbtn.Size = new System.Drawing.Size(31, 31);
            this.urlbtn.TabIndex = 14;
            this.urlbtn.UseVisualStyleBackColor = true;
            this.urlbtn.Click += new System.EventHandler(this.urlbtn_Click);
            // 
            // cprgts_txt
            // 
            this.cprgts_txt.AutoSize = true;
            this.cprgts_txt.BackColor = System.Drawing.Color.Transparent;
            this.cprgts_txt.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cprgts_txt.ForeColor = System.Drawing.Color.White;
            this.cprgts_txt.Location = new System.Drawing.Point(233, 35);
            this.cprgts_txt.Name = "cprgts_txt";
            this.cprgts_txt.Size = new System.Drawing.Size(458, 15);
            this.cprgts_txt.TabIndex = 12;
            this.cprgts_txt.Text = "© Copyright 2010-2020 Community management system | All Rights Reserved";
            // 
            // slidepic
            // 
            this.slidepic.ErrorImage = null;
            this.slidepic.Image = ((System.Drawing.Image)(resources.GetObject("slidepic.Image")));
            this.slidepic.Location = new System.Drawing.Point(0, 166);
            this.slidepic.MaximumSize = new System.Drawing.Size(1047, 471);
            this.slidepic.MinimumSize = new System.Drawing.Size(1047, 471);
            this.slidepic.Name = "slidepic";
            this.slidepic.Size = new System.Drawing.Size(1047, 471);
            this.slidepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidepic.TabIndex = 14;
            this.slidepic.TabStop = false;
            this.slidepic.WaitOnLoad = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1047, 690);
            this.Controls.Add(this.slidepic);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.footer);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hmbtn;
        private System.Windows.Forms.Button rgtbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button abtbtn;
        private System.Windows.Forms.Button glrbtn;
        private System.Windows.Forms.Label title_txt;
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.Label cms_txt;
        private System.Windows.Forms.Label cprgts_txt;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button utbbtn;
        private System.Windows.Forms.Button fbbtn;
        private System.Windows.Forms.Button lnkdbtn;
        private System.Windows.Forms.Button instbtn;
        private System.Windows.Forms.Button urlbtn;
        private System.Windows.Forms.PictureBox slidepic;
        private System.Windows.Forms.Timer timer2;

    }
}

