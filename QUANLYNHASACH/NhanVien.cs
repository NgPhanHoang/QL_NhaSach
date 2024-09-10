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

namespace QUANLYNHASACH
{
    public partial class NhanVien : Form
    {
        SqlConnection connsql;
        ConnSQL connect = new ConnSQL();
        public NhanVien()
        {
            InitializeComponent();
            connsql = connect.KetNoiCSDL();
            //connsql = new SqlConnection(@"Data Source=DESKTOP-EROU1IR\SQLEXPRESS;Initial Catalog=QL_NHASACH;Integrated Security=True");
        }
        

        private void loadLop_lv()
        {
            connsql.Open();
            string selectString = "select * from NGUOIDUNG";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();
            int n = 1;
            while (rd.Read())
            {
                ListViewItem item;
                if (User.Role != 2)
                {
                    item = new ListViewItem(new[] { n.ToString(), rd["MATKHAU"].ToString(), rd["TAIKHOAN"].ToString(), rd["HOTEN"].ToString(), rd["CCCD"].ToString(), rd["SDT"].ToString(), rd["GIOITINH"].ToString() });
                }
                else
                {
                    item = new ListViewItem(new[] { n.ToString(), "******", rd["TAIKHOAN"].ToString(), rd["HOTEN"].ToString(), rd["CCCD"].ToString(), rd["SDT"].ToString(), rd["GIOITINH"].ToString() });
                }
                lst_nhanvien.Items.Add(item);
                n++;
            }
            connsql.Close();
            lst_nhanvien.FullRowSelect = true;
        }

        bool KT_KhoaChinh(string pma)
        {
            connsql.Open();
            string selectString = "SELECT * FROM NGUOIDUNG WHERE taikhoan = @pma";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            cmd.Parameters.AddWithValue("@pma", pma);
            SqlDataReader re = cmd.ExecuteReader();
            if (re.HasRows)
            {
                re.Close();
                connsql.Close();
                return false;
            }
            else
            {
                re.Close();
                connsql.Close();
                return true;
            }
        }

        private void load_cbb()
        {
            connsql.Open();
            DataSet ds = new DataSet();
            string strselect = "SELECT * FROM NGUOIDUNG";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "NGUOIDUNG");
            combo_gioiTinh.DataSource = ds.Tables[0];
            combo_gioiTinh.DisplayMember = "GIOITINH";
            combo_gioiTinh.ValueMember = "GIOITINH";
            connsql.Close();
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (text_tk.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + label1.Text);
                    text_tk.Focus();
                    return;
                }
                if (KT_KhoaChinh(text_tk.Text))
                {
                    if (connsql.State == ConnectionState.Closed)
                    {
                        connsql.Open();
                    }

                    string insertString = "INSERT INTO NGUOIDUNG VALUES(N'" + text_hoten.Text + "', '" + text_tk.Text + "', '" + text_mk.Text + "','" + text_cccd.Text + "' , '" + text_SDT.Text + "' , N'" + combo_gioiTinh.SelectedValue.ToString() + "', 2)";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    if (connsql.State == ConnectionState.Open)
                    {
                        connsql.Close();
                    }
                    lst_nhanvien.Items.Clear();
                    loadLop_lv();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Trùng tên tài khoản");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (text_tk.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + label1.Text);
                    text_tk.Focus();
                    return;
                }
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string deleteString = "DELETE FROM NGUOIDUNG WHERE TAIKHOAN = @taikhoan";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.Parameters.AddWithValue("@taikhoan", text_tk.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                lst_nhanvien.Items.Clear();
                loadLop_lv();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (text_tk.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập " + label1.Text);
                    text_tk.Focus();
                    return;
                }

                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string updateString = "UPDATE NGUOIDUNG SET HOTEN = @hoten, TAIKHOAN = @taikhoan, MATKHAU = @matkhau, CCCD = @cccd, SDT = @sdt, GIOITINH = @gioitinh, VaiTro = @vaitro WHERE TAIKHOAN = @taikhoan";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.Parameters.AddWithValue("@hoten", text_hoten.Text);
                cmd.Parameters.AddWithValue("@taikhoan", text_tk.Text);
                cmd.Parameters.AddWithValue("@matkhau", text_mk.Text);
                cmd.Parameters.AddWithValue("@cccd", text_cccd.Text);
                cmd.Parameters.AddWithValue("@sdt", text_SDT.Text);
                cmd.Parameters.AddWithValue("@gioitinh", combo_gioiTinh.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@vaitro", 2);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }

                lst_nhanvien.Items.Clear();
                loadLop_lv();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để sửa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load_cbb();
            loadLop_lv();
        }

        private void lst_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lst_nhanvien.FocusedItem;
            if (item != null)
            {
                text_hoten.Text = item.SubItems[3].Text;
                text_tk.Text = item.SubItems[2].Text;
                text_mk.Text = item.SubItems[1].Text;
                text_SDT.Text = item.SubItems[4].Text;
                text_cccd.Text = item.SubItems[5].Text;
                combo_gioiTinh.Text = item.SubItems[6].Text;
            }
        }




        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btn_them_Click(object sender, EventArgs e)
        {

        }

      
    }
}
