using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TiecCuoi.Model;

namespace TiecCuoi
{
    class DataProvider
    {
        private readonly string connectionString =
            @"Data Source=Desktop-3KCQBD3\SQLEXPRESS; Database=TIECCUOI; Trusted_Connection=True";

        //Các phương thức truy xuất database của frmDatCoc
        public bool DatCocAdd(string maDatCoc, string maNhanVien, string maKhachHang, DateTime ngayDatCoc, string maCTDatCoc)
        {
            string queryString =
                @"Insert into DATCOC 
                  Values(@MaDC, @MaNV, @MaKH, @NgayDatCoc, @MaCTDC)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaDC", maDatCoc);
                command.Parameters.AddWithValue("@MaNV", maNhanVien);
                command.Parameters.AddWithValue("@MaKH", maKhachHang);
                command.Parameters.AddWithValue("@NgayDatCoc", ngayDatCoc);
                command.Parameters.AddWithValue("@MaCTDC", maCTDatCoc);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public bool CTDatCocAdd(string maCTDC, string maSanh, int ca, DateTime ngayToChuc)
        {
            string queryString =
                 @"Insert into CTDATCOC 
                  Values(@MaCTDC, @MaSanh, @Ca, @NgayToChuc)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTDC", maCTDC);
                command.Parameters.AddWithValue("@MaSanh", maSanh);
                command.Parameters.AddWithValue("@Ca", ca);
                command.Parameters.AddWithValue("@NgayToChuc", ngayToChuc);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public bool KhachHangAdd(string maKH, string tenKH, string sdt, string email, string diaChi)
        {
            string queryString =
                 @"Insert into KHACHHANG 
                  Values(@MaKH, @TenKH, @SDT, @Email, @DiaChi)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaKH", maKH);
                command.Parameters.AddWithValue("@TenKH", tenKH);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DiaChi", email);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public string SanhSelectMaSanh(string tenSanh)
        {
            string maSanh = "";
            string queryString =
                    @"Select MASANH From SANH where TENSANH=@TenSanh";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@TENSANH", tenSanh);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        maSanh = reader[0].ToString();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return maSanh;
        }
        public bool CTDatCocDelete(string maCTDC)
        {
            string queryString =
                  @"Delete from CTDATCOC Where MACTDC=@MaCTDC";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTDC", maCTDC);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public bool KhachHangDelete(string maKH)
        {
            string queryString =
                  @"Delete from KHACHHANG Where MAKH=@MaKH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaKH", maKH);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public List<string> SanhSelectName()
        {
            List<string> dsTenSanh = new List<string>();
            string queryString =
               @"Select TENSANH From SANH";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dsTenSanh.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsTenSanh; 
        }
        public int SanhSelectSoTienCoc(string maSanh)
        {
            int soTienCoc = 0;
            string queryString =
               @"Select SOTIENCOC From SANH Where MASANH=@MaSanh";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaSanh", maSanh);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        soTienCoc=Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
            return soTienCoc;
        }
        public List<string> NhanVienSelectMaNV()
        {
            List<string> dsMaNV = new List<string>();
            string queryString =
               @"Select MANV From NHANVIEN";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dsMaNV.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsMaNV;
        }

        //Các phương thức truy xuất database của frmLapHopDongTiecCuoi
        public List<string> DatCocSelectMaDC()
        {
            List<string> dsMaDC = new List<string>();
            string queryString =
               @"Select MADC From DATCOC";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dsMaDC.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsMaDC;
        }
        public List<string> KhachHangSelectMaKH()
        {
            List<string> dsMaKH = new List<string>();
            string queryString =
               @"Select MAKH From KHACHHANG";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dsMaKH.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsMaKH;
        }
        public bool CTHopDongAdd(string maCTHD, string tenCoDau, string tenChuRe, int soBan, int soTienCoc, int tongTien)
        {
            string queryString =
                 @"Insert into CTHOPDONG 
                  Values(@MaCTHD, @TenCoDau, @TenChuRe, @SoBan, @SoTienCoc, @TongTien)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTHD", maCTHD);
                command.Parameters.AddWithValue("@TenCoDau", tenCoDau);
                command.Parameters.AddWithValue("@TenChuRe", tenChuRe);
                command.Parameters.AddWithValue("@SoBan", soBan);
                command.Parameters.AddWithValue("@SoTienCoc", soTienCoc);
                command.Parameters.AddWithValue("@TongTien", tongTien);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public bool HopDongAdd(string maHD, string maDC, string maNV, string maKH, string maCTHD, DateTime ngayHopDong, string maKM)
        {
            string queryString =
                 @"Insert into HOPDONG 
                  Values(@MaHD, @MaDC, @MaNV, @MaKH, @MaCTHD, @NgayHopDong, @MaKM)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                command.Parameters.AddWithValue("@MaDC", maDC);
                command.Parameters.AddWithValue("@MaNV", maNV);
                command.Parameters.AddWithValue("@MaKH", maKH);
                command.Parameters.AddWithValue("@MaCTHD", maCTHD);
                command.Parameters.AddWithValue("@NgayHopDong", ngayHopDong);
                command.Parameters.AddWithValue("@MaKM", maKM);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public List<CTDatCoc> CTDatCocSelectFollowMaCTDC(string maCTDC)
        {
            List<CTDatCoc> dsCTDC = new List<CTDatCoc>();
            string queryString =
                    @"Select * From CTDATCOC where MACTDC=@MaCTDC";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTDC", maCTDC);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CTDatCoc ctdc = new CTDatCoc();
                        ctdc.MaCTDC = reader[0].ToString();
                        ctdc.MaSanh = reader[1].ToString();
                        ctdc.Ca = Int32.Parse(reader[2].ToString());
                        ctdc.NgayToChuc = DateTime.Parse(reader[3].ToString());
                        dsCTDC.Add(ctdc);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsCTDC;
        }
        public bool CTDatCocUpdate(string maCTDC, string maSanh, int ca, DateTime ngayToChuc)
        {
            string queryString =
                @"Update CTDATCOC  
                  Set MASANH=@MaSanh, CA=@Ca, NGAYTOCHUC=@NgayToChuc
                  Where MACTDC=@MaCTDC";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTDC", maCTDC);
                command.Parameters.AddWithValue("@MaSanh", maSanh);
                command.Parameters.AddWithValue("@Ca", ca);
                command.Parameters.AddWithValue("@NgayToChuc", ngayToChuc);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }

        //Các phương thức truy xuất database của frmMenu
        public List<ThucAn> MenuSelectAll()
        {
            List<ThucAn> menu = new List<ThucAn>();
            string queryString =
                    @"Select * From MENU";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ThucAn ta = new ThucAn();
                        ta.MaMonAn = reader[0].ToString();
                        ta.TenMonAn = reader[1].ToString();
                        ta.HinhAnh = (byte[])reader[2];
                        ta.GiaTien = Int32.Parse(reader[3].ToString());
                        ta.MoTa = reader[4].ToString();
                        menu.Add(ta);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return menu;
        }

        //Các phương thức truy xuất database của frmDichVu
        public List<DichVu> DichVuSelectAll()
        {
            List<DichVu> dsDV = new List<DichVu>();
            string queryString =
                    @"Select * From DICHVU";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DichVu dv = new DichVu();
                        dv.MaDichVu = reader[0].ToString();
                        dv.TenDichVu = reader[1].ToString();
                        dv.HinhAnh = (byte[])reader[2];
                        dv.GiaTien = Int32.Parse(reader[3].ToString());
                        dv.MoTa = reader[4].ToString();
                        dsDV.Add(dv);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return dsDV;
        }
    }
}
