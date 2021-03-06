﻿using System;
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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            List<DichVu> dsDV = dp.DichVuSelectAll();
            foreach (DichVu dv in dsDV)
            {
                PictureBox pb = new PictureBox { Width = 375, Height = 250 };
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                if (dv.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(dv.HinhAnh);
                    pb.Image = Image.FromStream(ms);
                }
                pb.Click += (sender, e) => ShowInforClick(sender, e, dv.MaDichVu, dv.TenDichVu, dv.GiaTien, dv.MoTa);
                flpanelHinhAnhDichVu.Controls.Add(pb);
            }
        }
        private void ShowInforClick(object sender, EventArgs e, string maDichVu, string tenDichVu, int giaTien, string moTa)
        {
            lbMaDichVu.Text = maDichVu;
            lbTenDichVu.Text = tenDichVu;
            lbGiaTien.Text = MoneyNeedToBuy(giaTien);
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
