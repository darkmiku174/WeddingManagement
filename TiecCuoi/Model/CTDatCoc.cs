using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class CTDatCoc
    {
        private string maCTDC;
        private string maSanh;
        private int ca;
        private DateTime ngayToChuc;

        public string MaCTDC { get => maCTDC; set => maCTDC = value; }
        public string MaSanh { get => maSanh; set => maSanh = value; }
        public int Ca { get => ca; set => ca = value; }
        public DateTime NgayToChuc { get => ngayToChuc; set => ngayToChuc = value; }
    }
}
