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
        private void frmDatCoc_Load(object sender, EventArgs e)
        {
            rdbSang.Checked = true;
            tbSoTienCoc.Enabled = false;
            LoadTenSanh();
            LoadMaNhanVien();
            LoadSoTienCoc();
        }

        private void LoadTenSanh()
        {
            DataProvider dp = new DataProvider();
            List<string> dsTenSanh = dp.SanhSelectName();
            cmbSanh.DataSource = dsTenSanh;
        }

        private void LoadMaNhanVien()
        {
            DataProvider dp = new DataProvider();
            List<string> dsMaNV = dp.NhanVienSelectMaNV();
            cmbMaNhanVien.DataSource = dsMaNV;
        }

        private void LoadSoTienCoc()
        {
            DataProvider dp = new DataProvider();
            string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.SanhSelectMaSanh(tenSanh);
            int soTienCoc = dp.SanhSelectSoTienCoc(maSanh);
            tbSoTienCoc.Text = MoneyNeedToBuy(soTienCoc);
            tbSoTienCoc.Enabled = false;
        }

        private void cmbSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.SanhSelectMaSanh(tenSanh);
            int soTienCoc = dp.SanhSelectSoTienCoc(maSanh);
            tbSoTienCoc.Text = soTienCoc.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string maDatCoc = tbMaDatCoc.Text;
            string maNhanVien = cmbMaNhanVien.SelectedItem.ToString();
            string maKhachHang = tbMaKhachHang.Text;
            string tenKhachHang = tbTenKhachHang.Text;
            string sdt = tbSoDienThoai.Text;
            string email = tbEmail.Text;
            string diaChi = tbDiaChi.Text;
            DateTime ngayDatCoc = DateTime.Now;
            string maCTDC = "CT" + maDatCoc;
            DateTime ngayToChuc = dtpNgayToChuc.Value;
            string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.SanhSelectMaSanh(tenSanh);
            int ca = rdbSang.Checked ? 0 : 1;
            if (dp.KhachHangAdd(maKhachHang, tenKhachHang, sdt, email, diaChi))
                if (dp.CTDatCocAdd(maCTDC, maSanh, ca, ngayToChuc))
                    if (dp.DatCocAdd(maDatCoc, maNhanVien, maKhachHang, ngayDatCoc, maCTDC))
                        MessageBox.Show("Lưu thành công");
                    else
                    {
                        dp.CTDatCocDelete(maCTDC);
                        dp.KhachHangDelete(maKhachHang);
                        MessageBox.Show("Lưu thất bại");
                    }
                else
                {
                    dp.KhachHangDelete(maKhachHang);
                    MessageBox.Show("Lưu thất bại");
                } 
            else
                MessageBox.Show("Lưu thất bại");
        }
        private string MoneyNeedToBuy(int tien)
        {
            string result = "";
            int money = tien;
            int numDigit = money.ToString().Count();
            for (int i = numDigit - 1; i >= 0; i--)
            {
                result += money.ToString()[numDigit - 1 - i];
                if (i % 3 == 0 && i > 0)
                    result += ".";
            }
            result += " VND";
            return result;
        }
    }
}
