using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TiecCuoi.Model;

namespace TiecCuoi
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
            LoadMatrix();
        }

        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            List<KhuyenMai> dsKM = dp.KhuyenMaiSelectAll();
            foreach (KhuyenMai km in dsKM)
            {
                PictureBox pb = new PictureBox { Width = 400, Height = 300 };
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                if (km.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(km.HinhAnh);
                    pb.Image = Image.FromStream(ms);
                }
                pb.Click += (sender, e) => ShowInforClick(sender, e, km.MaKhuyenMai, km.TenKhuyenMai, km.UuDai, km.NgayBatDau, km.NgayKetThuc, km.MoTa);
                flpanelHinhAnhKhuyenMai.Controls.Add(pb);
            }
        }
        private void ShowInforClick(object sender, EventArgs e, string maKhuyenMai, string tenKhuyenMai, int uuDai, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa)
        {
            lbMaKhuyenMai.Text = maKhuyenMai;
            lbTenKhuyenMai.Text = tenKhuyenMai;
            lbUuDai.Text = uuDai.ToString();
            dtpNgayBatDau.Value = ngayBatDau;
            dtpNgayKetThuc.Value = ngayKetThuc;
            lbMoTa.Text = moTa;
        }
    }
}
