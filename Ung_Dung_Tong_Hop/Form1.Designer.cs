namespace Ung_Dung_Tong_Hop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvCaSi = new System.Windows.Forms.ListView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgheDanh = new System.Windows.Forms.TextBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmbGomNhom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnLoadDanhSach = new System.Windows.Forms.Button();
            this.chkChonCaSiYeuThich = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCaSi
            // 
            this.lvCaSi.BackColor = System.Drawing.SystemColors.Info;
            this.lvCaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCaSi.FullRowSelect = true;
            this.lvCaSi.GridLines = true;
            this.lvCaSi.HideSelection = false;
            this.lvCaSi.LabelEdit = true;
            this.lvCaSi.Location = new System.Drawing.Point(48, 634);
            this.lvCaSi.Name = "lvCaSi";
            this.lvCaSi.Size = new System.Drawing.Size(1588, 421);
            this.lvCaSi.TabIndex = 0;
            this.lvCaSi.UseCompatibleStateImageBehavior = false;
            this.lvCaSi.View = System.Windows.Forms.View.Details;
            this.lvCaSi.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvCaSi_AfterLabelEdit);
            this.lvCaSi.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCaSi_ColumnClick);
            this.lvCaSi.SelectedIndexChanged += new System.EventHandler(this.lvCaSi_SelectedIndexChanged);
            this.lvCaSi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCaSi_MouseDown);
            this.lvCaSi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvCaSi_MouseMove);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(473, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(354, 34);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            // 
            // txtNgheDanh
            // 
            this.txtNgheDanh.Location = new System.Drawing.Point(473, 181);
            this.txtNgheDanh.Name = "txtNgheDanh";
            this.txtNgheDanh.Size = new System.Drawing.Size(354, 34);
            this.txtNgheDanh.TabIndex = 4;
            this.txtNgheDanh.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgheDanh_Validating);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(1087, 71);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(234, 37);
            this.cmbGioiTinh.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgheDanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1588, 257);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Ca Sĩ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_administrator_male_528;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(18, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 199);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Location = new System.Drawing.Point(1087, 172);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(423, 34);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_autograph_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(303, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_gender_48;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(897, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 69);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_autograph_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(254, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nghệ danh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_birthday_40;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(879, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(689, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(267, 34);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // cmbGomNhom
            // 
            this.cmbGomNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGomNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGomNhom.FormattingEnabled = true;
            this.cmbGomNhom.Items.AddRange(new object[] {
            "Chọn để gom nhóm",
            "Giới Tính (Nam/Nữ)",
            "Năm Sinh (6x, 7x, 8x, 9x)",
            "Tháng Sinh"});
            this.cmbGomNhom.Location = new System.Drawing.Point(277, 33);
            this.cmbGomNhom.Name = "cmbGomNhom";
            this.cmbGomNhom.Size = new System.Drawing.Size(366, 37);
            this.cmbGomNhom.TabIndex = 18;
            this.cmbGomNhom.SelectedIndexChanged += new System.EventHandler(this.cmbGomNhom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.cmbGomNhom);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXacNhan);
            this.groupBox2.Controls.Add(this.btnLoadDanhSach);
            this.groupBox2.Controls.Add(this.chkChonCaSiYeuThich);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1588, 267);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Chức Năng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_maintenance_528;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 199);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_change_user_48;
            this.btnCapNhat.Location = new System.Drawing.Point(1236, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(173, 77);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_add_user_male_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(822, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 77);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_ok_48;
            this.btnXacNhan.Location = new System.Drawing.Point(595, 186);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(178, 56);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnLoadDanhSach
            // 
            this.btnLoadDanhSach.AutoSize = true;
            this.btnLoadDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDanhSach.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_reset_64;
            this.btnLoadDanhSach.Location = new System.Drawing.Point(1245, 31);
            this.btnLoadDanhSach.Name = "btnLoadDanhSach";
            this.btnLoadDanhSach.Size = new System.Drawing.Size(265, 72);
            this.btnLoadDanhSach.TabIndex = 11;
            this.btnLoadDanhSach.Text = "Load Danh Sách";
            this.btnLoadDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadDanhSach.UseVisualStyleBackColor = true;
            this.btnLoadDanhSach.Click += new System.EventHandler(this.btnLoadDanhSach_Click);
            // 
            // chkChonCaSiYeuThich
            // 
            this.chkChonCaSiYeuThich.AutoSize = true;
            this.chkChonCaSiYeuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChonCaSiYeuThich.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_checked_user_male_48;
            this.chkChonCaSiYeuThich.Location = new System.Drawing.Point(286, 159);
            this.chkChonCaSiYeuThich.Name = "chkChonCaSiYeuThich";
            this.chkChonCaSiYeuThich.Size = new System.Drawing.Size(271, 81);
            this.chkChonCaSiYeuThich.TabIndex = 16;
            this.chkChonCaSiYeuThich.Text = "Chọn Ca Sĩ Yêu Thích";
            this.chkChonCaSiYeuThich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChonCaSiYeuThich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkChonCaSiYeuThich.UseVisualStyleBackColor = true;
            this.chkChonCaSiYeuThich.CheckedChanged += new System.EventHandler(this.chkChonCaSiYeuThich_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_denied_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1023, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 77);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::Ung_Dung_Tong_Hop.Properties.Resources.icons8_find_user_male_48;
            this.btnTimKiem.Location = new System.Drawing.Point(1023, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 77);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1676, 65);
            this.label5.TabIndex = 20;
            this.label5.Text = "Phần Mềm Quản Lý Danh Sách Ca Sĩ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1676, 1075);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvCaSi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Phần Mềm Quản Lý Danh Sách Ca Sĩ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCaSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgheDanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLoadDanhSach;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox chkChonCaSiYeuThich;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cmbGomNhom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}

