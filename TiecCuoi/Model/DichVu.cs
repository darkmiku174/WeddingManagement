using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class DichVu
    {
        private string maDichVu;
        private string tenDichVu;
        private byte[] hinhAnh;
        private int giaTien;
        private string moTa;

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
