using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class Sanh
    {
        private string maSanh;
        private string tenSanh;
        private byte[] hinhAnh;
        private int soTienCoc;
        private string moTa;

        public string MaSanh { get => maSanh; set => maSanh = value; }
        public string TenSanh { get => tenSanh; set => tenSanh = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int SoTienCoc { get => soTienCoc; set => soTienCoc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
