namespace QuanLySieuThi
{
    partial class main1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main1));
            this.label4 = new System.Windows.Forms.Label();
            this.lbsv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbform = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbleff = new System.Windows.Forms.Label();
            this.lblright = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(353, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 71);
            this.label4.TabIndex = 39;
            this.label4.Text = "GVHD : Nguyễn Thu Hường";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbsv
            // 
            this.lbsv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbsv.AutoSize = true;
            this.lbsv.BackColor = System.Drawing.Color.Transparent;
            this.lbsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsv.Location = new System.Drawing.Point(367, 530);
            this.lbsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsv.Name = "lbsv";
            this.lbsv.Size = new System.Drawing.Size(399, 36);
            this.lbsv.TabIndex = 38;
            this.lbsv.Text = "Nhóm Thực Hiện : Nhóm 14  ";
            this.lbsv.Click += new System.EventHandler(this.lbsv_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(0, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1110, 10);
            this.label6.TabIndex = 37;
            // 
            // lbform
            // 
            this.lbform.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbform.BackColor = System.Drawing.Color.Transparent;
            this.lbform.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbform.Location = new System.Drawing.Point(364, 54);
            this.lbform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbform.Name = "lbform";
            this.lbform.Size = new System.Drawing.Size(447, 64);
            this.lbform.TabIndex = 36;
            this.lbform.Text = "Quản Lý Siêu Thị";
            this.lbform.Click += new System.EventHandler(this.lbform_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpHệThốngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 30);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpHệThốngToolStripMenuItem
            // 
            this.đăngNhậpHệThốngToolStripMenuItem.Name = "đăngNhậpHệThốngToolStripMenuItem";
            this.đăngNhậpHệThốngToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngNhậpHệThốngToolStripMenuItem.Text = "Đăng Nhập Hệ thống";
            this.đăngNhậpHệThốngToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpHệThốngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 89);
            this.label1.TabIndex = 44;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI\r\nKHOA CÔNG NGHỆ THÔNG TIN\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbleff
            // 
            this.lbleff.AutoEllipsis = true;
            this.lbleff.Location = new System.Drawing.Point(0, 514);
            this.lbleff.Name = "lbleff";
            this.lbleff.Size = new System.Drawing.Size(357, 10);
            this.lbleff.TabIndex = 45;
            // 
            // lblright
            // 
            this.lblright.AutoEllipsis = true;
            this.lblright.Location = new System.Drawing.Point(3, 579);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(980, 108);
            this.lblright.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(436, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 219);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1110, 595);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblright);
            this.Controls.Add(this.lbleff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbsv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbform);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị";
            this.Load += new System.EventHandler(this.main1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbsv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbform;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbleff;
        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}