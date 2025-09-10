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

namespace Quanlybanhangluuniem
{
    public partial class F_Dangnhap : Form
    {
        public F_Dangnhap()
        {
            InitializeComponent();
        }

        private void id_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (id_matkhau.PasswordChar == '*')
            {
                id_matkhau.PasswordChar = '\0';
            }
            else
            {
                id_matkhau.PasswordChar = '*';
            }
        }
        connectData c = new connectData();
        private void id_dangnhap_Click(object sender, EventArgs e)
        {
          
                c.connect();
                string tk = id_taikhoan.Text;
                string mk = id_matkhau.Text;
                SqlCommand cmd = new SqlCommand("select * from TaiKhoan where Taikhoan = '" + tk + "' " +
                    "and Matkhau = '" + mk + "'", c.conn);
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (id_matkhau.Text == "" || id_taikhoan.Text == "")
                {
                    MessageBox.Show("Bạn điền tài khoản và mật khẩu để đăng nhâp", "Thông báo",
                        MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else if (reader.Read() == true)
                {
                    this.Hide();
                    F_main f_Main = new F_main();
                    f_Main.ShowDialog();
                    f_Main = null;
                    id_matkhau.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng? Vui lòng nhập lại tài khoản hoặc mật khẩu",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    id_matkhau.Text = "";
                }
            c.disconnect();
        }
           

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa? ", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void id_matkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
