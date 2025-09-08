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
    public partial class F_KhachHang : Form
    {

        void loaddata()
        {

            //command.CommandText = "select MaKh as N'Mã khách hàng',HoDem as N'Họ đệm',Ten as N'Tên khách hàng',Email as N'Email',DiaChi as N'Địa chỉ',SDT as N'Số điện thoại', GhiChu as N'Ghi chú' from KhachHang";
        } 
        public F_KhachHang()
        {
            InitializeComponent();
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
