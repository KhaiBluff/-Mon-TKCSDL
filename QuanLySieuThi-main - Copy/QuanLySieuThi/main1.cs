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
    public partial class main1 : Form
    {
        public int i = -1;
        
        public main1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbform.Location = new Point(lbform.Location.X, lbform.Location.Y + i);
            if (lbform.Location.Y <= 30)
            {
                i = 1;
            }
            if (lbform.Location.Y >= 60) i = -1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap a = new Dangnhap();
            a.Show();
            this.Hide();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy b = new DangKy();
            b.Show();
            this.Hide();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult Thongbao;
            Thongbao = (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (Thongbao == DialogResult.Yes)
                this.Close();
        }

        private void main1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbsv_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbform_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
