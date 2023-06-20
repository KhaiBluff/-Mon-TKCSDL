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
    public partial class DangKy : Form
    {
        
        public DangKy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_tk.Text.ToString().Trim();
            string password = txt_mk.Text.ToString().Trim();
            string remk = txt_remk.Text.ToString().Trim();
            string fullname = txtFullname.Text.ToString().Trim();
           
            string isAdmin = cbbRole.SelectedIndex.ToString();
           
            if (username == "" || password == "" || remk == "" || fullname=="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string sql = "Select count(*) from taikhoan where username ='" + username + "'";

                
                
                string sql1 = "Insert into taikhoan (username,password,fullname,isAdmin) values('" + username + "','" + password + "','" + fullname + "','" + isAdmin + "')";
                if (password == remk)
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        
                        chuoiketnoi.Themdangky(sql, username, password, sql1);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                main1 a = new main1();
                a.Show();
                this.Close();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            cbbRole.SelectedIndex = 0;
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
