using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.quanly
{ 
    public partial class sanpham : Form
    {
        public string chuoi = "select sanpham.masp , sanpham.tensp , nhacungcap.tenncc , sanpham.gianhap , sanpham.giaban , sanpham.solg , sanpham.hsd , sanpham.noisx , sanpham.donvitinh , sanpham.nguoinhap " +
            "from sanpham INNER JOIN nhacungcap ON sanpham.mancc = nhacungcap.mancc";
        
        public sanpham()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();

        }

        public void clear()
        {

            dta1.Columns[0].HeaderText = "Mã Sản phẩm"; dta1.Columns[0].Width = 110;
            dta1.Columns[1].HeaderText = "Tên sản phẩm"; dta1.Columns[1].Width = 150;
            dta1.Columns[2].HeaderText = "Nhà cung cấp"; dta1.Columns[2].Width = 110;
            dta1.Columns[3].HeaderText = "Giá  nhập"; dta1.Columns[3].Width = 110;
            dta1.Columns[4].HeaderText = "Giá bán"; dta1.Columns[4].Width = 110;
            dta1.Columns[5].HeaderText = "Số lượng"; dta1.Columns[5].Width = 110;
            dta1.Columns[6].HeaderText = "Hạn sử dụng"; dta1.Columns[6].Width = 110;
            dta1.Columns[7].HeaderText = "Nơi sản xuất"; dta1.Columns[7].Width = 110;
            dta1.Columns[8].HeaderText = "Đơn vị tính"; dta1.Columns[8].Width = 110;
            dta1.Columns[9].HeaderText = "Người nhập"; dta1.Columns[9].Width = 110;
            mancc();
            txt_masp.Focus();
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_mancc.Text = "";
            txt_gianhap.Text = "";
            txt_giaban.Text = "";
            txt_solg.Text = "";
            txt_hsd.Text = "";
            txt_nsx.Text ="";
            txt_dvt.Text = "";
            int sc = dta1.Rows.Count;
            double SL = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                SL++;
            }
            lbl_kq.Text = SL.ToString() + " SP";
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from sanpham where tensp like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mancc()
        {

            string load_mancc = "Select mancc, tenncc from nhacungcap";       
            chuoiketnoi.xulycbx(load_mancc, txt_mancc);
            txt_mancc.DisplayMember = "tenncc";
            txt_mancc.ValueMember = "mancc";
            
        }
        private void sanpham_Load(object sender, EventArgs e)
        {
            txtNguoiNhap.Text = lb_quyen.Text;

            txtNguoiNhap.ReadOnly = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_masp.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tensp.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_mancc.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_gianhap.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_giaban.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            txt_solg.Text = dta1.Rows[curow].Cells[5].Value.ToString();
            txt_hsd.Text = dta1.Rows[curow].Cells[6].Value.ToString();
            txt_nsx.Text = dta1.Rows[curow].Cells[7].Value.ToString();
            txt_dvt.Text = dta1.Rows[curow].Cells[8].Value.ToString();
            txtNguoiNhap.Text = dta1.Rows[curow].Cells[9].Value.ToString();
            txt_masp.Enabled = true;
            btn_them.Enabled = false;
            bnt_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (
            txt_tensp.Text == "" ||
            txt_mancc.Text == "" ||
            txt_gianhap.Text == "" ||
            txt_giaban.Text == "" ||
            txt_solg.Text == "" ||
            txt_hsd.Text == "" ||
            txt_nsx.Text == "" ||
            txt_dvt.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into sanpham values(N'" + txt_tensp.Text + "',N'" + txt_mancc.SelectedValue + "','" + txt_gianhap.Text + "','" + txt_giaban.Text + "','" + txt_solg.Text + "','" + txt_hsd.Value + "',N'" + txt_nsx.Text + "',N'" + txt_dvt.Text + "',N'" + txtNguoiNhap.Text + "')";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void bnt_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update sanpham set tensp = N'" + txt_tensp.Text + "',mancc = N'" + txt_mancc.SelectedValue + "',gianhap = '" + txt_gianhap.Text + "',giaban = '" + txt_giaban.Text + "',solg = '" + txt_solg.Text + "',hsd = '" + txt_hsd.Value + "',noisx = N'" + txt_nsx.Text + "',donvitinh = N'" + txt_dvt.Text + "',nguoinhap= N'" + txtNguoiNhap.Text + "' where masp='"+txt_masp.Text+"'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from sanpham where masp= '" + txt_masp.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
           
                string duongdan = "";
                String tenfile = "ThongTinSanPham";
                XuatExecl.export_phieu(dta1, duongdan, tenfile, lbl_kq.Text);
                MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);       
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_solg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void lbl_kq_Click(object sender, EventArgs e)
        {

        }

        private void txt_mancc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
