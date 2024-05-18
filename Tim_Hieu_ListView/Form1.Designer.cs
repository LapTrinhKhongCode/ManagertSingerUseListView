namespace Tim_Hieu_ListView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Nam", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Nữ", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Sinh năm 6x", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Sinh năm 7x", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Sinh năm 8x", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Sinh năm 9x", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Đặng Thị Mỹ Dung",
            "Midu",
            "Nữ",
            "5/10/1989"}, 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Bằng Kiều",
            "Bằng Kiều",
            "Nam",
            "12/7/1973"}, 3);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Thị Thanh Nguyên",
            "Miu Lê",
            "Nữ",
            "5/7/1991"}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Phạm Thị Hương Tràm",
            "Hương Tràm",
            "Nữ",
            "15/1/1995"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvCaSi = new System.Windows.Forms.ListView();
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgheDanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.cmbViewList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.btnSelectedItem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCaSi
            // 
            this.lvCaSi.AllowColumnReorder = true;
            this.lvCaSi.CheckBoxes = true;
            this.lvCaSi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoTen,
            this.NgheDanh,
            this.GioiTinh,
            this.NgaySinh});
            this.lvCaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCaSi.FullRowSelect = true;
            this.lvCaSi.GridLines = true;
            listViewGroup1.Header = "Nam";
            listViewGroup1.Name = "Nam";
            listViewGroup2.Header = "Nữ";
            listViewGroup2.Name = "Nu";
            listViewGroup3.Header = "Sinh năm 6x";
            listViewGroup3.Name = "6x";
            listViewGroup4.Header = "Sinh năm 7x";
            listViewGroup4.Name = "7x";
            listViewGroup5.Header = "Sinh năm 8x";
            listViewGroup5.Name = "8x";
            listViewGroup6.Header = "Sinh năm 9x";
            listViewGroup6.Name = "9x";
            this.lvCaSi.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lvCaSi.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lvCaSi.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvCaSi.LargeImageList = this.imgHinhAnh;
            this.lvCaSi.Location = new System.Drawing.Point(47, 137);
            this.lvCaSi.Name = "lvCaSi";
            this.lvCaSi.Size = new System.Drawing.Size(1440, 722);
            this.lvCaSi.SmallImageList = this.imgHinhAnh;
            this.lvCaSi.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvCaSi.TabIndex = 0;
            this.lvCaSi.UseCompatibleStateImageBehavior = false;
            this.lvCaSi.View = System.Windows.Forms.View.Details;
            this.lvCaSi.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvCaSi_AfterLabelEdit);
            this.lvCaSi.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvCaSi_BeforeLabelEdit);
            this.lvCaSi.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCaSi_ColumnClick);
            this.lvCaSi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvCaSi_ItemCheck);
            this.lvCaSi.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvCaSi_ItemChecked);
            this.lvCaSi.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lvCaSi_ItemMouseHover);
            this.lvCaSi.SelectedIndexChanged += new System.EventHandler(this.lvCaSi_SelectedIndexChanged);
            this.lvCaSi.Click += new System.EventHandler(this.lvCaSi_Click);
            this.lvCaSi.DoubleClick += new System.EventHandler(this.lvCaSi_DoubleClick);
            this.lvCaSi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCaSi_MouseDown);
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 400;
            // 
            // NgheDanh
            // 
            this.NgheDanh.Text = "Nghệ Danh";
            this.NgheDanh.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày Sinh";
            this.NgaySinh.Width = 150;
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhAnh.ImageStream")));
            this.imgHinhAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhAnh.Images.SetKeyName(0, "huongtram.jpg");
            this.imgHinhAnh.Images.SetKeyName(1, "midu.jpg");
            this.imgHinhAnh.Images.SetKeyName(2, "miule.jpg");
            this.imgHinhAnh.Images.SetKeyName(3, "bangkieu.jpg");
            // 
            // cmbViewList
            // 
            this.cmbViewList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewList.FormattingEnabled = true;
            this.cmbViewList.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "List",
            "Details",
            "Title"});
            this.cmbViewList.Location = new System.Drawing.Point(1119, 37);
            this.cmbViewList.Name = "cmbViewList";
            this.cmbViewList.Size = new System.Drawing.Size(211, 37);
            this.cmbViewList.TabIndex = 1;
            this.cmbViewList.SelectedIndexChanged += new System.EventHandler(this.cmbViewList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(861, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn View tương ứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thuộc tính Sorting";
            // 
            // cmbSorting
            // 
            this.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Items.AddRange(new object[] {
            "Sắp tăng",
            "Sắp giảm",
            "Không sắp"});
            this.cmbSorting.Location = new System.Drawing.Point(571, 12);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(211, 37);
            this.cmbSorting.TabIndex = 3;
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(381, 69);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(175, 43);
            this.btnCheckBox.TabIndex = 5;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Location = new System.Drawing.Point(143, 148);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(18, 17);
            this.chkCheckAll.TabIndex = 6;
            this.chkCheckAll.UseVisualStyleBackColor = true;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // btnSelectedItem
            // 
            this.btnSelectedItem.Location = new System.Drawing.Point(593, 69);
            this.btnSelectedItem.Name = "btnSelectedItem";
            this.btnSelectedItem.Size = new System.Drawing.Size(175, 43);
            this.btnSelectedItem.TabIndex = 7;
            this.btnSelectedItem.Text = "Selected Item";
            this.btnSelectedItem.UseVisualStyleBackColor = true;
            this.btnSelectedItem.Click += new System.EventHandler(this.btnSelectedItem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(794, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 43);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 913);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSelectedItem);
            this.Controls.Add(this.chkCheckAll);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbViewList);
            this.Controls.Add(this.lvCaSi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCaSi;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader NgheDanh;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.ComboBox cmbViewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.Button btnSelectedItem;
        private System.Windows.Forms.Button btnXoa;
    }
}

