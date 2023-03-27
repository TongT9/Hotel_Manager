
namespace DoAnQuanLyKhachSan.Thống_Kê
{
    partial class frm_thongkedoanhthu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbchung = new System.Windows.Forms.ComboBox();
            this.rdbtdv = new System.Windows.Forms.RadioButton();
            this.rdbtall = new System.Windows.Forms.RadioButton();
            this.rdbtphong = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btquayve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(152, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbchung);
            this.panel1.Controls.Add(this.rdbtdv);
            this.panel1.Controls.Add(this.rdbtall);
            this.panel1.Controls.Add(this.rdbtphong);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 112);
            this.panel1.TabIndex = 1;
            // 
            // cbchung
            // 
            this.cbchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchung.FormattingEnabled = true;
            this.cbchung.Location = new System.Drawing.Point(393, 78);
            this.cbchung.Margin = new System.Windows.Forms.Padding(2);
            this.cbchung.Name = "cbchung";
            this.cbchung.Size = new System.Drawing.Size(151, 21);
            this.cbchung.TabIndex = 7;
            // 
            // rdbtdv
            // 
            this.rdbtdv.AutoSize = true;
            this.rdbtdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtdv.Location = new System.Drawing.Point(222, 79);
            this.rdbtdv.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtdv.Name = "rdbtdv";
            this.rdbtdv.Size = new System.Drawing.Size(81, 20);
            this.rdbtdv.TabIndex = 4;
            this.rdbtdv.TabStop = true;
            this.rdbtdv.Text = "Dịch vụ:";
            this.rdbtdv.UseVisualStyleBackColor = true;
            this.rdbtdv.CheckedChanged += new System.EventHandler(this.rdbtdv_CheckedChanged);
            // 
            // rdbtall
            // 
            this.rdbtall.AutoSize = true;
            this.rdbtall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtall.Location = new System.Drawing.Point(26, 79);
            this.rdbtall.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtall.Name = "rdbtall";
            this.rdbtall.Size = new System.Drawing.Size(70, 20);
            this.rdbtall.TabIndex = 5;
            this.rdbtall.TabStop = true;
            this.rdbtall.Text = "Tat ca";
            this.rdbtall.UseVisualStyleBackColor = true;
            this.rdbtall.CheckedChanged += new System.EventHandler(this.rdbtall_CheckedChanged);
            // 
            // rdbtphong
            // 
            this.rdbtphong.AutoSize = true;
            this.rdbtphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtphong.Location = new System.Drawing.Point(116, 79);
            this.rdbtphong.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtphong.Name = "rdbtphong";
            this.rdbtphong.Size = new System.Drawing.Size(74, 20);
            this.rdbtphong.TabIndex = 6;
            this.rdbtphong.TabStop = true;
            this.rdbtphong.Text = "Phòng:";
            this.rdbtphong.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 11);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 239);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DoAnQuanLyKhachSan.Properties.Resources.checklist_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(121, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "THỐNG KÊ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::DoAnQuanLyKhachSan.Properties.Resources.rsz_tick_icon_vector_symbol_checkmark_isolated_white_background_check_list_button_icon_check_mark_icon_round_sign_tick_icon_135060048;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(330, 438);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "XUẤT EXCEL";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btquayve
            // 
            this.btquayve.BackgroundImage = global::DoAnQuanLyKhachSan.Properties.Resources.images1;
            this.btquayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquayve.Image = global::DoAnQuanLyKhachSan.Properties.Resources.no_entry_icon;
            this.btquayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btquayve.Location = new System.Drawing.Point(500, -2);
            this.btquayve.Name = "btquayve";
            this.btquayve.Size = new System.Drawing.Size(114, 50);
            this.btquayve.TabIndex = 4;
            this.btquayve.Text = "Quay về";
            this.btquayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btquayve.UseVisualStyleBackColor = true;
            this.btquayve.Click += new System.EventHandler(this.btquayve_Click);
            // 
            // frm_thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 498);
            this.Controls.Add(this.btquayve);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_thongkedoanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_thongkedoanhthu";
            this.Load += new System.EventHandler(this.frm_thongkedoanhthu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbchung;
        private System.Windows.Forms.RadioButton rdbtdv;
        private System.Windows.Forms.RadioButton rdbtall;
        private System.Windows.Forms.RadioButton rdbtphong;
        private System.Windows.Forms.Button btquayve;
    }
}