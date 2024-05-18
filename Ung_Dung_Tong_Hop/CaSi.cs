using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ung_Dung_Tong_Hop
{
    class CaSi
    {
        // Khai báo các thuộc tính và cài đặt getter setter cho nó
        public string HoTen { get; set; }
        public string NgheDanh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        // Hàm khởi tạo mặc định
        public CaSi()
        {
            HoTen = NgheDanh = GioiTinh = "";
            NgaySinh = DateTime.Now;
        }

        // Hàm khởi tạo có tham số
        public CaSi(string hoten, string nghedanh, string gioitinh, DateTime ngaysinh)
        {
            this.HoTen = hoten;
            this.NgheDanh = nghedanh;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
        }

        // Phương thức cho ListView add thông tin 1 ca sĩ vào
        public static void AddCaSi(CaSi casi, ListView lv)
        {
            ListViewItem lvi = new ListViewItem(casi.HoTen);
            lvi.SubItems.Add(casi.NgheDanh);
            lvi.SubItems.Add(casi.GioiTinh);
            lvi.SubItems.Add(casi.NgaySinh.ToString("dd/MM/yyyy"));

            lv.Items.Add(lvi);
        }

        // Phương thức load toàn bộ dữ liệu danh sách các ca sĩ lên ListView
        public static void LoadDuLieu(List<CaSi> lst, ListView lv)
        {
            // Duyệt qua từng ca sĩ
            for (int i = 0; i < lst.Count; ++i)
            {
                AddCaSi(lst[i], lv);
            }
        }

        public static void XoaCaSiTheoNgheDanh(List<CaSi> lst, string nghedanh)
        {
            foreach (CaSi cs in lst)
            {
                if (cs.NgheDanh == nghedanh)
                {
                    lst.Remove(cs);
                    break;
                }
            }
        }

        public static void CapNhatCaSiTheoNgheDanh(List<CaSi> lst, string nghedanh, CaSi cs)
        {
            for (int i = 0; i < lst.Count; ++i)
            {
                if (lst[i].NgheDanh == nghedanh)
                {
                    lst[i] = cs;
                    break;
                }
            }
        }

        public static void SapXepTheoNgaySinh(List<CaSi> lst, bool kieusapxep)
        {
            int n = lst.Count;

            for(int i = 0; i < n - 1; ++i)
            {
                for(int j = i + 1; j < n; ++j)
                {
                    if (DateTime.Compare(lst[i].NgaySinh, lst[j].NgaySinh) < 0 == kieusapxep) // sắp tuổi giảm dần
                    {
                        // Hoán vị lst[i] và lst[j]
                        CaSi temp = lst[i];
                        lst[i] = lst[j];
                        lst[j] = temp;
                    }
                }
            }
        }

        // Viết hết tất cả in thường, xóa bỏ khoảng trắng đầu/cuối chuỗi, giữa mỗi từ có đúng 1 khoảng trắng
        public static string ChuanHoaDuLieu(string str)
        {
            str = str.ToLower().Trim();

            string s = "";
            bool Check = false;

            // bằng     kiều  hehe => bằng kiều
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] != ' ')
                {
                    s += str[i];
                    Check = false;
                }
                else
                {
                    if (Check == false)
                        s += " ";

                    Check = true;
                }
            }
            return s;
        }

        public static int TimKiemCaSiTheoNgheDanh(List<CaSi> lst, string nghedanh)
        {
            nghedanh = ChuanHoaDuLieu(nghedanh);

            for (int i = 0; i < lst.Count; ++i)
            {
                string dulieu = ChuanHoaDuLieu(lst[i].NgheDanh);

                if (dulieu == nghedanh)
                {
                    return i;
                }
            }
            return -1; // Không tìm thấy
        }
    }
}
