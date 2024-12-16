namespace de_01
{
    partial class frmSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btkluu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lvSinhvien = new System.Windows.Forms.ListView();
            this.MaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.txtHotenSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(189, 119);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 7;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin ",
            "Kế toán",
            "Kế Toán"});
            this.cbLop.Location = new System.Drawing.Point(500, 119);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 6;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(500, 48);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(100, 22);
            this.txtHotenSV.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(189, 49);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp Học ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(223, 261);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(561, 261);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(131, 261);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.Tim_Click);
            this.btnTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button3_KeyDown);
            // 
            // btkluu
            // 
            this.btkluu.Location = new System.Drawing.Point(683, 261);
            this.btkluu.Name = "btkluu";
            this.btkluu.Size = new System.Drawing.Size(75, 23);
            this.btkluu.TabIndex = 4;
            this.btkluu.Text = "K.luu";
            this.btkluu.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(451, 261);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(334, 260);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(793, 261);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(13, 261);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(100, 22);
            this.txtTimkiem.TabIndex = 9;
            // 
            // lvSinhvien
            // 
            this.lvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.HoTenSV,
            this.NgaySinh,
            this.Lop});
            this.lvSinhvien.HideSelection = false;
            this.lvSinhvien.Location = new System.Drawing.Point(152, 325);
            this.lvSinhvien.Name = "lvSinhvien";
            this.lvSinhvien.Size = new System.Drawing.Size(653, 216);
            this.lvSinhvien.TabIndex = 10;
            this.lvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lvSinhvien.View = System.Windows.Forms.View.Details;
            this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
            // 
            // MaSV
            // 
            this.MaSV.Text = "MaSV";
            this.MaSV.Width = 149;
            // 
            // HoTenSV
            // 
            this.HoTenSV.Text = "Ho Va Ten ";
            this.HoTenSV.Width = 156;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngay Sinh ";
            this.NgaySinh.Width = 145;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 130;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 571);
            this.Controls.Add(this.lvSinhvien);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btkluu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSinhVien";
            this.Text = "Danh Sach Sinh Vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btkluu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ListView lvSinhvien;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader HoTenSV;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Lop;
    }
}

