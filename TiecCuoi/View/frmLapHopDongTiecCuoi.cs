using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiecCuoi.Model;

namespace TiecCuoi
{
    public partial class frmLapHopDongTiecCuoi : Form
    {
        public frmLapHopDongTiecCuoi()
        {
            InitializeComponent();
        }

        private void frmLapHopDongTiecCuoi_Load(object sender, EventArgs e)
        {
            rdbSang.Checked = true;
            tbSoTienCoc.Enabled = false;
            tbTongTienDuKien.Enabled = false;
            LoadTenSanh();
            LoadMaNhanVien();
            LoadMaDatCoc();
            LoadMaKhachHang();
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

        private void LoadMaDatCoc()
        {
            DataProvider dp = new DataProvider();
            List<string> dsMaDC = dp.DatCocSelectMaDC();
            cmbMaDatCoc.DataSource = dsMaDC;
        }

        private void LoadMaKhachHang()
        {
            DataProvider dp = new DataProvider();
            List<string> dsMaKH = dp.KhachHangSelectMaKH();
            cmbMaKhachHang.DataSource = dsMaKH;
        }

        private void LoadSoTienCoc()
        {
            DataProvider dp = new DataProvider();
            string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.SanhSelectMaSanh(tenSanh);
            tbSoTienCoc.Text = MoneyNeedToBuy(dp.SanhSelectSoTienCoc(maSanh));
        }
        private void btnChonThucDon_Click(object sender, EventArgs e)
        {
            string maHopDong = tbMaHopDong.Text;
            string maCTHD = "CT" + maHopDong;
            frmChonMenu frmCMenu = new frmChonMenu(maCTHD);
            frmCMenu.Show();
            frmCMenu.FormClosed += new FormClosedEventHandler(LoadTongTien);
        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            string maHopDong = tbMaHopDong.Text;
            string maCTHD = "CT" + maHopDong;
            frmChonDichVu frmCDV = new frmChonDichVu(maCTHD);
            frmCDV.Show();
            frmCDV.FormClosed += new FormClosedEventHandler(LoadTongTien);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            string maHopDong = tbMaHopDong.Text;
            string maNhanVien = cmbMaNhanVien.SelectedItem.ToString();
            string maKhachHang = cmbMaKhachHang.SelectedItem.ToString();
            DateTime ngayHopDong = DateTime.Now;
            string maCTHD = "CT" + maHopDong;
            DateTime ngayToChuc = dtpNgayToChuc.Value;
            string tenSanh = cmbSanh.SelectedItem.ToString();
            string maSanh = dp.SanhSelectMaSanh(tenSanh);
            int ca = rdbSang.Checked ? 0 : 1;
            int soLuongBan = Int32.Parse(tbSoLuongBan.Text);
            string maKM = tbMaKhuyenMai.Text;
            int soTienCoc = Int32.Parse(tbSoTienCoc.Text);
            //if (dp.KhachHangAdd(maKhachHang, tenKhachHang, sdt, email, diaChi))
            //    if (dp.CTDatCocAdd(maCTDC, maSanh, ca, ngayToChuc))
            //        if (dp.DatCocAdd(maDatCoc, maNhanVien, maKhachHang, ngayDatCoc, maCTDC))
            //            MessageBox.Show("Lưu thành công");
            //        else
            //        {
            //            dp.CTDatCocDelete(maCTDC);

            //            MessageBox.Show("Lưu thất bại 1");
            //        }
            //    else
            //    {
            //        dp.KhachHangDelete(maKhachHang);
            //        MessageBox.Show("Lưu thất bại 2");
            //    }
            //else
            //    MessageBox.Show("Lưu thất bại 3");
        }
        
        private void cmbSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoTienCoc();
        }

        private void LoadTongTien(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soLuongBan = Int32.Parse(tbSoLuongBan.Text);
            string maHopDong = tbMaHopDong.Text;
            string maCTHD = "CT" + maHopDong;
            DataProvider dp = new DataProvider();
            List<string> dsMaDV = dp.DSCTDVSelectFollowMaCTHD(maCTHD);
            if (dsMaDV != null && dsMaDV.Count > 0)
            {
                List<DichVu> dsDV = dp.DichVuSelectAll();
                foreach (string ma in dsMaDV)
                    foreach (DichVu dv in dsDV)
                        if (dv.MaDichVu == ma)
                            tongTien += dv.GiaTien;
            }
            List<string> dsMaMonAn = dp.DSCTMenuSelectFollowMaCTHD(maCTHD);
            if (dsMaMonAn != null && dsMaMonAn.Count > 0)
            {
                List<ThucAn> menu = dp.MenuSelectAll();
                foreach (string ma in dsMaMonAn)
                    foreach (ThucAn ta in menu)
                        if (ta.MaMonAn == ma)
                            tongTien += ta.GiaTien *soLuongBan;
            }
            tbTongTienDuKien.Text= MoneyNeedToBuy(tongTien);
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
