﻿
namespace QUANLYNHASACH
{
    partial class KhoSach
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
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.lst_sach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbb_theloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_namxb = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_tacgia = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // txt_masach
            // 
            this.txt_masach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masach.Location = new System.Drawing.Point(124, 25);
            this.txt_masach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(152, 33);
            this.txt_masach.TabIndex = 2;
            // 
            // lst_sach
            // 
            this.lst_sach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lst_sach.HideSelection = false;
            this.lst_sach.Location = new System.Drawing.Point(18, 322);
            this.lst_sach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_sach.Name = "lst_sach";
            this.lst_sach.Size = new System.Drawing.Size(943, 336);
            this.lst_sach.TabIndex = 3;
            this.lst_sach.UseCompatibleStateImageBehavior = false;
            this.lst_sach.View = System.Windows.Forms.View.Details;
            this.lst_sach.SelectedIndexChanged += new System.EventHandler(this.lst_sach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã TG";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã TL";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Năm XB";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá nhập";
            this.columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            // 
            // cbb_theloai
            // 
            this.cbb_theloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_theloai.FormattingEnabled = true;
            this.cbb_theloai.Location = new System.Drawing.Point(430, 94);
            this.cbb_theloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_theloai.Name = "cbb_theloai";
            this.cbb_theloai.Size = new System.Drawing.Size(180, 37);
            this.cbb_theloai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm xuất bản";
            // 
            // txt_namxb
            // 
            this.txt_namxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namxb.Location = new System.Drawing.Point(168, 94);
            this.txt_namxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_namxb.Name = "txt_namxb";
            this.txt_namxb.Size = new System.Drawing.Size(152, 33);
            this.txt_namxb.TabIndex = 6;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(400, 25);
            this.txt_tensach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(204, 33);
            this.txt_tensach.TabIndex = 7;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.Location = new System.Drawing.Point(732, 25);
            this.txt_gianhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(169, 33);
            this.txt_gianhap.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tác giả";
            // 
            // cbb_tacgia
            // 
            this.cbb_tacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tacgia.FormattingEnabled = true;
            this.cbb_tacgia.Location = new System.Drawing.Point(722, 94);
            this.cbb_tacgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_tacgia.Name = "cbb_tacgia";
            this.cbb_tacgia.Size = new System.Drawing.Size(180, 37);
            this.cbb_tacgia.TabIndex = 13;
            this.cbb_tacgia.SelectedIndexChanged += new System.EventHandler(this.cbb_tacgia_SelectedIndexChanged);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(86, 149);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(148, 26);
            this.txt_soluong.TabIndex = 16;
            this.txt_soluong.Text = "0";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QUANLYNHASACH.Properties.Resources.icons8_edit_483;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(627, 200);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(140, 77);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QUANLYNHASACH.Properties.Resources.icons8_cancel_482;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(400, 200);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(148, 77);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QUANLYNHASACH.Properties.Resources.icons8_add_483;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(172, 200);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 77);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // KhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 678);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.cbb_tacgia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.txt_namxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_theloai);
            this.Controls.Add(this.lst_sach);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_them);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KhoSach";
            this.Text = "KhoSach";
            this.Load += new System.EventHandler(this.KhoSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.ListView lst_sach;
        private System.Windows.Forms.ComboBox cbb_theloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namxb;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_tacgia;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}