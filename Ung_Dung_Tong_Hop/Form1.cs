using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ung_Dung_Tong_Hop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CaSi> lstCaSi = new List<CaSi>();

        ErrorProvider error = new ErrorProvider();

        CheckBox chkAll = new CheckBox();

        ToolTip tool = new ToolTip();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //lvCaSi.Columns["NgaySinh"].Text += "   ^";

            cmbGioiTinh.SelectedIndex = 0;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            // Tạo columns
            lvCaSi.Columns.Add("HoTen", "Họ Tên", 300);
            lvCaSi.Columns.Add("NgheDanh", "Nghệ Danh", 150);
            lvCaSi.Columns.Add("GioiTinh", "Giới Tính", 150);
            lvCaSi.Columns.Add("NgaySinh", "Ngày Sinh", 150);
            

            // Tạo item & subitem => tính năng thêm sẽ giải quyết
            ListViewItem[] lvi = new ListViewItem[4];

            ////lvi[0] = new ListViewItem("Phạm Thị Hương Tràm", 0);
            ////lvi[0].SubItems.Add("Hương Tràm");
            ////lvi[0].SubItems.Add("Nữ");
            ////lvi[0].SubItems.Add("15/1/1995");

            lvi[0] = new ListViewItem(new string[] { "Phạm Thị Hương Tràm", "Hương Tràm", "Nữ", "15/1/1995" });
            ////lvi[0].Group = lvgNu;

            lvi[1] = new ListViewItem("Đặng Thị Mỹ Dung");
            lvi[1].SubItems.Add("Midu");
            lvi[1].SubItems.Add("Nữ");
            lvi[1].SubItems.Add("5/10/1989");

            lvi[2] = new ListViewItem("Nguyễn Thị Thanh Nguyên");
            lvi[2].SubItems.Add("Miu Lê");
            lvi[2].SubItems.Add("Nữ");
            lvi[2].SubItems.Add("5/7/1991");

            lvi[3] = new ListViewItem("Nguyễn Bằng Kiều");
            lvi[3].SubItems.Add("Bằng Kiều");
            lvi[3].SubItems.Add("Nam");
            lvi[3].SubItems.Add("12/7/1973");

            lvCaSi.Items.Add(lvi[0]);
            lvCaSi.Items.Add(lvi[1]);
            lvCaSi.Items.Add(lvi[2]);
            lvCaSi.Items.Insert(lvCaSi.Items.Count, lvi[3]);

            // Chức năng phụ trợ để đo thời gian chạy trong trường hợp có nhiều item
            //for (int i = 1; i <= 96; ++i)
            //{
            //    Random rd = new Random();

            //    ListViewItem lvi_i = null;
            //    GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Items[rd.Next(0, 4)], lvCaSi);

            //    lvCaSi.Items.Add(lvi_i);
            //}

            //for (int i = 1; i <= 236; ++i)
            //{
            //    ListViewItem lvi_i = null;
            //    GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Items[0], lvCaSi);

            //    lvCaSi.Items.Add(lvi_i);
            //}

            //for (int i = 1; i <= 115; ++i)
            //{
            //    ListViewItem lvi_i = null;
            //    GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Items[1], lvCaSi);

            //    lvCaSi.Items.Add(lvi_i);
            //}

            //for (int i = 1; i <= 115; ++i)
            //{
            //    ListViewItem lvi_i = null;
            //    GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Items[2], lvCaSi);

            //    lvCaSi.Items.Add(lvi_i);
            //}

            //for (int i = 1; i <= 130; ++i)
            //{
            //    ListViewItem lvi_i = null;
            //    GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Items[3], lvCaSi);

            //    lvCaSi.Items.Add(lvi_i);
            //}

                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTimKiem.GotFocus += txtTimKiem_GotFocus;

            btnXacNhan.Enabled = chkChonCaSiYeuThich.Checked;
           
            chkAll.AutoSize = true;
            chkAll.Text = "Chọn tất cả";
            chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chkAll.Location = new Point(lvCaSi.Location.X, lvCaSi.Location.Y - 25);
            this.Controls.Add(chkAll);
            chkAll.Visible = chkChonCaSiYeuThich.Checked;
            chkAll.CheckedChanged += chkAll_CheckedChanged;

            cmbGomNhom.SelectedIndex = 0;

            tool.SetToolTip(btnThem, "Bạn hãy nhập dữ liệu thông tin ca sĩ ở phía trên sau đó nhấn vào nút này để thêm vào danh sách ca sĩ");
            tool.SetToolTip(btnXoa, "Bạn hãy chọn dữ liệu ca sĩ cần xóa ở trong danh sách rồi nhấn vào nút này để xóa ca sĩ");
            tool.SetToolTip(btnCapNhat, "Bạn hãy chọn dữ liệu ca sĩ cần cập nhật ở trong danh sách sau đó chỉnh sửa thông tin ca sĩ rồi nhấn nút này để cập nhật lại");
            tool.SetToolTip(txtTimKiem, "Bạn hãy nhập vào nghệ danh của ca sĩ mà Bạn muốn tìm kiếm sau đó nhấn Enter hoặc nhấn nút cập nhật ở bên cạnh để tìm kiếm ca sĩ");
            tool.SetToolTip(btnTimKiem, "Bạn hãy nhập vào nghệ danh của ca sĩ mà Bạn muốn tìm kiếm vào ô bên cạnh sau đó nhấn Enter hoặc nhấn nút này để tìm kiếm ca sĩ");
            tool.SetToolTip(btnLoadDanhSach, "Nhấn vào nút này để dữ liệu danh sách các ca sĩ được load lên ListView");
            tool.SetToolTip(dtpNgaySinh, "Bạn có thể chọn ngày sinh bằng cách nhập trực tiếp hoặc chọn");
            tool.SetToolTip(lvCaSi, "Bạn có thể sắp xếp danh sách dữ liệu bằng cách Click vào các cột trên ListView");


        }

        void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCaSi.Items)
                item.Checked = chkAll.Checked;
        }

        // Khi con trỏ chuột đưa vào có nghĩa là người dùng có ý định muốn tìm kiếm => Ngay lúc này chính là lúc dữ liệu được Load về
        void txtTimKiem_GotFocus(object sender, EventArgs e)
        {
            // Reset
            txtTimKiem.AutoCompleteCustomSource.Clear();

            // Đổ dữ liệu các nghệ danh trên ListView vào danh sách AutoCompleteCustomSource
            foreach (ListViewItem item in lvCaSi.Items)
                txtTimKiem.AutoCompleteCustomSource.Add(item.SubItems[lvCaSi.Columns["NgheDanh"].Index].Text);

        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầy đủ
            if (txtHoTen.Text == "")
            {
                //MessageBox.Show("Bạn chưa nhập vào họ tên");
                error.SetError(txtHoTen, "Bạn chưa nhập vào họ tên");
                txtHoTen.Focus();
            }
            else if (txtNgheDanh.Text == "")
            {
                error.SetError(txtHoTen, null);

                //MessageBox.Show("Bạn chưa nhập vào nghệ danh");
                error.SetError(txtNgheDanh, "Bạn chưa nhập vào nghệ danh");
                txtNgheDanh.Focus();
            }
            else // Tất cả đều đầy đủ
            {
                error.Clear(); // Nếu tất cả đã đủ dữ liệu thì reset error đi

                int SoLuongTruocKhiThem = lvCaSi.Items.Count;

                // Bước 1: Class nhận dữ liệu từ Form
                // Cách 1: 
                //CaSi casi = new CaSi();
                //casi.HoTen = txtHoTen.Text;
                //casi.NgheDanh = txtNgheDanh.Text;
                //casi.NgaySinh = dtpNgaySinh.Value;
                //casi.GioiTinh = cmbGioiTinh.Text;

                // Cách 2:
                CaSi casi = new CaSi(txtHoTen.Text, txtNgheDanh.Text, cmbGioiTinh.Text, dtpNgaySinh.Value);

                // Bước 2: Class xử lý và đưa lên lại Form
                lstCaSi.Add(casi);
                CaSi.AddCaSi(casi, lvCaSi);

                foreach (ListViewItem lvi in lvCaSi.Items)
                    lvi.Selected = false;

                lvCaSi.Items[lvCaSi.Items.Count - 1].Selected = true;

                if (lvCaSi.Items.Count > SoLuongTruocKhiThem)
                {
                    if (lvCaSi.Groups.Count > 0) 
                    {
                        if (cmbGomNhom.SelectedIndex == 1) // giới tính
                        {
                            for (int i = 0; i < lvCaSi.Groups.Count; ++i)
                            {
                                if (lvCaSi.Groups[i].Header == casi.GioiTinh)
                                {
                                    lvCaSi.Items[lvCaSi.Items.Count - 1].Group = lvCaSi.Groups[i];
                                    break;
                                }
                            }
                        }
                        else if (cmbGomNhom.SelectedIndex == 2) // năm sinh
                        {
                            lvCaSi.Items[lvCaSi.Items.Count - 1].Group = lvCaSi.Groups[(casi.NgaySinh.Year / 10) % 10];
                        }
                        else if (cmbGomNhom.SelectedIndex == 3) // tháng sinh
                        {
                            lvCaSi.Items[lvCaSi.Items.Count - 1].Group = lvCaSi.Groups[casi.NgaySinh.Month - 1];
                        }    
                    }

                    MessageBox.Show("Đã thêm ca sĩ thành công");
                    txtHoTen.Clear();
                    txtNgheDanh.Clear();
                }
            }
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            // Reset danh sách ListView
            lvCaSi.Items.Clear();

            // Class truyền dữ liệu lên Form
            CaSi.LoadDuLieu(lstCaSi, lvCaSi);
        }

        void Control_Validating(Control control, CancelEventArgs e, string thongbao)
        {
            if (control.Text == "")
            {
                error.SetError(control, thongbao);
                e.Cancel = true; // không cho phép rời chuột khỏi TextBox
            }
            else
            {
                error.SetError(control, null);
                e.Cancel = false; // cho phép đưa con chuột vào nơi khác để nhập tiếp dữ liệu
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            //Control_Validating((TextBox)sender, e, "Bạn phải nhập dữ liệu họ tên");

            //if (txtHoTen.Text == "")
            //{
            //    error.SetError(txtHoTen, "Bạn phải nhập dữ liệu họ tên");
            //    e.Cancel = true; // không cho phép rời chuột khỏi TextBox
            //}
            //else
            //{
            //    error.SetError(txtHoTen, null);
            //    e.Cancel = false; // cho phép đưa con chuột vào nơi khác để nhập tiếp dữ liệu
            //}
        }

        private void txtNgheDanh_Validating(object sender, CancelEventArgs e)
        {
            //Control_Validating((TextBox)sender, e, "Bạn phải nhập dữ liệu nghệ danh");

            //if (txtNgheDanh.Text == "")
            //{
            //    error.SetError(txtNgheDanh, "Bạn phải nhập dữ liệu nghệ danh");
            //    e.Cancel = true; // không cho phép rời chuột khỏi TextBox
            //}
            //else
            //{
            //    error.SetError(txtNgheDanh, null);
            //    e.Cancel = false; // cho phép đưa con chuột vào nơi khác để nhập tiếp dữ liệu
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvCaSi.SelectedItems.Count > 0) // có chọn
            {
                int SoLuongTruocKhiXoa = lvCaSi.Items.Count;
                int SoLuongItemChonXoa = lvCaSi.SelectedItems.Count;

                // Hỏi có chắc chắn muốn xóa ko?
                DialogResult luachon = MessageBox.Show("Bạn có chắc chắn muốn xóa " + lvCaSi.SelectedItems.Count + " ca sĩ không?",
                    "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (luachon == System.Windows.Forms.DialogResult.Yes)
                {
                    // lvCaSi.Items.Remove(lvCaSi.SelectedItems[0]); // xóa phần tử đầu tiên khỏi danh sách
                    // lvCaSi.Items.RemoveAt(lvCaSi.SelectedIndices[0]);

                    // Xóa nhiều: Mặc định ListView chỉ hỗ trợ trong 1 lần xóa 1 item thông qua phương thức Remove & RemoveAt nên nếu muốn xóa nhiều thì chúng ta phải cho 1 vòng lặp duyệt qua từng item, kiểm tra item nào chọn xóa thì tiến hành xóa đi
                    // Cách 1: Cùi bắp
                    //foreach (ListViewItem item in lvCaSi.Items)
                    //{
                    //    if (item.Selected == true) // đang được chọn
                    //    {
                    //        lvCaSi.Items.Remove(item);
                    //    }
                    //}

                    DialogResult cauhoi = MessageBox.Show("Bạn có muốn xóa luôn trong danh sách ca sĩ lưu trữ hay không?",
                        "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    // Cách 2: Chuyên nghiệp
                    foreach (ListViewItem item in lvCaSi.SelectedItems)
                    {
                        // lvCaSi.Items.Remove(item);
                        item.Remove();

                        // Cũng muốn xóa luôn trong danh sách lưu trữ => tiến hành xóa
                        if (cauhoi == System.Windows.Forms.DialogResult.Yes)
                        {
                            CaSi.XoaCaSiTheoNgheDanh(lstCaSi, item.SubItems[lvCaSi.Columns["NgheDanh"].Index].Text);
                        }
                    }

                    // Báo xóa thành công phải có căn cứ?

                    if (lvCaSi.Items.Count < SoLuongTruocKhiXoa)
                    {
                        if (SoLuongTruocKhiXoa - lvCaSi.Items.Count == SoLuongItemChonXoa)
                        {
                            MessageBox.Show("Đã xóa thành công tất cả");
                        }
                        else
                        {
                            MessageBox.Show("Đã xóa nhưng không xóa được hết");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần xóa trên ListView", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvCaSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvCaSi.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCaSi.SelectedItems[0];
                txtHoTen.Text = item.SubItems[lvCaSi.Columns["HoTen"].Index].Text;
                txtNgheDanh.Text = item.SubItems[lvCaSi.Columns["NgheDanh"].Index].Text;

                if (item.SubItems[lvCaSi.Columns["GioiTinh"].Index].Text == "Nam")
                    cmbGioiTinh.SelectedIndex = 0;
                else
                    cmbGioiTinh.SelectedIndex = 1;

                string[] s = item.SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                DateTime ngay = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));

                dtpNgaySinh.Value = ngay;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvCaSi.SelectedItems.Count > 0)
            {
                CaSi casi = new CaSi(txtHoTen.Text, txtNgheDanh.Text, cmbGioiTinh.Text, dtpNgaySinh.Value);

                ListViewItem lvi = new ListViewItem(txtHoTen.Text);
                lvi.SubItems.Add(txtNgheDanh.Text);
                lvi.SubItems.Add(cmbGioiTinh.Text);
                lvi.SubItems.Add(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));

                ListViewGroup lvgr = null;

                int idx = lvCaSi.SelectedIndices[0];
                string nghedanh = lvCaSi.Items[idx].SubItems[lvCaSi.Columns["NgheDanh"].Index].Text;

                if (lvCaSi.Groups.Count > 0)
                {
                    if (cmbGomNhom.SelectedIndex == 1)
                    {
                        if (lvCaSi.Items[idx].SubItems[lvCaSi.Columns["GioiTinh"].Index].Text == cmbGioiTinh.Text)
                        {
                            //MessageBox.Show("Trùng");
                            lvi.Group = lvCaSi.Items[idx].Group;
                            //lvgr = lvCaSi.Items[idx].Group;
                        }
                        else
                        {
                            //MessageBox.Show("Không trùng");
                            for (int i = 0; i < lvCaSi.Groups.Count; ++i)
                            {
                                if (lvCaSi.Groups[i].Header == casi.GioiTinh)
                                {
                                    lvi.Group = lvCaSi.Groups[i];
                                    //lvgr = lvCaSi.Groups[i];
                                    break;
                                }
                            }
                        }
                    }
                }

                lvCaSi.Items[idx] = lvi;
                //for (int i = 0; i < lvCaSi.Columns.Count; ++i)
                    //lvCaSi.Items[idx].SubItems[i].Text = lvi.SubItems[i].Text;

                //lvCaSi.Items[idx].SubItems[lvCaSi.Columns["HoTen"].Index].Text = txtHoTen.Text;
                //lvCaSi.Items[idx].SubItems[lvCaSi.Columns["NgheDanh"].Index].Text = txtNgheDanh.Text;
                //lvCaSi.Items[idx].SubItems[lvCaSi.Columns["GioiTinh"].Index].Text = cmbGioiTinh.Text;
                //lvCaSi.Items[idx].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

                lvCaSi.Items[idx].Group = lvi.Group;
                //lvCaSi.Items[idx].Group = lvgr;

                lvCaSi.Items[idx].Selected = true;

                CaSi.CapNhatCaSiTheoNgheDanh(lstCaSi, nghedanh, casi);

                //if (lvCaSi.Groups.Count > 0)
                //{
                //    if (cmbGomNhom.SelectedIndex == 1) // giới tính
                //    {

                //        for (int i = 0; i < lvCaSi.Groups.Count; ++i)
                //        {
                //            if (lvCaSi.Groups[i].Header == casi.GioiTinh)
                //            {
                //                lvCaSi.Items[idx].Group = lvCaSi.Groups[i];
                //                break;
                //            }
                //        }
                //    }
                //    else if (cmbGomNhom.SelectedIndex == 2) // năm sinh
                //    {
                //        lvCaSi.Items[idx].Group = lvCaSi.Groups[(casi.NgaySinh.Year / 10) % 10];
                //    }
                //    else if (cmbGomNhom.SelectedIndex == 3) // tháng sinh
                //    {
                //        lvCaSi.Items[idx].Group = lvCaSi.Groups[casi.NgaySinh.Month - 1];
                //    }
                //}
                MessageBox.Show("Đã cập nhật thành công thông tin ca sĩ: " + casi.NgheDanh);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần cập nhật trên ListView", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void lvCaSi_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Vấn đề nếu như chúng ta không chỉnh sửa gì cả thì e.Label sẽ bị rỗng

            if (e.Label != null)
                txtHoTen.Text = e.Label;
        }

        List<CaSi> DoDuLieuTuListViewXuongCollectionList()
        {
            List<CaSi> lst = new List<CaSi>();

            // Duyệt danh sách ListView qua từng Item
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                string hoten = lvCaSi.Items[i].SubItems[0].Text;
                string nghedanh = lvCaSi.Items[i].SubItems[1].Text;
                string gioitinh = lvCaSi.Items[i].SubItems[2].Text;

                string[] s = lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                DateTime ngaysinh = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));

                CaSi cs = new CaSi(hoten, nghedanh, gioitinh, ngaysinh);

                lst.Add(cs);
            }
            return lst;
        }

        void GanDuLieu2itemTrenListView(ref ListViewItem a, ListViewItem b, ListView lv)
        {
            /*
            a = new ListViewItem(b.SubItems[0].Text);
            a.SubItems.Add(b.SubItems[1].Text);
            a.SubItems.Add(b.SubItems[2].Text);
            a.SubItems.Add(b.SubItems[3].Text); */

            a = new ListViewItem(b.SubItems[0].Text);
            for (int i = 1; i < lv.Columns.Count; ++i)
                a.SubItems.Add(b.SubItems[i].Text);
        }

        int dem = 0;
        private void lvCaSi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvCaSi.Columns["NgaySinh"].Index)
            {
                //DateTime start = DateTime.Now;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //if (dem == 0)
                //{

                //    lvCaSi.Columns["NgaySinh"].Text = "Ngày Sinh ↑";
                //    SapXepListView_Cach1(true);
                //    dem = 1;
                //}
                //else
                //{
                //    lvCaSi.Columns["NgaySinh"].Text = "Ngày Sinh ↓";
                //    SapXepListView_Cach1(false);
                //    dem = 0;
                //}
                SapXepListView_Cach2();

                //SapXepListView_Cach1();

                //cmbGomNhom_SelectedIndexChanged(sender, EventArgs.Empty);

                //if (lvCaSi.ShowGroups == true)
                //{
                //    cmbGomNhom_SelectedIndexChanged(sender, EventArgs.Empty);
                //}

                sw.Stop();
                //DateTime end = DateTime.Now;

                //MessageBox.Show("Chạy mất: " + (end - start).TotalMilliseconds.ToString());
                //MessageBox.Show("Chạy mất: " + sw.Elapsed.TotalMilliseconds.ToString());
            }
        }

        private void SapXepListView_Cach2()
        {
            if (dem == 0)
            {
                SapXepTrucTiepListView(true);
                dem = 1;
            }
            else
            {
                SapXepTrucTiepListView(false);
                dem = 0;
            }
        }

        void HoanVi2itemTrenListView(ListViewItem a, ListViewItem b, ListView lv)
        {
            for (int i = 0; i < lv.Columns.Count; ++i)
                a.SubItems[i].Text = b.SubItems[i].Text;
        }

        private void SapXepTrucTiepListView(bool kieusapxep)
        {
            /*
                // Làm thí nghiệm để chứng minh khi gán ListViewItem lvi_i = lvCaSi.Items[i]; thì cả 2 đang nằm cùng 1 vị trí bộ nhớ
                //ListViewItem lvi = lvCaSi.Items[0]; // Làm thế này là sẽ bị lỗi vì cả 2 nằm cùng 1 vùng nhớ
                
                // Chúng ta phải tạo mới 1 ListViewItem như thế này và tiến hành sao chép dữ liệu qua
                ListViewItem lvi = new ListViewItem(lvCaSi.Items[0].SubItems[0].Text);
                lvi.SubItems.Add(lvCaSi.Items[0].SubItems[1].Text);
                lvi.SubItems.Add(lvCaSi.Items[0].SubItems[2].Text);
                lvi.SubItems.Add(lvCaSi.Items[0].SubItems[3].Text);

                lvCaSi.Items[0].SubItems[0].Text = "hihihaha";
                //lvi.SubItems[0].Text = "hoho";

                MessageBox.Show(lvi.SubItems[0].Text + " - " + lvi.SubItems[1].Text + " - "
                    + lvi.SubItems[2].Text + " - " + lvi.SubItems[3].Text);
                */

            // Cách 2: Sắp xếp trực tiếp trên ListView

            for (int k = 0; k < lvCaSi.Groups.Count; ++k)
            {
                DateTime[] dt = new DateTime[lvCaSi.Groups[k].Items.Count];

                    for (int i = 0; i < lvCaSi.Groups[k].Items.Count; ++i)
                    {
                        string[] s = lvCaSi.Groups[k].Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                        dt[i] = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));
                    }

                    for (int i = 0; i < lvCaSi.Groups[k].Items.Count - 1; ++i)
                    {
                        //string[] s = lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                        //DateTime ngay_i = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));

                        for (int j = i + 1; j < lvCaSi.Groups[k].Items.Count; ++j)
                        {
                            //string[] s1 = lvCaSi.Items[j].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                            //DateTime ngay_j = new DateTime(int.Parse(s1[2]), int.Parse(s1[1]), int.Parse(s1[0]));

                            if (DateTime.Compare(dt[i], dt[j]) > 0 == kieusapxep)
                            {
                                // Hoán vị item[i] và item[j]
                                ListViewItem lvi_i = null, lvi_j = null;
                                GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Groups[k].Items[i], lvCaSi);
                                //GanDuLieu2itemTrenListView(ref lvi_j, lvCaSi.Items[j], lvCaSi);

                                // Khác hoàn toàn với việc gán int temp = a[i]; // với a[i] là 1 số nguyên

                                // Xóa thằng nào thì tiến hành insert ngay để tránh bị lỗi index khi xóa thằng tiếp theo (do mảng bị thay đổi số lượng phần tử)
                                // 4 dòng code tội lỗi làm chạy quá lâu => làm cách khác đó là thay đổi nội dung của 2 item cần hoán vị với nhau
                                //lvCaSi.Items.RemoveAt(i);
                                //lvCaSi.Items.Insert(i, lvi_j);

                                //lvCaSi.Items.RemoveAt(j);
                                //lvCaSi.Items.Insert(j, lvi_i);

                                // Thay đổi lại giá trị của 2 item cho nhau
                                //lvCaSi.Items[i].SubItems[0].Text = lvCaSi.Items[j].SubItems[0].Text;
                                //lvCaSi.Items[i].SubItems[1].Text = lvCaSi.Items[j].SubItems[1].Text;
                                //lvCaSi.Items[i].SubItems[2].Text = lvCaSi.Items[j].SubItems[2].Text;
                                //lvCaSi.Items[i].SubItems[3].Text = lvCaSi.Items[j].SubItems[3].Text;

                                //lvCaSi.Items[j].SubItems[0].Text = lvi_i.SubItems[0].Text;
                                //lvCaSi.Items[j].SubItems[1].Text = lvi_i.SubItems[1].Text;
                                //lvCaSi.Items[j].SubItems[2].Text = lvi_i.SubItems[2].Text;
                                //lvCaSi.Items[j].SubItems[3].Text = lvi_i.SubItems[3].Text;

                                HoanVi2itemTrenListView(lvCaSi.Groups[k].Items[i], lvCaSi.Groups[k].Items[j], lvCaSi);
                                HoanVi2itemTrenListView(lvCaSi.Groups[k].Items[j], lvi_i, lvCaSi);

                                // Hoán vị dt[i] và dt[j] với nhau
                                DateTime temp = dt[i];
                                dt[i] = dt[j];
                                dt[j] = temp;
                            }
                        }
                    }
            }

            
        }

        private void SapXepListView_Cach1(bool sapxep)
        {
            if (lvCaSi.Groups.Count == 0)
            {
                //MessageBox.Show("aaa");
                Sort2TruongHop(sapxep, lvCaSi.Items, null);
            }
            else
            {
                //MessageBox.Show("bbb");
                for (int k = 0; k < lvCaSi.Groups.Count; ++k)
                {
                    Sort2TruongHop(sapxep, lvCaSi.Groups[k].Items, lvCaSi.Groups[k]);
                }
            }
        }

        private void Sort2TruongHop(bool sapxep, ListView.ListViewItemCollection lvi_collection, ListViewGroup lvgr)
        {
            //DateTime start = DateTime.Now;
            // Bước 1
            //List<CaSi> lst = DoDuLieuTuListViewXuongCollectionList();
            //DateTime end = DateTime.Now;

                // Bước 1
                List<CaSi> lst = new List<CaSi>();

                // Duyệt danh sách ListView qua từng Item
                for (int i = 0; i < lvi_collection.Count; ++i)
                {
                    string hoten = lvi_collection[i].SubItems[0].Text;
                    string nghedanh = lvi_collection[i].SubItems[1].Text;
                    string gioitinh = lvi_collection[i].SubItems[2].Text;

                    string[] s = lvi_collection[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');
                    DateTime ngaysinh = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));

                    CaSi cs = new CaSi(hoten, nghedanh, gioitinh, ngaysinh);

                    lst.Add(cs);
                }

                // Bước 2
                //if (dem == 0)
                //{
                //    CaSi.SapXepTheoNgaySinh(lst, sapxep);
                //    dem = 1;
                //}
                //else
                //{
                //    CaSi.SapXepTheoNgaySinh(lst, sapxep);
                //    dem = 0;
                //}
                CaSi.SapXepTheoNgaySinh(lst, sapxep);

                //int n = lst.Count;

                //for (int i = 0; i < n - 1; ++i)
                //{
                //    for (int j = i + 1; j < n; ++j)
                //    {
                //        if (DateTime.Compare(lst[i].NgaySinh, lst[j].NgaySinh) < 0 == sapxep) // sắp tuổi giảm dần
                //        {
                //            // Hoán vị item[i] và item[j]
                //            ListViewItem lvi_i = null;
                //            GanDuLieu2itemTrenListView(ref lvi_i, lvCaSi.Groups[k].Items[i], lvCaSi);
                //            HoanVi2itemTrenListView(lvCaSi.Groups[k].Items[i], lvCaSi.Groups[k].Items[j], lvCaSi);
                //            HoanVi2itemTrenListView(lvCaSi.Groups[k].Items[j], lvi_i, lvCaSi);
                //        }
                //    }
                //}

                // Bước 3

                //for (int i = 0; i < lvCaSi.Items.Count; ++i)
                //{
                //    if (lvCaSi.Items[i].Group == lvCaSi.Groups[k])
                //    {
                //        lvCaSi.Items[i].Remove();
                //        i--;
                //    }
                //}
                //for (int i = 0; i < lvCaSi.Groups[k].Items.Count; ++i)
                for (int i = lvi_collection.Count - 1; i >= 0; --i)
                {
                    lvCaSi.Items.Remove(lvi_collection[i]);
                    //i--;
                }

                // Duyệt qua từng ca sĩ
                for (int i = 0; i < lst.Count; ++i)
                {
                    ListViewItem lvi = new ListViewItem(lst[i].HoTen);
                    lvi.SubItems.Add(lst[i].NgheDanh);
                    lvi.SubItems.Add(lst[i].GioiTinh);
                    lvi.SubItems.Add(lst[i].NgaySinh.ToString("dd/MM/yyyy"));
                    lvi.Group = lvgr;

                    lvCaSi.Items.Add(lvi);
                }
            






            // Bước 3

            //DateTime start1 = DateTime.Now;

            //// Reset danh sách ListView
            //lvCaSi.Items.Clear();

            //CaSi.LoadDuLieu(lst, lvCaSi);

            //DateTime end1 = DateTime.Now;

            // MessageBox.Show("Bước 1 mất: " + (end - start).TotalMilliseconds.ToString() + "\nBước 3 mất: " + (end1 - start1).TotalMilliseconds.ToString());
        }

        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            TimKiem_Cach2();
            //sw.Stop();

            //MessageBox.Show("Chạy mất: " + sw.Elapsed.TotalMilliseconds.ToString());
        }

        // Tìm kiếm bằng cách đổ dữ liệu xuống Collection List và từ đó tìm kiếm trên Collection rồi đối chiếu index
        private void TimKiem_Cach2()
        {
            // Reset màu các item trên ListView
            foreach (ListViewItem lvi in lvCaSi.Items)
                lvi.BackColor = lvCaSi.BackColor;

            List<CaSi> lst = DoDuLieuTuListViewXuongCollectionList();

            int ketqua = CaSi.TimKiemCaSiTheoNgheDanh(lst, txtTimKiem.Text);

            if (ketqua == -1)
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
            else
            {
                // Đã tìm thấy => tô vàng dòng dữ liệu trên ListView
                lvCaSi.Items[ketqua].BackColor = Color.Yellow;
            }
        }

        // Tìm kiếm trực tiếp trên ListView
        private void TimKiem_Cach1()
        {
            // Reset màu các item trên ListView
            foreach (ListViewItem lvi in lvCaSi.Items)
                lvi.BackColor = lvCaSi.BackColor;

            string dulieucantim = CaSi.ChuanHoaDuLieu(txtTimKiem.Text);

            bool Check = false; // Khởi tạo ban đầu là false

            // Duyệt qua từng item trên ListView
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                string dulieu = CaSi.ChuanHoaDuLieu(lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgheDanh"].Index].Text);

                // Chuẩn hóa cả 2 dữ liệu về cùng 1 dạng giống nhau đó là
                // viết thường, mỗi từ đúng 1 khoảng trắng, không có khoảng trắng đầu/cuối chuỗi

                //MessageBox.Show("dulieu = " + dulieu + "\ndulieucantim = " + dulieucantim);

                if (dulieu == dulieucantim)
                {
                    // Đã tìm thấy => tô vàng dòng dữ liệu trên ListView
                    lvCaSi.Items[i].BackColor = Color.Yellow;
                    Check = true; // Cập nhật cờ hiệu là true nếu tìm thấy
                    break; // Thoát khỏi vòng lặp không cần tìm nữa vì dữ liệu chỉ có duy nhất 1 mà thôi
                }
            }
            if (Check == false)
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiem.PerformClick(); // Tự động gọi tới Button tìm kiếm
        }

        private void chkChonCaSiYeuThich_CheckedChanged(object sender, EventArgs e)
        {
            //lvCaSi.CheckBoxes = chkChonCaSiYeuThich.Checked;
            //btnXacNhan.Enabled = chkChonCaSiYeuThich.Checked;
            //chkAll.Visible = chkChonCaSiYeuThich.Checked;

            lvCaSi.CheckBoxes = btnXacNhan.Enabled = chkAll.Visible = chkChonCaSiYeuThich.Checked;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string str = "";
            
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                if (lvCaSi.Items[i].Checked == true) // item đang được chọn
                {
                    str += "Họ tên: " + lvCaSi.Items[i].SubItems[lvCaSi.Columns["HoTen"].Index].Text;
                    str += "\nNghệ Danh: " + lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgheDanh"].Index].Text;
                    str += "\nGiới Tính: " + lvCaSi.Items[i].SubItems[lvCaSi.Columns["GioiTinh"].Index].Text;
                    str += "\nNgày Sinh: " + lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text;
                    str += "\n================================\n";
                }
            }
            if (str == "")
            {
                str = "Bạn chưa chọn ca sĩ yêu thích nào cả";
            }
            MessageBox.Show(str, "Tính năng chọn ca sĩ yêu thích", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void TaoGroupTuDongTheoGioiTinh()
        {
            // Kết hợp bước 1 và bước 2
            for (int i = 0; i < lvCaSi.Items.Count; ++i)
            {
                //MessageBox.Show("xxx");
                string gioitinh = lvCaSi.Items[i].SubItems[lvCaSi.Columns["GioiTinh"].Index].Text;

                // Kiểm tra xem đã có group thuộc giới tính này chưa?
                bool Check = false; // Mặc định là chưa có

                for (int j = 0; j < lvCaSi.Groups.Count; ++j)
                {
                    if (lvCaSi.Groups[j].Header == gioitinh)
                    {
                        Check = true; // Đã có tồn tại group
                        lvCaSi.Items[i].Group = lvCaSi.Groups[j];
                        break;
                    }
                }
                if (Check == false) // không tồn tại group => lúc này sẽ tạo mới
                {
                    lvCaSi.Groups.Add(new ListViewGroup(gioitinh));

                    lvCaSi.Items[i].Group = lvCaSi.Groups[lvCaSi.Groups.Count - 1];
                }
            }

            // Bước 3: Show group lên
            lvCaSi.ShowGroups = true;
        }

        private void cmbGomNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset group
            //lvCaSi.ShowGroups = true;
            lvCaSi.Groups.Clear();


            // Cách 1: Tạo tự động group
            if (cmbGomNhom.SelectedIndex == 1) // giới tính
            {
                //Stopwatch sw = new Stopwatch();
                //sw.Start();
                TaoGroupTuDongTheoGioiTinh();
                //sw.Stop();

                //MessageBox.Show("Tạo Tự Động Chạy mất: " + sw.Elapsed.TotalMilliseconds.ToString());
            }

            // Cách 2: Tạo sẵn group
            /*
            if (cmbGomNhom.SelectedIndex == 1) // giới tính
            {
                // xử lý
                // Bước 1: Tạo group
                //ListViewGroup lvg_Nam = new ListViewGroup("Nam");
                //ListViewGroup lvg_Nu = new ListViewGroup("Nữ");

                //lvCaSi.Groups.Add(lvg_Nam);
                //lvCaSi.Groups.Add(lvg_Nu);

                // Làm gộp
                //Stopwatch sw = new Stopwatch();
                //sw.Start();
                lvCaSi.Groups.Add(new ListViewGroup("Nam"));
                lvCaSi.Groups.Add(new ListViewGroup("Nữ"));

                // Bước 2: Đưa item vào group

                // Duyệt qua các item trên ListView xét xem item đó thuộc group nào thì đưa vào group tương ứng
                for (int i = 0; i < lvCaSi.Items.Count; ++i)
                {
                    if (lvCaSi.Items[i].SubItems[lvCaSi.Columns["GioiTinh"].Index].Text == "Nam")
                    {
                        lvCaSi.Items[i].Group = lvCaSi.Groups[0]; // Group Nam
                    }
                    else
                    {
                        lvCaSi.Items[i].Group = lvCaSi.Groups[1]; // Group Nam
                    }
                }

                // Bước 3: Show group lên
                lvCaSi.ShowGroups = true;
                //sw.Stop();

                //MessageBox.Show("Tạo Sẵn Group Chạy mất: " + sw.Elapsed.TotalMilliseconds.ToString());

                // Sau khi đã gom được theo các group thì nếu muốn xét các item thuộc cùng 1 group nào đó chúng ta làm như sau

                // Vd: Xét các item thuộc group Nam/Nữ
                //string s = "";

                //foreach(ListViewItem lvi in lvCaSi.Groups[1].Items)
                //{
                //    s += "Họ tên: " + lvi.SubItems[lvCaSi.Columns["HoTen"].Index].Text;
                //    s += "\nNghệ Danh: " + lvi.SubItems[lvCaSi.Columns["NgheDanh"].Index].Text;
                //    s += "\nGiới Tính: " + lvi.SubItems[lvCaSi.Columns["GioiTinh"].Index].Text;
                //    s += "\nNgày Sinh: " + lvi.SubItems[lvCaSi.Columns["NgaySinh"].Index].Text;
                //    s += "\n================================\n";
                //}
                //MessageBox.Show("Gom theo group: " + lvCaSi.Groups[1].Header + "\n\n" + s);
            }
            */
            else if (cmbGomNhom.SelectedIndex == 2) // Năm Sinh (6x, 7x, 8x, 9x)
            {
                // xử lý
                // Bước 1: Tạo group
                //lvCaSi.Groups.Add(new ListViewGroup("Sinh Năm 6x"));
                //lvCaSi.Groups.Add(new ListViewGroup("Sinh Năm 7x"));
                //lvCaSi.Groups.Add(new ListViewGroup("Sinh Năm 8x"));
                //lvCaSi.Groups.Add(new ListViewGroup("Sinh Năm 9x"));

                for (int i = 0; i < 10; ++i)
                {
                    lvCaSi.Groups.Add(new ListViewGroup("Sinh Năm " + i.ToString() + "x"));
                }

                // Bước 2: Đưa item vào group

                // Duyệt qua các item trên ListView xét xem item đó thuộc group nào thì đưa vào group tương ứng
                for (int i = 0; i < lvCaSi.Items.Count; ++i)
                {
                    string[] str = lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');

                    //int namsinh = int.Parse(str[2]);

                    //if (namsinh >= 1960 && namsinh < 1970) // 6x
                    //    lvCaSi.Items[i].Group = lvCaSi.Groups[0];
                    //else if (namsinh >= 1970 && namsinh < 1980) // 7x
                    //    lvCaSi.Items[i].Group = lvCaSi.Groups[1];
                    //else if (namsinh >= 1980 && namsinh < 1990) // 8x
                    //    lvCaSi.Items[i].Group = lvCaSi.Groups[2];
                    //else if (namsinh >= 1990 && namsinh < 2000) // 9x
                    //    lvCaSi.Items[i].Group = lvCaSi.Groups[3];

                    /*
                     cứ 100 năm thì lại reset về lại 0x
                     0 -> 9: 0x
                     10 - 19: 1x
                     20 -> 29: 2x
                     30 -> 39: 3x
                     ...
                     90 -> 99: 9x
                     */
                    // => Cứ xét 2 số cuối là biết sinh năm bao nhiêu x (vd: 1994 => 94 => 9x, 1945 => 45 => 4
                    lvCaSi.Items[i].Group = lvCaSi.Groups[int.Parse(str[2][2].ToString())];
                }

                // Bước 3: Show group lên
                lvCaSi.ShowGroups = true;
            }
            else if (cmbGomNhom.SelectedIndex == 3) // Tháng Sinh
            {
                // xử lý
                // Bước 1: Tạo group

                // Hiểu là luôn có 12 tháng => tạo ra 12 group tương ứng
                for (int i = 1; i <= 12; ++i)
                {
                    lvCaSi.Groups.Add(new ListViewGroup("Sinh vào tháng: " + i.ToString()));
                }

                // Bước 2: Đưa item vào group

                // Duyệt qua các item trên ListView xét xem item đó thuộc group nào thì đưa vào group tương ứng
                for (int i = 0; i < lvCaSi.Items.Count; ++i)
                {
                    string[] str = lvCaSi.Items[i].SubItems[lvCaSi.Columns["NgaySinh"].Index].Text.Split('/');

                    int thangsinh = int.Parse(str[1]);

                    lvCaSi.Items[i].Group = lvCaSi.Groups[thangsinh - 1];
                }

                // Bước 3: Show group lên
                lvCaSi.ShowGroups = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Mạnh hơn this.Close()
        }

        private void lvCaSi_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvCaSi.GetItemAt(e.X, e.Y);

            if (item == null) // không phải là item => reset groupbox thông tin ca sĩ lại
            {
                txtHoTen.ResetText();
                txtNgheDanh.ResetText();
                cmbGioiTinh.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Now;
            }
        }

        private void lvCaSi_MouseMove(object sender, MouseEventArgs e)
        {
            //label5.Text = "X = " + e.X + "\nY = " + e.Y;
        }
    }
}
