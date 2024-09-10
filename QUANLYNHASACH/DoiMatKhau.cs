using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ...
using System.Data.SqlClient;

namespace QUANLYNHASACH
{
    public partial class DoiMatKhau : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();

        public DoiMatKhau()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
        }

        bool KT_TaiKhoan(string ma)
        {
            try
            {
                connsql.Open();
                string sql = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TAIKHOAN = @Taikhoan";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.Parameters.AddWithValue("@Taikhoan", ma);
                int count = (int)cmd.ExecuteScalar();
                connsql.Close();
                return count >= 1;
            }
            catch (Exception ex)
            {
                connsql.Close();
                return false;
            }
        }

        bool KT_MatKhau(string ma)
        {
            try
            {
                connsql.Open();
                string sql = "SELECT COUNT(*) FROM NGUOIDUNG WHERE MATKHAU = @Matkhau";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.Parameters.AddWithValue("@Matkhau", ma);
                int count = (int)cmd.ExecuteScalar();
                connsql.Close();
                return count >= 1;
            }
            catch (Exception ex)
            {
                connsql.Close();
                return false;
            }
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_tk.Text))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!");
                    return;
                }

                if (KT_TaiKhoan(txt_tk.Text))
                {
                    if (KT_MatKhau(txt_mk.Text))
                    {
                        if (txt_mkmoi.Text == txt_nhaplaimkmoi.Text)
                        {
                            connsql.Open();
                            string updatestring = "UPDATE NGUOIDUNG SET MATKHAU = @Matkhaumoi WHERE TAIKHOAN = @Taikhoan";
                            SqlCommand cmd = new SqlCommand(updatestring, connsql);
                            cmd.Parameters.AddWithValue("@Matkhaumoi", txt_mkmoi.Text);
                            cmd.Parameters.AddWithValue("@Taikhoan", txt_tk.Text);
                            cmd.ExecuteNonQuery();
                            connsql.Close();
                            MessageBox.Show("Đổi mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không khớp!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connsql.Close();
                this.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // Tạo một instance mới của form đăng nhập
            DangNhap formDangNhap = new DangNhap();

            // Hiển thị form đăng nhập
            formDangNhap.Show();

            // Đóng form hiện tại (DoiMatKhau)
            this.Close();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Tạo một instance mới của form đăng nhập
            //DangNhap formDangNhap = new DangNhap();

            //// Hiển thị form đăng nhập
            //formDangNhap.Show();

        }
    }
}