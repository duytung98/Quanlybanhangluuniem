using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quanlybanhangluuniem
{
    public partial class F_NhanVien : Form
    {
        connectData c = new connectData();
        void loaddata()
        {
            dvg_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            c.connect();
            DataSet data = new DataSet();
            string query = "select MaNhanVien as N'Mã nhân viên',HoDemNV as N'Họ đệm',TenNV as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',SoDienThoai as N'Số điện thoại', GhiChu as N'Ghi chú' from NhanVien";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, c.conn);
            sqlData.Fill(data);
            dvg_nhanvien.DataSource = data.Tables[0];
            //command.CommandText = "select MaNhanVien as N'Mã nhân viên',HoDemNV as N'Họ đệm',TenNV as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',SoDienThoai as N'Số điện thoại', GhiChu as N'Ghi chú' from NhanVien";
            c.disconnect();
        }
        public F_NhanVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            double a;
            if (txt_manhanvien.Text == "" || txt_hodem.Text == "" || txt_tennv.Text == "" || txt_gioitinh.Text == "" || txt_dienthoai.Text == "" || txt_diachi.Text == ""
                || id_ngaysinh.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {                
                c.connect();
                DateTime ngaysinh = Convert.ToDateTime(id_ngaysinh.Text);
                string ngaysinhFormatted = ngaysinh.ToString("yyyy-MM-dd");
                string query = "insert into NhanVien(MaNhanVien,HoDemNV,TenNV,GioiTinh,NgaySinh,DiaChi,SoDienThoai,GhiChu) " +
                        "values ('" + txt_manhanvien.Text + "',N'" + txt_hodem.Text + "',N'" + txt_tennv.Text + "',N'" + txt_gioitinh.Text + "','" + ngaysinhFormatted
                        + "',N'" + txt_diachi.Text + "',N'" + txt_dienthoai.Text + "',N'" + txt_ghichu.Text + "')";
                bool kq = c.exeSQL(query);
                MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
                c.disconnect();
            }
        }

        private void F_NhanVien_Load(object sender, EventArgs e)
        {
           
            loaddata();
        }
        public void clear_form()
        {
            txt_manhanvien.Text = "";
            txt_hodem.Text = null;
            txt_tennv.Text = "";
            txt_gioitinh.Text = "";
            txt_dienthoai.Text = "";
            txt_diachi.Text = "";
            id_ngaysinh.Text = "";
            txt_manhanvien.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double a;
            if (txt_manhanvien.Text == "" || txt_hodem.Text == "" || txt_tennv.Text == "" || txt_gioitinh.Text == "" || txt_dienthoai.Text == "" || txt_diachi.Text == "" || id_ngaysinh.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!double.TryParse(this.txt_dienthoai.Text, out a))
            {
                MessageBox.Show("Điện thoại phải là số!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DateTime ngaysinh = Convert.ToDateTime(id_ngaysinh.Text);
                string ngaysinhFormatted = ngaysinh.ToString("yyyy-MM-dd");
                c.connect();
                
                string query = "update NhanVien set HoDemNV = N'" + txt_hodem.Text + "'," +
                    "TenNV = N'" + txt_tennv.Text + "',GioiTinh = N'" + txt_gioitinh.Text + "'," +
                    "NgaySinh = '" + ngaysinhFormatted + "',DiaChi = N'" + txt_diachi.Text + "'," +
                    "SoDienThoai = '" + txt_dienthoai.Text + "',GhiChu = N'" + txt_ghichu.Text + "' " +
                    "where MaNhanVien = '" + txt_manhanvien.Text + "'";
                bool kq = c.exeSQL(query);
                MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
              
            }
        }

        private void dvg_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dvg_nhanvien.CurrentRow.Index;
            txt_manhanvien.Text = dvg_nhanvien.Rows[i].Cells[0].Value.ToString();
            txt_hodem.Text = dvg_nhanvien.Rows[i].Cells[1].Value.ToString();
            txt_tennv.Text = dvg_nhanvien.Rows[i].Cells[2].Value.ToString();
            txt_gioitinh.Text = dvg_nhanvien.Rows[i].Cells[3].Value.ToString();
            id_ngaysinh.Text = dvg_nhanvien.Rows[i].Cells[4].Value.ToString();
            txt_diachi.Text = dvg_nhanvien.Rows[i].Cells[5].Value.ToString();
            txt_dienthoai.Text = dvg_nhanvien.Rows[i].Cells[6].Value.ToString();
            txt_ghichu.Text = dvg_nhanvien.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            c.connect();
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa? ", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {

                string query = "delete from NhanVien where MaNhanVien = '" + txt_manhanvien.Text + "'";
                bool kq1 = c.exeSQL(query);
                MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK);
                loaddata();
                clear_form();
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Length > 0)
            {
                c.connect();
                DataSet data = new DataSet();
                string query = "select MaNhanVien as N'Mã nhân viên',HoDemNV as N'Họ đệm',TenNV as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',SoDienThoai as N'Số điện thoại', GhiChu as N'Ghi chú' from NhanVien where MaNhanVien like '%" + txt_timkiem.Text + "%' or TenNV like '%" + txt_timkiem.Text + "%' or HoDemNV like '%" + txt_timkiem.Text + "%'";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, c.conn);
                sqlData.Fill(data);
                dvg_nhanvien.DataSource = data.Tables[0];
                
            }
            else
            {
                F_NhanVien_Load(sender, e);
            }
        }
    }
}
