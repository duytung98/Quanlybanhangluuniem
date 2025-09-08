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
    public partial class F_HangHoa : Form
    {
        
        void loaddata()
        {
            
            //command.CommandText = "select MaSp as N'Mã sản phẩm',TenSp as N'Tên sản phẩm',Dvt as N'Đơn vị tính',Soluong as N'Số lượng',Dongia as N'Đơn giá',Ghichu as N'Ghi chú' from SanPham";
           
        }
        public F_HangHoa()
        {
            InitializeComponent();
        }

        private void F_HangHoa_Load(object sender, EventArgs e)
        {
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
