using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhangluuniem
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "MenuNhanVien":
                    F_NhanVien f_nhanvien = new F_NhanVien();
                    frm = f_nhanvien;
                    break;
                case "MenuKhachHang":
                    F_KhachHang f_KhachHang = new F_KhachHang();
                    frm = f_KhachHang;
                    break;
                
                case "MenuHangHoa":
                    F_HangHoa f_hanghoa = new F_HangHoa();
                    frm = f_hanghoa;
                    break;
                case "MenuHoaDon":
                    F_HoaDon f_HoaDon = new F_HoaDon();
                    frm = f_HoaDon;
                    break;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront(); 
        }

        private void toolStripMenuItem3_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "MenuHoaDonBan":
                    F_HoaDonBan f_hoadonban = new F_HoaDonBan();
                    frm = f_hoadonban;
                    break;
                case "MenuHoadonchitiet":
                    F_HoaDon f_hoadon = new F_HoaDon();
                    frm = f_hoadon;
                    break;

            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();
        }

        private void toolStripMenuItem4_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "MenuTKNV":
                    F_Thongketheonhanvien f_Thongketheonhanvien = new F_Thongketheonhanvien();
                    frm = f_Thongketheonhanvien;
                    break;
                case "MenuTKDH":
                    F_Thongketheodonhang f_Thongketheodonhang = new F_Thongketheodonhang();
                    frm = f_Thongketheodonhang;
                    break;

            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();
        }

        private void MenuKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
