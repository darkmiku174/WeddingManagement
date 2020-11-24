using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiecCuoi
{
    public partial class frmDatCoc : Form
    {
        public frmDatCoc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string maDatCoc = tbMaDatCoc.Text;
            string maNhanVien = tbMaNhanVien.Text;
            string maKhachHang = tbMaKhachHang.Text;
            DateTime ngayDatCoc = DateTime.Now;
            string maCTDC = "CT" + maDatCoc;
            DateTime ngayToChuc = dtpNgayToChuc.Value;
            //string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.TimMaSanh("Cancer");
            int ca = rdbSang.Checked ? 0 : 1;
            int soTienCoc = Int32.Parse("100");
            if (dp.CTDatCocAdd(maCTDC, maSanh, ca, ngayToChuc, soTienCoc))
                if (dp.DatCocAdd(maDatCoc, maNhanVien, maKhachHang, ngayDatCoc, maCTDC))
                    MessageBox.Show("Lưu thành công");
                else
                    MessageBox.Show("Lưu thất bại");
            else
                MessageBox.Show("Lưu thất bại");
        }
    }
}
