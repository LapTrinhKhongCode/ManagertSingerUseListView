using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tim_Hieu_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Detail
            cmbViewList.SelectedIndex = 3;

            cmbSorting.SelectedIndex = 2;

            lvCaSi.CheckBoxes = true;

            // Hiển thị checkbox tất cả nếu có hiển thị checkbox đầu mỗi item
            chkCheckAll.Visible = lvCaSi.CheckBoxes;

            lvCaSi.HideSelection = false;

            lvCaSi.LabelEdit = true;

            //lvCaSi.Columns.Add("HoTen", "Họ Tên", 300);
            //lvCaSi.Columns.Add("NgheDanh", "Nghệ Danh", 150);
            //lvCaSi.Columns.Add("GioiTinh", "Giới Tính", 150);
            //lvCaSi.Columns.Add("NgaySinh", "Ngày Sinh", 150);
        }

        private void cmbViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViewList.Text == "LargeIcon")
            {
                lvCaSi.View = View.LargeIcon;
            }
            else if (cmbViewList.Text == "SmallIcon")
            {
                lvCaSi.View = View.SmallIcon;
            }
            else if (cmbViewList.Text == "List")
            {
                lvCaSi.View = View.List;
            }
            else if (cmbViewList.Text == "Details")
            {
                lvCaSi.View = View.Details;
            }
            else if (cmbViewList.Text == "Title")
            {
                lvCaSi.View = View.Tile;
            }
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.Text == "Sắp tăng")
            {
                // Bước 1: Khai báo kiểu sắp xếp
                lvCaSi.Sorting = SortOrder.Ascending;

                // Bước 2: Gọi phương thức sắp xếp
                lvCaSi.Sort();
            }
            else if (cmbSorting.Text == "Sắp giảm")
            {
                lvCaSi.Sorting = SortOrder.Descending;
                lvCaSi.Sort();
            }
            else if (cmbSorting.Text == "Không sắp")
            {
                lvCaSi.Sorting = SortOrder.None;
            }
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            // item.Checked(): Kiểm tra xem item đó có được check ko? Nếu có là true, nếu không là false

            //int dem = 0;
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                ListViewItem item = new ListViewItem();
                item = lvCaSi.Items[i];

                if (item.Checked == true)
                {
                    //dem++;
                    MessageBox.Show("Họ tên: " + item.SubItems[0].Text +
                    "\nNghệ danh: " + item.SubItems[1].Text +
                    "\nGiới tính: " + item.SubItems[2].Text +
                    "\nNgày sinh: " + item.SubItems[3].Text);
                }
            }
            //MessageBox.Show("Số item được checked: " + dem);
        }

        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            // Sẽ bật hết toàn bộ checkbox các item lên
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                lvCaSi.Items[i].Checked = chkCheckAll.Checked;
            }
            
        }

        private void lvCaSi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("aaa");
        }

        private void lvCaSi_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Down");
            // Tại sao lại không có ItemMouseDown? Bởi vì bản chất sự kiện MouseDown đã bao trùm cả việc kiểm tra xem vị trí nhấn chuột xuống có phải là item không? và nếu phải thì cụ thể là item nào cũng biết được luôn
            
            // Kiểm tra coi phải item không?
            
            ListViewItem item = lvCaSi.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                MessageBox.Show("Đang click chuột " + e.Button.ToString() +" vào vị trí item");

                // Nghiên cứu xem e.Click và e.Delta có ý nghĩa gì?

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {

                    MessageBox.Show("Họ tên: " + item.SubItems[0].Text +
                    "\nNghệ danh: " + item.SubItems[1].Text +
                    "\nGiới tính: " + item.SubItems[2].Text +
                    "\nNgày sinh: " + item.SubItems[3].Text);
                }
            }
        }

        private void lvCaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("count = " + lvCaSi.SelectedItems.Count.ToString());
            //if (lvCaSi.SelectedItems.Count > 0)
            //{
            //    ListViewItem item = lvCaSi.SelectedItems[0];
            //    MessageBox.Show("Họ tên: " + item.SubItems[0].Text +
            //            "\nNghệ danh: " + item.SubItems[1].Text +
            //            "\nGiới tính: " + item.SubItems[2].Text +
            //            "\nNgày sinh: " + item.SubItems[3].Text);
            //}
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCaSi.SelectedItems[0];
            MessageBox.Show("Họ tên: " + item.SubItems[0].Text +
                    "\nNghệ danh: " + item.SubItems[1].Text +
                    "\nGiới tính: " + item.SubItems[2].Text +
                    "\nNgày sinh: " + item.SubItems[3].Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvCaSi.SelectedItems.Count > 0)
            {
                // Xóa item vị trí 0
                // lvCaSi.Items.RemoveAt(0);

                // Xóa item vị trí 0
                //ListViewItem item = lvCaSi.Items[0];
                //lvCaSi.Items.Remove(item);

                // Xóa dòng đang được chọn trên ListView
                lvCaSi.Items.Remove(lvCaSi.SelectedItems[0]);
                //lvCaSi.Items.RemoveAt(lvCaSi.SelectedIndices[1]);
            }
        }

        private void lvCaSi_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Item != lvCaSi.Items.Count - 1) // Cho chỉnh sửa tất cả các dòng trên ListView trừ dòng cuối cùng
            {
                e.CancelEdit = false; // Cho phép chỉnh sửa
                MessageBox.Show("Đang chỉnh sửa item vị trí index = " + e.Item
                + "\nGiá trị item sau khi chỉnh sửa là: " + e.Label);
            }
            else
            {
                e.CancelEdit = true; // Không cho phép chỉnh sửa
                MessageBox.Show("Không thể chỉnh sửa được vì không cho phép chỉnh dòng cuối");
            }
        }

        private void lvCaSi_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Item != lvCaSi.Items.Count - 1) // Cho chỉnh sửa tất cả các dòng trên ListView trừ dòng cuối cùng
            {
                e.CancelEdit = false; // Cho phép chỉnh sửa
                MessageBox.Show("Đang chỉnh sửa item vị trí index = " + e.Item
                + "\nGiá trị item trước khi chỉnh sửa là: " + e.Label);
            }
            else
            {
                e.CancelEdit = true; // Không cho phép chỉnh sửa
                MessageBox.Show("Không thể chỉnh sửa được vì không cho phép chỉnh dòng cuối");
            }
        }

        private void lvCaSi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MessageBox.Show("Đang click vào cột: " + lvCaSi.Columns[e.Column].Text);
        }

        private void lvCaSi_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Đang double click vào dòng: " + lvCaSi.SelectedIndices[0]);

            ListViewItem item = lvCaSi.SelectedItems[0];
            MessageBox.Show("Họ tên: " + item.SubItems[0].Text +
                    "\nNghệ danh: " + item.SubItems[1].Text +
                    "\nGiới tính: " + item.SubItems[2].Text +
                    "\nNgày sinh: " + item.SubItems[3].Text);
        }

        // Before
        private void lvCaSi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //MessageBox.Show("check");
            bool LuaChonCheck = true;
            string luachon = "";

            // Trạng thái ban đầu trước khi được chọn
            if (e.CurrentValue == CheckState.Checked)
            {
                LuaChonCheck = false;
                luachon = "bỏ chọn";
            }
            else if (e.CurrentValue == CheckState.Unchecked)
            {
                LuaChonCheck = true;
                luachon = "chọn";
            }

            DialogResult cauhoi = MessageBox.Show("Bạn có chắc chắn " + luachon + " ca sĩ: " + lvCaSi.Items[e.Index].SubItems[1].Text + " này không?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cauhoi == System.Windows.Forms.DialogResult.No)
            {
                if (LuaChonCheck == true)
                    e.NewValue = CheckState.Unchecked;
                else
                    e.NewValue = CheckState.Checked;
            }
            else
            {
                if (LuaChonCheck == true)
                    e.NewValue = CheckState.Checked;
                else
                    e.NewValue = CheckState.Unchecked;
            }
        }

        // After
        private void lvCaSi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //MessageBox.Show("checked");

            if (e.Item.Checked == true)
                MessageBox.Show("Cảm ơn Bạn đã chọn ca sĩ: " + e.Item.SubItems[1].Text);
            else
                MessageBox.Show("Lần sau nhớ chọn tôi nhé!!!");
        }

        private void lvCaSi_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            // Luôn reset màu các item
            foreach (ListViewItem item in lvCaSi.Items)
                item.BackColor = Color.White;

            e.Item.BackColor = Color.SkyBlue;
        }

       
    }
}
