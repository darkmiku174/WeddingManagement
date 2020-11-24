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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            LoadMatrix();
        }

        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            List<ThucAn> menu = dp.MenuSelectAll();
            foreach(ThucAn ta in menu)
            {
                PictureBox pb = new PictureBox { Width = 250, Height = 188 };
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                if (ta.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(ta.HinhAnh);
                    pb.Image = Image.FromStream(ms);
                }
                pb.Click += (sender, e) => ShowInforClick(sender, e, ta.MaMonAn, ta.TenMonAn, ta.GiaTien, ta.MoTa);
                flpanelHinhAnhMonAn.Controls.Add(pb);
            }
        }
        private void ShowInforClick(object sender, EventArgs e, string maMonAn, string tenMonAn, int giaTien, string moTa)
        {
            lbMaMonAn.Text = maMonAn;
            lbTenMonAn.Text = tenMonAn;
            lbGiaTien.Text = giaTien.ToString();
            lbMoTa.Text = moTa;
        }
    }
}
