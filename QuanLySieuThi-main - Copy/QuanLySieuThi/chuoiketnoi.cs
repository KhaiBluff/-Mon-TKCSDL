using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLySieuThi
{
    class chuoiketnoi
    {
        //khai bao chuoi ket noi
        public static string sqlcon = @"Data Source=msi;Initial Catalog=QuanLysieuthi;Integrated Security=True";
        public static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return chuoiketnoi.mycon; }
            set { chuoiketnoi.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;

        public static SqlCommandBuilder bd;//giúp CẬP NHẬT các bảng SQL Server
        public static SqlDataReader showtext(string sql)
        {
            SqlDataReader read = null;
            try
            {
                //mo ket noi
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                read = com.ExecuteReader();

            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }
        // ham ket noi
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {


                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }



        //ham xu ly tim kiem
        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;


        }


        public static void dodata(string chuoi, DataTable dt)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
        }

	// ham xu ly thêm
        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+""+ex);
            }

        }


        public static void them_dl1(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                
                mycon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("them loi r cau "+ e);
            }

        }

        public static void Them(string select, String tk, String pass, String sql1, DataGridView dt)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();
            
            if (i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql1, mycon);
                    ad = new SqlDataAdapter(com);
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    dt.DataSource = tb;
                    MessageBox.Show("Them Thanh công !", "Thong báo ");
                    mycon.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Tài khoản đã tồn tại"+ E, "Thông báo");
                }
            }
        }
        public static void Themdangky(string select, String tk, String pass, String sql1)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    luu(sql1);


                    if (MessageBox.Show("Thêm Thành công !Bạn có muốn đăng nhập luôn không ?", "Thông Báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Dangnhap dt = new Dangnhap();
                       dt.Show();
                        DangKy a = new DangKy();
                        a.Close();
                    }
                    mycon.Close();
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }



        

        public static void Xoa(string sql)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Tài khoản bạn sửa trùng với tài khoản đã có ! Vui lòng ktra lại ");
            }

        }


        public static void luu(string sql)
        {
            //ExecuteNonQuery thực hiện các truy vấn không trả về bất kỳ dữ liệu nào
            //thực thi các câu lệnh sql như cập nhật, chèn, xóa

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        public static void Execute(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public static void Execute1(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
       
    }
}

          