
namespace QuanLySieuThi.quanly
{
    partial class frmThongTinDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinDonHang));
            this.db1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNguoinhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txt_tenvasoluong = new System.Windows.Forms.TextBox();
            this.txt_matdonhang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ngaymua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.Button();
            this.lb_Tile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // db1
            // 
            this.db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db1.Location = new System.Drawing.Point(16, 396);
            this.db1.Margin = new System.Windows.Forms.Padding(4);
            this.db1.Name = "db1";
            this.db1.ReadOnly = true;
            this.db1.RowHeadersWidth = 51;
            this.db1.Size = new System.Drawing.Size(1010, 237);
            this.db1.TabIndex = 55;
            this.db1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db1_CellContentClick);
            this.db1.Click += new System.EventHandler(this.db1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtNguoinhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txt_tenvasoluong);
            this.groupBox1.Controls.Add(this.txt_matdonhang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ngaymua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(784, 235);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNguoinhap
            // 
            this.txtNguoinhap.Enabled = false;
            this.txtNguoinhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoinhap.Location = new System.Drawing.Point(545, 124);
            this.txtNguoinhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguoinhap.Name = "txtNguoinhap";
            this.txtNguoinhap.ReadOnly = true;
            this.txtNguoinhap.Size = new System.Drawing.Size(228, 27);
            this.txtNguoinhap.TabIndex = 67;
            this.txtNguoinhap.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "- Người nhập:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(545, 73);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(228, 27);
            this.txtTotal.TabIndex = 65;
            // 
            // txt_tenvasoluong
            // 
            this.txt_tenvasoluong.Enabled = false;
            this.txt_tenvasoluong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenvasoluong.Location = new System.Drawing.Point(157, 84);
            this.txt_tenvasoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenvasoluong.Multiline = true;
            this.txt_tenvasoluong.Name = "txt_tenvasoluong";
            this.txt_tenvasoluong.ReadOnly = true;
            this.txt_tenvasoluong.Size = new System.Drawing.Size(262, 136);
            this.txt_tenvasoluong.TabIndex = 1;
            // 
            // txt_matdonhang
            // 
            this.txt_matdonhang.Enabled = false;
            this.txt_matdonhang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matdonhang.Location = new System.Drawing.Point(157, 33);
            this.txt_matdonhang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matdonhang.Name = "txt_matdonhang";
            this.txt_matdonhang.ReadOnly = true;
            this.txt_matdonhang.Size = new System.Drawing.Size(208, 27);
            this.txt_matdonhang.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "- Ngày mua:";
            // 
            // txt_ngaymua
            // 
            this.txt_ngaymua.Enabled = false;
            this.txt_ngaymua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaymua.Location = new System.Drawing.Point(545, 33);
            this.txt_ngaymua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngaymua.Name = "txt_ngaymua";
            this.txt_ngaymua.ReadOnly = true;
            this.txt_ngaymua.Size = new System.Drawing.Size(228, 27);
            this.txt_ngaymua.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Tên và số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Mã đơn hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "- Tổng giá trị:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.TongTien);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(805, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(218, 235);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLySieuThi.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Close_Program;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 52);
            this.button1.TabIndex = 57;
            this.button1.Text = "        Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Trash_can;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(13, 42);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(181, 52);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "    Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // TongTien
            // 
            this.TongTien.Image = global::QuanLySieuThi.Properties.Resources.Ziggy19_Microsoft_Office_Mac_Tilt_Excel;
            this.TongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TongTien.Location = new System.Drawing.Point(13, 175);
            this.TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(181, 52);
            this.TongTien.TabIndex = 61;
            this.TongTien.Text = "Xuất Excel";
            this.TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TongTien.UseVisualStyleBackColor = true;
            this.TongTien.Click += new System.EventHandler(this.TongTien_Click);
            // 
            // lb_Tile
            // 
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.ForeColor = System.Drawing.Color.Red;
            this.lb_Tile.Location = new System.Drawing.Point(312, 22);
            this.lb_Tile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(415, 48);
            this.lb_Tile.TabIndex = 69;
            this.lb_Tile.Text = "Thông tin đơn hàng";
            // 
            // frmThongTinDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 637);
            this.Controls.Add(this.lb_Tile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.db1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTinDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Thông tin đơn hàng";
            this.Load += new System.EventHandler(this.frmThongTinDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView db1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNguoinhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txt_tenvasoluong;
        private System.Windows.Forms.TextBox txt_matdonhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ngaymua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button TongTien;
        private System.Windows.Forms.Label lb_Tile;
    }
}