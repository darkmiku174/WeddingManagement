using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
        public bool CTDatCocAdd(string maCTDC, string maSanh, int ca, DateTime ngayToChuc, int soTienCoc)
        {
            string queryString =
                 @"Insert into CTDATCOC 
                  Values(@MaCTDC, @MaSanh, @Ca, @NgayToChuc, @SoTienCoc)";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaCTDC", maCTDC);
                command.Parameters.AddWithValue("@MaSanh", maSanh);
                command.Parameters.AddWithValue("@Ca", ca);
                command.Parameters.AddWithValue("@NgayToChuc", ngayToChuc);
                command.Parameters.AddWithValue("@SoTienCoc", soTienCoc);
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
        public string TimMaSanh(string tenSanh)
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
                }
            }
            return maSanh;
        }
    }
}
