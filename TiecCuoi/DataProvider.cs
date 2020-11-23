using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiecCuoi.DAL;

namespace CNPM_TiecCuoi
{
    class DataProvider
    {
        private TIECCUOIEntities database = new TIECCUOIEntities();

        //Các phương thức truy xuất database của frmDatCoc
        public bool DatCocAdd(string maDatCoc, string maNhanVien, string maKhachHang, DateTime ngayDatCoc)
        { 
            DATCOC dc = database.DATCOCs.Where(d => d.MADC == maDatCoc).SingleOrDefault();
            if (dc != null)
            {
                //MessageBox.Show("Mã sinh viên đã tồn tại");
                return false;
            }
            else
            {
                DATCOC datcoc = new DATCOC();
                datcoc.MADC = maDatCoc;
                datcoc.MANV = maNhanVien;
                datcoc.MAKH = maKhachHang;
                datcoc.NGAYDC = ngayDatCoc;
                datcoc.MACTDC = "123";
                database.DATCOCs.Add(datcoc);
                database.SaveChanges();
                //LoadThongTinSinhVien();
                //MessageBox.Show("Thêm mới sinh viên thành công");
                return true;
            }
        }
    }
}
