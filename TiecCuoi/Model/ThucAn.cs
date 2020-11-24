using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class ThucAn
    {
        private string maMonAn;
        private string tenMonAn;
        private byte[] hinhAnh;
        private int giaTien;
        private string moTa;

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        
    }
}
