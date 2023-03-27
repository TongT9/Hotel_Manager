namespace DoAnQuanLyKhachSan
{
    partial class FormChucVu
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
            this.BtThoat = new System.Windows.Forms.Button();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.cbmacv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btGhi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtThoat
            // 
            this.BtThoat.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.BtThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtThoat.Image = global::DoAnQuanLyKhachSan.Properties.Resources.no_entry_icon;
            this.BtThoat.Location = new System.Drawing.Point(430, 0);
            this.BtThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtThoat.Name = "BtThoat";
            this.BtThoat.Size = new System.Drawing.Size(110, 43);
            this.BtThoat.TabIndex = 21;
            this.BtThoat.Text = "Quay Về";
            this.BtThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtThoat.UseVisualStyleBackColor = true;
            this.BtThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // txttencv
            // 
            this.txttencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Location = new System.Drawing.Point(232, 85);
            this.txttencv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(164, 20);
            this.txttencv.TabIndex = 20;
            // 
            // cbmacv
            // 
            this.cbmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmacv.ForeColor = System.Drawing.Color.Maroon;
            this.cbmacv.FormattingEnabled = true;
            this.cbmacv.Location = new System.Drawing.Point(232, 48);
            this.cbmacv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmacv.Name = "cbmacv";
            this.cbmacv.Size = new System.Drawing.Size(164, 21);
            this.cbmacv.TabIndex = 19;
            this.cbmacv.SelectedIndexChanged += new System.EventHandler(this.cbmacv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(117, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Chức Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(123, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Chức Vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quản Lý Chức Vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnQuanLyKhachSan.Properties.Resources.rsz_tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(34, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btCapNhat
            // 
            this.btCapNhat.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCapNhat.Image = global::DoAnQuanLyKhachSan.Properties.Resources._0017_Pencil_and_Ruler_icon;
            this.btCapNhat.Location = new System.Drawing.Point(278, 120);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(118, 42);
            this.btCapNhat.TabIndex = 22;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = global::DoAnQuanLyKhachSan.Properties.Resources.delete_file_icon1;
            this.btXoa.Location = new System.Drawing.Point(409, 120);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(119, 42);
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btGhi
            // 
            this.btGhi.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.btGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGhi.Image = global::DoAnQuanLyKhachSan.Properties.Resources.Document_Write_icon;
            this.btGhi.Location = new System.Drawing.Point(145, 120);
            this.btGhi.Margin = new System.Windows.Forms.Padding(2);
            this.btGhi.Name = "btGhi";
            this.btGhi.Size = new System.Drawing.Size(119, 42);
            this.btGhi.TabIndex = 24;
            this.btGhi.Text = "Ghi ";
            this.btGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGhi.UseVisualStyleBackColor = true;
            this.btGhi.Click += new System.EventHandler(this.btGhi_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Image = global::DoAnQuanLyKhachSan.Properties.Resources.add_file_icon;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(16, 120);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 42);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 175);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtThoat);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btGhi);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txttencv);
            this.Controls.Add(this.cbmacv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChucVu";
            this.Load += new System.EventHandler(this.FormChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtThoat;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btGhi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.ComboBox cbmacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}