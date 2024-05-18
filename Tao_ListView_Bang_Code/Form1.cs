using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tao_ListView_Bang_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageList imgHinhAnh = new ImageList();
            imgHinhAnh.Images.Add(Image.FromFile("C:"));
            imgHinhAnh.Images.Add(Image.FromFile("C:"));
            imgHinhAnh.Images.Add(Image.FromFile("C:"));
            imgHinhAnh.Images.Add(Image.FromFile("C:"));
            imgHinhAnh.ImageSize = new System.Drawing.Size(150, 150);
            imgHinhAnh.ColorDepth = ColorDepth.Depth32Bit;

            ListViewGroup lvgNam = new ListViewGroup("Nam");
            ListViewGroup lvgNu = new ListViewGroup("Nữ");

            // Bước 1: Tạo ListView
            ListView lvCaSi = new ListView();
            lvCaSi.Size = new System.Drawing.Size(1000, 700);
            lvCaSi.Location = new Point(100, 100);
            lvCaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lvCaSi.LargeImageList = imgHinhAnh;
            lvCaSi.SmallImageList = imgHinhAnh;
            lvCaSi.ShowGroups = true;
            lvCaSi.Groups.Add(lvgNam);
            lvCaSi.Groups.Add(lvgNu);

            // Bước 2: Tạo Columns
            
            lvCaSi.Columns.Add("HoTen", "Họ Tên", 300);
            lvCaSi.Columns.Add("NgheDanh", "Nghệ Danh", 150);
            lvCaSi.Columns.Add("GioiTinh", "Giới Tính", 150);
            lvCaSi.Columns.Add("NgaySinh", "Ngày Sinh", 150);

            // Bước 3 & 4: Tạo item & subitem 

            ListViewItem[] lvi = new ListViewItem[4];

            //lvi[0] = new ListViewItem("Phạm Thị Hương Tràm", 0);
            //lvi[0].SubItems.Add("Hương Tràm");
            //lvi[0].SubItems.Add("Nữ");
            //lvi[0].SubItems.Add("15/1/1995");
            
            lvi[0] = new ListViewItem(new string[] {"Phạm Thị Hương Tràm", "Hương Tràm", "Nữ", "15/1/1995"}, 0);
            //lvi[0].Group = lvgNu;

            lvi[1] = new ListViewItem("Đặng Thị Mỹ Dung", 1);
            lvi[1].SubItems.Add("Midu");
            lvi[1].SubItems.Add("Nữ");
            lvi[1].SubItems.Add("5/10/1989");

            lvi[2] = new ListViewItem("Nguyễn Thị Thanh Nguyên", 2);
            lvi[2].SubItems.Add("Miu Lê");
            lvi[2].SubItems.Add("Nữ");
            lvi[2].SubItems.Add("5/7/1991");

            lvi[3] = new ListViewItem("Nguyễn Bằng Kiều", 3);
            lvi[3].SubItems.Add("Bằng Kiều");
            lvi[3].SubItems.Add("Nam");
            lvi[3].SubItems.Add("12/7/1973");

            lvCaSi.Items.Add(lvi[0]);
            lvCaSi.Items.Add(lvi[1]);
            lvCaSi.Items.Add(lvi[2]);
            lvCaSi.Items.Insert(lvCaSi.Items.Count, lvi[3]);

            //lvCaSi.Items.AddRange(lvi);

            lvCaSi.View = View.Details;
            lvCaSi.GridLines = true;
            lvCaSi.FullRowSelect = true;
            lvCaSi.AllowColumnReorder = true;
            //lvCaSi.MultiSelect = false;

            this.Controls.Add(lvCaSi);

            // Duyệt qua từng group
            //MessageBox.Show("Group Nam có: " + lvgNam.Items.Count);
            //MessageBox.Show("Group Nữ có: " + lvgNu.Items.Count);

            //for (int i = 0; i < lvgNu.Items.Count; ++i)
            //{
            //    //lvgNam.Items[i]; // Đây chính là 1 item trên ListView thuộc group tương ứng
            //    ListViewItem item = lvgNu.Items[i];

            //    MessageBox.Show("Họ tên: " + item.SubItems[lvCaSi.Columns["HoTen"].Index].Text +
            //        "\nNghệ danh: " + item.SubItems[lvCaSi.Columns["NgheDanh"].Index].Text +
            //        "\nGiới tính: " + item.SubItems[lvCaSi.Columns["GioiTinh"].Index].Text +
            //        "\nNgày sinh: " + item.SubItems[lvCaSi.Columns["NgaySinh"].Index].Text);

            //    // Có thể lấy nhanh bằng cách item.SubItems[0].Text nhưng khuyến khích không nên bởi vì nếu sau này có nhu cầu đổi chỗ các cột dữ liệu thì sẽ bị hỏng ngay
            //}

        }
    }
}
