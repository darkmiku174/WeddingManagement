using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiecCuoi.Model
{
    class KhuyenMai
    {
        private string maKhuyenMai;
        private string tenKhuyenMai;
        private byte[] hinhAnh;
        private int uuDai;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string moTa;

        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public string TenKhuyenMai { get => tenKhuyenMai; set => tenKhuyenMai = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int UuDai { get => uuDai; set => uuDai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
