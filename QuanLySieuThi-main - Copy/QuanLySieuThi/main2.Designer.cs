namespace QuanLySieuThi
{
    partial class main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_quanly,
            this.mn_banhang,
            this.mn_hethong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mn_quanly
            // 
            this.mn_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ql_nhanvien,
            this.ql_ncc,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýĐơnHàngToolStripMenuItem});
            this.mn_quanly.Name = "mn_quanly";
            this.mn_quanly.Size = new System.Drawing.Size(116, 55);
            this.mn_quanly.Text = "Quản lý ";
            this.mn_quanly.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // ql_nhanvien
            // 
            this.ql_nhanvien.Name = "ql_nhanvien";
            this.ql_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.ql_nhanvien.Size = new System.Drawing.Size(429, 36);
            this.ql_nhanvien.Text = "- Quản lý tài khoản";
            this.ql_nhanvien.Click += new System.EventHandler(this.ql_nhanvien_Click);
            // 
            // ql_ncc
            // 
            this.ql_ncc.Name = "ql_ncc";
            this.ql_ncc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.ql_ncc.Size = new System.Drawing.Size(429, 36);
            this.ql_ncc.Text = "- Quản lý nhà cung cấp";
            this.ql_ncc.Click += new System.EventHandler(this.ql_ncc_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(429, 36);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "- Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(429, 36);
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "- Quản lý đơn hàng";
            this.quảnLýĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐơnHàngToolStripMenuItem_Click);
            // 
            // mn_banhang
            // 
            this.mn_banhang.Name = "mn_banhang";
            this.mn_banhang.Size = new System.Drawing.Size(129, 55);
            this.mn_banhang.Text = "Bán hàng";
            this.mn_banhang.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // mn_hethong
            // 
            this.mn_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mn_hethong.Name = "mn_hethong";
            this.mn_hethong.Size = new System.Drawing.Size(145, 55);
            this.mn_hethong.Text = " Đăng xuất";
            this.mn_hethong.Click += new System.EventHandler(this.mn_hethong_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 6);
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.Color.Red;
            this.lb_quyen.Location = new System.Drawing.Point(674, 23);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(0, 22);
            this.lb_quyen.TabIndex = 2;
            this.lb_quyen.Click += new System.EventHandler(this.lb_quyen_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuThi.Properties.Resources.sieuthi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 607);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị";
            this.Load += new System.EventHandler(this.main2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label lb_quyen;
        public System.Windows.Forms.ToolStripMenuItem mn_hethong;
        public System.Windows.Forms.ToolStripMenuItem mn_quanly;
        public System.Windows.Forms.ToolStripMenuItem ql_ncc;
        public System.Windows.Forms.ToolStripMenuItem ql_nhanvien;
        public System.Windows.Forms.ToolStripMenuItem mn_banhang;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
    }
}