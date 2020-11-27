using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiecCuoi.Model;
using System.IO;

namespace TiecCuoi
{
    public partial class frmSanh : Form
    {
        public frmSanh()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            List<Sanh> dsSanh = dp.SanhSelectAll();
            foreach (Sanh s in dsSanh)
            {
                PictureBox pb = new PictureBox { Width = 405, Height = 250 };
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                if (s.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(s.HinhAnh);
                    pb.Image = Image.FromStream(ms);
                }
                pb.Click += (sender, e) => ShowInforClick(sender, e, s.MaSanh, s.TenSanh, s.SoTienCoc, s.MoTa);
                flpanelHinhAnhSanh.Controls.Add(pb);
            }
        }
        private void ShowInforClick(object sender, EventArgs e, string maSanh, string tenSanh, int soTienCoc, string moTa)
        {
            lbMaSanh.Text = maSanh;
            lbTenSanh.Text = tenSanh;
            lbSoTienCoc.Text = MoneyNeedToBuy(soTienCoc);
            tbMoTa.Text = moTa;
        }
        private string MoneyNeedToBuy(int tien)
        {
            string result = "";
            int money = tien;
            int numDigit = money.ToString().Count();
            for (int i = numDigit - 1; i >= 0; i--)
            {
                result += money.ToString()[numDigit - 1 - i];
                if (i % 3 == 0 && i > 0)
                    result += ".";
            }
            result += " VND";
            return result;
        }
    }
}
