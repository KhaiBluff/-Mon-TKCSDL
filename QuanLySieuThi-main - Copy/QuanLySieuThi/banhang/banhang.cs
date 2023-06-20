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

namespace QuanLySieuThi.banhang
{
    public partial class banhang : Form
    {
        public int a = 0;
        public int y = 0;

        public string chuoi = "Select masp,tensp,donvitinh,solg,giaban from sanpham";

        public banhang()
        {
            InitializeComponent();
            Load_dta1();

        }

        private void banhang_Load(object sender, EventArgs e)
        {
            
        }

        public  void Load_dta1()
        {
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
        }



        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham where tensp like N'%" + txt_timkiem.Text + "%' ";
            chuoiketnoi.timkiem(load1, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
            string load2 = "Select masp,tensp,donvitinh,solg,giaban from sanpham where tensp like N'%" + txt_timkiem.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta2);
            dta2.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            dta2.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            dta2.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            dta2.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            dta2.Columns[4].HeaderText = "Giá bán"; db1.Columns[2].Width = 120;
        }

        private void db1_Click(object sender, EventArgs e)
        {//CurrentRow.Index Gia tri o hang hien tai
            int curow = db1.CurrentRow.Index;
            txt_masp.Text = db1.Rows[curow].Cells[0].Value.ToString();
            txt_tensp.Text = db1.Rows[curow].Cells[1].Value.ToString();
            txt_dangsp.Text = db1.Rows[curow].Cells[2].Value.ToString();
            txt_gia.Text = db1.Rows[curow].Cells[4].Value.ToString();
            txt_sptrongkho.Text = db1.Rows[curow].Cells[3].Value.ToString();
        }

        private void dta2_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Add.Enabled = false;
                txt_slgban.Enabled = false;
                btn_Xoa.Enabled = true;
                int curow = dta2.CurrentRow.Index;

                txt_masp.Text = dta2.Rows[curow].Cells[0].Value.ToString();
                txt_tensp.Text = dta2.Rows[curow].Cells[1].Value.ToString();
                txt_dangsp.Text = dta2.Rows[curow].Cells[2].Value.ToString();
                txt_gia.Text = dta2.Rows[curow].Cells[3].Value.ToString();
                txt_slgban.Text = dta2.Rows[curow].Cells[4].Value.ToString();
                y = int.Parse(txt_slgban.Text);

                string solg = "Select solg from sanpham where masp ='" + txt_masp.Text + "'";
                SqlDataReader rd3 = chuoiketnoi.showtext(solg);
                while (rd3.Read())
                {
                    a = int.Parse(rd3[0].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Trong ! ", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_dangsp.Text == "" || txt_gia.Text == "" || txt_masp.Text == "" || txt_tensp.Text == "" || txt_sptrongkho.Text == "" || txt_slgban.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(txt_gia.Text);
                int b = int.Parse(txt_slgban.Text);
                int d = int.Parse(txt_sptrongkho.Text);
                if (txt_chietKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiết khấu ! ", "Thông báo", MessageBoxButtons.OK);

                }
                else if (txt_slgban.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập So lg bán ! ", "Thông báo", MessageBoxButtons.OK);
                }

                else if (b > d)
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho không đủ để bán\nBạn hãy nhập thêm hàng", "Thông báo ", MessageBoxButtons.OK);

                }

                else
                {
                    int x = d - b;

                    int s = a * b;
                    int n = dta2.Rows.Add();
                    double thanhtien = 0;
                    
                    dta2.Rows[n].Cells[0].Value = txt_masp.Text;
                    dta2.Rows[n].Cells[1].Value = txt_tensp.Text;
                    dta2.Rows[n].Cells[2].Value = txt_dangsp.Text;
                    dta2.Rows[n].Cells[3].Value = txt_gia.Text;
                    dta2.Rows[n].Cells[4].Value = txt_slgban.Text;
                    dta2.Rows[n].Cells[5].Value = s.ToString();

                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {

                        thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                    }

                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double k =double.Parse( txt_gia.Text.ToString());
                    double m = thanhtien - thanhtien * g / 100;

                  


                    lb_tien.Text = m.ToString() + " VNĐ";
                    string sql1 = "Update sanpham set solg ='" + x.ToString() + "'   WHERE masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    chuoiketnoi.luu(sql1);
                    string load1 = "Select masp,tensp,donvitinh,solg,giaban from  sanpham where  masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    chuoiketnoi.Chuoiketnoi(load1, db1);
                    txt_dangsp.Text = "";
                    txt_gia.Text = "";
                    txt_masp.Text = "";
                    txt_tensp.Text = "";
                    txt_sptrongkho.Text = "";

                    txt_slgban.Text = "1";


                    Load_dta1();



                  
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {


                int h = a + y;
                string sql1 = "Update sanpham set Solg ='" + h.ToString() + "' WHERE masp ='" + txt_masp.Text + "'";
                chuoiketnoi.Execute(sql1);
                string load1 = "Select masp,tensp,donvitinh,solg,giaban from sanpham  where  masp ='" + txt_masp.Text + "' ";
                chuoiketnoi.Chuoiketnoi(load1, db1);
                int seleRow = dta2.CurrentCell.RowIndex;
                dta2.Rows.RemoveAt(seleRow);
                double thanhtien = 0;
                int sc = dta2.Rows.Count;
                txt_dangsp.Text = "";
                txt_gia.Text = "";
                txt_masp.Text = "";
                txt_tensp.Text = "";
                txt_sptrongkho.Text = "";

                txt_slgban.Text = "1";
                btn_Xoa.Enabled = false;

                for (int i = 0; i < sc - 1; i++)
                {

                    thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                }

                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien - thanhtien * g / 100;
                btn_Add.Enabled = true;
                txt_slgban.Enabled = true;
                btn_Xoa.Enabled = false;
              
                lb_tien.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa ! ", "Thông Báo", MessageBoxButtons.OK);
            }
            Load_dta1();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void TongTien_Click(object sender, EventArgs e)
        {
            try
            { 

                if(dta2.RowCount == 1)
                {
                    MessageBox.Show("Danh sách trống không thể xuất file!");
                }
                else { 
                    DateTime nagy = DateTime.Now;
                    string tim = nagy.ToString();
                    string randomNameFile = tim.Replace(" ", "_").Replace("/","-").Replace(":","-");
                    double thanhtien = 0;
                    string s = "";
                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {
                        s += dta2.Rows[i].Cells[1].Value.ToString() + " : " + dta2.Rows[i].Cells[4].Value.ToString() + ",  ";
                        thanhtien += double.Parse(dta2.Rows[i].Cells[5].Value.ToString());

                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien - thanhtien * g / 100;

                    string date = date1.Text.Trim();

                    string str1 = "Insert into chitietdonhang Values('" + s.ToString() + "','" + date + "','" + m.ToString() + "',N'" + lb_quyen.Text + "')";
                    chuoiketnoi.them_dl1(str1);

                    string duongdan = "";
                   
                    XuatExecl.nhapnhieu(dta2, duongdan, randomNameFile,lb_tien.Text, lb_Tile.Text, txt_chietKhau.Text);
                    MessageBox.Show("Thực hiện thành công ", "Thông báo ", MessageBoxButtons.OK);
                    dta2.Rows.Clear();
                                 
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_slgban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Dangnhap a = new Dangnhap();
                a.Show();
                this.Hide();
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dta2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_quyen_Click(object sender, EventArgs e)
        {

        }

        private void txt_chietKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
