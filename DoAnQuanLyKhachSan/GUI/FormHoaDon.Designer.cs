namespace DoAnQuanLyKhachSan
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHoaDon = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTenBooking = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTenPhong = new System.Windows.Forms.ComboBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtSoTienDatTruoc = new System.Windows.Forms.TextBox();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvhoadon = new System.Windows.Forms.DataGridView();
            this.bntxuatexcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btIn = new System.Windows.Forms.Button();
            this.BtQuayVe = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 250);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Mã Hóa Đơn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDon.FormattingEnabled = true;
            this.lbHoaDon.Location = new System.Drawing.Point(6, 19);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(172, 212);
            this.lbHoaDon.TabIndex = 5;
            this.lbHoaDon.SelectedIndexChanged += new System.EventHandler(this.lbHoaDon_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTenBooking);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbTenLoaiPhong);
            this.groupBox1.Controls.Add(this.cbTenPhong);
            this.groupBox1.Controls.Add(this.cbTenKH);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.txtSoTienDatTruoc);
            this.groupBox1.Controls.Add(this.dtpNgayThanhToan);
            this.groupBox1.Controls.Add(this.cbTenNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(200, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 247);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết Của Hóa Đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbTenBooking
            // 
            this.cbTenBooking.FormattingEnabled = true;
            this.cbTenBooking.Location = new System.Drawing.Point(451, 150);
            this.cbTenBooking.Name = "cbTenBooking";
            this.cbTenBooking.Size = new System.Drawing.Size(176, 21);
            this.cbTenBooking.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tên Booking:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tổng Tiền:";
            // 
            // cbTenLoaiPhong
            // 
            this.cbTenLoaiPhong.FormattingEnabled = true;
            this.cbTenLoaiPhong.Location = new System.Drawing.Point(451, 112);
            this.cbTenLoaiPhong.Name = "cbTenLoaiPhong";
            this.cbTenLoaiPhong.Size = new System.Drawing.Size(176, 21);
            this.cbTenLoaiPhong.TabIndex = 19;
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.FormattingEnabled = true;
            this.cbTenPhong.Location = new System.Drawing.Point(451, 77);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(176, 21);
            this.cbTenPhong.TabIndex = 18;
            // 
            // cbTenKH
            // 
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(451, 43);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(176, 21);
            this.cbTenKH.TabIndex = 17;
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(451, 188);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(176, 20);
            this.txtTongTien.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên Loại Phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên Phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đơn Vị:";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(139, 192);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(176, 20);
            this.txtDonVi.TabIndex = 9;
            // 
            // txtSoTienDatTruoc
            // 
            this.txtSoTienDatTruoc.Location = new System.Drawing.Point(139, 155);
            this.txtSoTienDatTruoc.Name = "txtSoTienDatTruoc";
            this.txtSoTienDatTruoc.Size = new System.Drawing.Size(176, 20);
            this.txtSoTienDatTruoc.TabIndex = 8;
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(139, 113);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(176, 20);
            this.dtpNgayThanhToan.TabIndex = 7;
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(139, 75);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(176, 21);
            this.cbTenNV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Tiền Đặt Trước:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(139, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(176, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Thanh Toán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Hóa Đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(230, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgvhoadon
            // 
            this.dtgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhoadon.Location = new System.Drawing.Point(14, 343);
            this.dtgvhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvhoadon.Name = "dtgvhoadon";
            this.dtgvhoadon.RowHeadersWidth = 51;
            this.dtgvhoadon.RowTemplate.Height = 24;
            this.dtgvhoadon.Size = new System.Drawing.Size(819, 178);
            this.dtgvhoadon.TabIndex = 29;
            this.dtgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhoadon_CellClick);
            this.dtgvhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhoadon_CellContentClick);
            // 
            // bntxuatexcel
            // 
            this.bntxuatexcel.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.bntxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntxuatexcel.Image = global::DoAnQuanLyKhachSan.Properties.Resources.checklist_icon1;
            this.bntxuatexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntxuatexcel.Location = new System.Drawing.Point(433, 587);
            this.bntxuatexcel.Margin = new System.Windows.Forms.Padding(2);
            this.bntxuatexcel.Name = "bntxuatexcel";
            this.bntxuatexcel.Size = new System.Drawing.Size(247, 45);
            this.bntxuatexcel.TabIndex = 30;
            this.bntxuatexcel.Text = "Thống kê";
            this.bntxuatexcel.UseVisualStyleBackColor = true;
            this.bntxuatexcel.Click += new System.EventHandler(this.bntxuatexcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnQuanLyKhachSan.Properties.Resources.rsz_images_1;
            this.pictureBox1.Location = new System.Drawing.Point(54, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 81);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btIn
            // 
            this.btIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIn.BackgroundImage")));
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Image = global::DoAnQuanLyKhachSan.Properties.Resources.checklist_icon;
            this.btIn.Location = new System.Drawing.Point(161, 587);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(249, 44);
            this.btIn.TabIndex = 27;
            this.btIn.Text = "In Hóa Đơn";
            this.btIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // BtQuayVe
            // 
            this.BtQuayVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtQuayVe.BackgroundImage")));
            this.BtQuayVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuayVe.Image = global::DoAnQuanLyKhachSan.Properties.Resources.no_entry_icon;
            this.BtQuayVe.Location = new System.Drawing.Point(736, 0);
            this.BtQuayVe.Name = "BtQuayVe";
            this.BtQuayVe.Size = new System.Drawing.Size(107, 43);
            this.BtQuayVe.TabIndex = 21;
            this.BtQuayVe.Text = "Quay Về";
            this.BtQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtQuayVe.UseVisualStyleBackColor = true;
            this.BtQuayVe.Click += new System.EventHandler(this.BtQuayVe_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::DoAnQuanLyKhachSan.Properties.Resources.delete_file_icon1;
            this.btXoa.Location = new System.Drawing.Point(565, 526);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(115, 41);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCapNhat.BackgroundImage")));
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Image = global::DoAnQuanLyKhachSan.Properties.Resources._0017_Pencil_and_Ruler_icon;
            this.btCapNhat.Location = new System.Drawing.Point(433, 526);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(115, 41);
            this.btCapNhat.TabIndex = 23;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btGhi
            // 
            this.btGhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGhi.BackgroundImage")));
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhi.Image = global::DoAnQuanLyKhachSan.Properties.Resources.Document_Write_icon;
            this.btGhi.Location = new System.Drawing.Point(299, 526);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(115, 41);
            this.btGhi.TabIndex = 24;
            this.btGhi.Text = "Ghi";
            this.btGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::DoAnQuanLyKhachSan.Properties.Resources.add_file_icon;
            this.btThem.Location = new System.Drawing.Point(163, 526);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(115, 42);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 643);
            this.Controls.Add(this.bntxuatexcel);
            this.Controls.Add(this.dtgvhoadon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtQuayVe);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbHoaDon;
        private System.Windows.Forms.Button BtQuayVe;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTienDatTruoc;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvhoadon;
        private System.Windows.Forms.Button bntxuatexcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTenLoaiPhong;
        private System.Windows.Forms.ComboBox cbTenPhong;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbTenBooking;
        private System.Windows.Forms.Label label11;
    }
}