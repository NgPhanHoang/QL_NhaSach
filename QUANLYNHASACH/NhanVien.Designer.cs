
namespace QUANLYNHASACH
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lst_nhanvien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.text_tk = new System.Windows.Forms.TextBox();
            this.text_SDT = new System.Windows.Forms.TextBox();
            this.text_hoten = new System.Windows.Forms.TextBox();
            this.text_cccd = new System.Windows.Forms.TextBox();
            this.combo_gioiTinh = new System.Windows.Forms.ComboBox();
            this.text_mk = new System.Windows.Forms.TextBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lst_nhanvien
            // 
            this.lst_nhanvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lst_nhanvien.HideSelection = false;
            this.lst_nhanvien.Location = new System.Drawing.Point(15, 218);
            this.lst_nhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_nhanvien.Name = "lst_nhanvien";
            this.lst_nhanvien.Size = new System.Drawing.Size(958, 290);
            this.lst_nhanvien.TabIndex = 6;
            this.lst_nhanvien.UseCompatibleStateImageBehavior = false;
            this.lst_nhanvien.View = System.Windows.Forms.View.Details;
            this.lst_nhanvien.SelectedIndexChanged += new System.EventHandler(this.lst_nhanvien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Tài khoản";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Họ và tên";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "CCCD";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "SDT";
            this.columnHeader5.Width = 162;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Giới tính";
            this.columnHeader6.Width = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F);
            this.label2.Location = new System.Drawing.Point(254, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "THÔNG TIN NHÂN VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(203, 148);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(140, 63);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(379, 148);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(126, 64);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(569, 148);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(119, 64);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // text_tk
            // 
            this.text_tk.Location = new System.Drawing.Point(261, 54);
            this.text_tk.Name = "text_tk";
            this.text_tk.Size = new System.Drawing.Size(162, 26);
            this.text_tk.TabIndex = 11;
            // 
            // text_SDT
            // 
            this.text_SDT.Location = new System.Drawing.Point(526, 107);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.Size = new System.Drawing.Size(138, 26);
            this.text_SDT.TabIndex = 13;
            // 
            // text_hoten
            // 
            this.text_hoten.Location = new System.Drawing.Point(50, 54);
            this.text_hoten.Name = "text_hoten";
            this.text_hoten.Size = new System.Drawing.Size(159, 26);
            this.text_hoten.TabIndex = 14;
            // 
            // text_cccd
            // 
            this.text_cccd.Location = new System.Drawing.Point(509, 64);
            this.text_cccd.Name = "text_cccd";
            this.text_cccd.Size = new System.Drawing.Size(155, 26);
            this.text_cccd.TabIndex = 15;
            // 
            // combo_gioiTinh
            // 
            this.combo_gioiTinh.FormattingEnabled = true;
            this.combo_gioiTinh.Location = new System.Drawing.Point(726, 64);
            this.combo_gioiTinh.Name = "combo_gioiTinh";
            this.combo_gioiTinh.Size = new System.Drawing.Size(121, 28);
            this.combo_gioiTinh.TabIndex = 16;
            // 
            // text_mk
            // 
            this.text_mk.Location = new System.Drawing.Point(268, 105);
            this.text_mk.Name = "text_mk";
            this.text_mk.Size = new System.Drawing.Size(155, 26);
            this.text_mk.TabIndex = 17;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "Mật khẩu";
            this.columnHeader7.Width = 108;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 571);
            this.Controls.Add(this.text_mk);
            this.Controls.Add(this.combo_gioiTinh);
            this.Controls.Add(this.text_cccd);
            this.Controls.Add(this.text_hoten);
            this.Controls.Add(this.text_SDT);
            this.Controls.Add(this.text_tk);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_nhanvien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_nhanvien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox text_tk;
        private System.Windows.Forms.TextBox text_SDT;
        private System.Windows.Forms.TextBox text_hoten;
        private System.Windows.Forms.TextBox text_cccd;
        private System.Windows.Forms.ComboBox combo_gioiTinh;
        private System.Windows.Forms.TextBox text_mk;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}