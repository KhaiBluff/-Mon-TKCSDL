using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }

        public void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banhang.banhang a = new banhang.banhang();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();
        }

        public void tàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        public void mn_tkquanly_Click(object sender, EventArgs e)
        {
           
        }

        private void mn_admin_Click(object sender, EventArgs e)
        {
  
        }

      

        private void mn_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Dangnhap a = new Dangnhap();
                a.Show();
                this.Hide();
            }
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            quanly.nhacungcap a = new quanly.nhacungcap();
            a.Show();
        }

        private void ql_khachhang_Click(object sender, EventArgs e)
        {
           
        }

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void bh_phieunhap_Click(object sender, EventArgs e)
        {
           
        }

        private void bh_nhapnhieu_Click(object sender, EventArgs e)
        {
           
        }

        private void bh_xuatle_Click(object sender, EventArgs e)
        {
           
        }

        private void bh_bannhieu_Click(object sender, EventArgs e)
        {
            banhang.banhang a = new banhang.banhang();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void main2_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
            quanly.sanpham a = new quanly.sanpham();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();        
        }

        private void ql_phieunhap_Click(object sender, EventArgs e)
        {
           
        }

        private void ql_phieuxuat_Click(object sender, EventArgs e)
        {
          
        }

        private void hỗTrợToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mn_thongtin_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanly.frmThongTinDonHang ql = new quanly.frmThongTinDonHang();
            ql.Show();
        }

        private void mn_hethong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                main1 a = new main1();
                a.Show();
                this.Hide();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lb_quyen_Click(object sender, EventArgs e)
        {

        }
    }
}
