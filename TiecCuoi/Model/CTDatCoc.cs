using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class CTDatCoc
    {
        string maCTDC;
        string maSanh;
        int ca;
        DateTime ngayToChuc;

        public string MaCTDC { get => maCTDC; set => maCTDC = value; }
        public string MaSanh { get => maSanh; set => maSanh = value; }
        public int Ca { get => ca; set => ca = value; }
        public DateTime NgayToChuc { get => ngayToChuc; set => ngayToChuc = value; }
    }
}
