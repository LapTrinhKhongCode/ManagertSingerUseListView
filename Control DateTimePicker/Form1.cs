using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("AAA");
            DateTime dt = dtpNgaySinh.Value;
            //MessageBox.Show("Bạn đang chọn ngày: " + dt.ToString("dd/MM/yyyy"));
            MessageBox.Show("Bạn đang chọn ngày: " + dt.Day
                + " tháng: " + dt.Month + " năm: " + dt.Year);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cách 1:
            //DateTime ngay = new DateTime(2018, 2, 14);
            //dtpNgaySinh.Value = ngay;

            // Cách 2
            string ngay = "3/6/2018";
            dtpNgaySinh.Value = DateTime.Parse(ngay);
        }
    }
}
