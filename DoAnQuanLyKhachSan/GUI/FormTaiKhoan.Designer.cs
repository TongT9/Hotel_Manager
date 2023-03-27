namespace DoAnQuanLyKhachSan
{
    partial class FormTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.listdanhsach = new System.Windows.Forms.ListBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.cbtaikhoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btquayve = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcapnhat = new System.Windows.Forms.Button();
            this.btghi = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listdanhsach
            // 
            this.listdanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listdanhsach.FormattingEnabled = true;
            this.listdanhsach.Location = new System.Drawing.Point(14, 94);
            this.listdanhsach.Name = "listdanhsach";
            this.listdanhsach.Size = new System.Drawing.Size(200, 186);
            this.listdanhsach.TabIndex = 33;
            this.listdanhsach.SelectedIndexChanged += new System.EventHandler(this.listdanhsach_SelectedIndexChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(427, 172);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(197, 20);
            this.txtmatkhau.TabIndex = 26;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdangnhap.Location = new System.Drawing.Point(427, 136);
            this.txtdangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(197, 20);
            this.txtdangnhap.TabIndex = 27;
            // 
            // cbtaikhoan
            // 
            this.cbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtaikhoan.ForeColor = System.Drawing.Color.Maroon;
            this.cbtaikhoan.FormattingEnabled = true;
            this.cbtaikhoan.Location = new System.Drawing.Point(427, 100);
            this.cbtaikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtaikhoan.Name = "cbtaikhoan";
            this.cbtaikhoan.Size = new System.Drawing.Size(197, 21);
            this.cbtaikhoan.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnQuanLyKhachSan.Properties.Resources.rsz_images_21;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btquayve
            // 
            this.btquayve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btquayve.BackgroundImage")));
            this.btquayve.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btquayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquayve.Image = global::DoAnQuanLyKhachSan.Properties.Resources.no_entry_icon;
            this.btquayve.Location = new System.Drawing.Point(646, -3);
            this.btquayve.Margin = new System.Windows.Forms.Padding(2);
            this.btquayve.Name = "btquayve";
            this.btquayve.Size = new System.Drawing.Size(110, 41);
            this.btquayve.TabIndex = 32;
            this.btquayve.Text = "Quay Lại";
            this.btquayve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btquayve.UseVisualStyleBackColor = true;
            this.btquayve.Click += new System.EventHandler(this.btquayve_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btxoa.BackgroundImage")));
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = global::DoAnQuanLyKhachSan.Properties.Resources.delete_file_icon;
            this.btxoa.Location = new System.Drawing.Point(625, 218);
            this.btxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(113, 40);
            this.btxoa.TabIndex = 28;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcapnhat.BackgroundImage")));
            this.btcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhat.Image = global::DoAnQuanLyKhachSan.Properties.Resources._0017_Pencil_and_Ruler_icon;
            this.btcapnhat.Location = new System.Drawing.Point(491, 218);
            this.btcapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(113, 40);
            this.btcapnhat.TabIndex = 29;
            this.btcapnhat.Text = "Cập Nhật";
            this.btcapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btcapnhat.UseVisualStyleBackColor = true;
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // btghi
            // 
            this.btghi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btghi.BackgroundImage")));
            this.btghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btghi.Image = global::DoAnQuanLyKhachSan.Properties.Resources.Document_Write_icon;
            this.btghi.Location = new System.Drawing.Point(364, 218);
            this.btghi.Margin = new System.Windows.Forms.Padding(2);
            this.btghi.Name = "btghi";
            this.btghi.Size = new System.Drawing.Size(113, 40);
            this.btghi.TabIndex = 30;
            this.btghi.Text = "Ghi";
            this.btghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btghi.UseVisualStyleBackColor = true;
            this.btghi.Click += new System.EventHandler(this.btghi_Click);
            // 
            // btthem
            // 
            this.btthem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btthem.BackgroundImage")));
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Image = global::DoAnQuanLyKhachSan.Properties.Resources.add_file_icon;
            this.btthem.Location = new System.Drawing.Point(235, 218);
            this.btthem.Margin = new System.Windows.Forms.Padding(2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(113, 40);
            this.btthem.TabIndex = 31;
            this.btthem.Text = "Thêm";
            this.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listdanhsach);
            this.Controls.Add(this.btquayve);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.btghi);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdangnhap);
            this.Controls.Add(this.cbtaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listdanhsach;
        private System.Windows.Forms.Button btquayve;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btcapnhat;
        private System.Windows.Forms.Button btghi;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.ComboBox cbtaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}