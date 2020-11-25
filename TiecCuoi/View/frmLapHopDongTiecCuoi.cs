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
            tbSoTienCoc.Text = dp.SanhSelectSoTienCoc(maSanh).ToString();
        }
        private void btnChonThucDon_Click(object sender, EventArgs e)
        {
            frmChonMenu frmCMenu = new frmChonMenu();
            frmCMenu.Show();
        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            string maHopDong = tbMaHopDong.Text;
            string maCTHD = "CT" + maHopDong;
            frmChonDichVu frmCDV = new frmChonDichVu(maCTHD);
            frmCDV.Show();
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
        
    }
}
