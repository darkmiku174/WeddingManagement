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


namespace TiecCuoi
{
    public partial class frmChonDichVu : Form
    {
        private string maCTHD="";
        bool[] statusCheckOfCB;
        List<DichVu> dsDV = new List<DichVu>();
        public frmChonDichVu(string maCTHD)
        {
            InitializeComponent();
            this.maCTHD = maCTHD;
            LoadMatrix();
        }

        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            dsDV = dp.DichVuSelectAll();
            statusCheckOfCB = new bool[dsDV.Count];
            List<string> dsMaDV = dp.DSCTDVSelectFollowMaCTHD(maCTHD);
            bool checkExist = false;
            if (dsMaDV != null && dsMaDV.Count > 0)
                checkExist = true;
            foreach (DichVu dv in dsDV)
            {
                CheckBox cb = new CheckBox { Width = 20, Height = 20, Location = new Point(0, 0) };
                Label lb = new Label { Text = dv.TenDichVu, Location = new Point(20, 0), AutoSize = true };
                Panel pn = new Panel();
                if (checkExist)
                    foreach (string ma in dsMaDV)
                        if (ma == dv.MaDichVu)
                        {
                            cb.Checked = true;
                            cb.Enabled = false;
                        }
                pn.Controls.Add(cb);
                pn.Controls.Add(lb);
                cb.CheckedChanged += (sender, e) => CheckChange(sender, e, dv.MaDichVu);
                flpanelCheckBox.Controls.Add(pn);
            }
        }
        private void CheckChange(object sender, EventArgs e, string maDV)
        {
            for (int i = 0; i < dsDV.Count; i++)
                if (dsDV[i].MaDichVu == maDV)
                    statusCheckOfCB[i] = !statusCheckOfCB[i];
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            for (int i = 0; i < dsDV.Count; i++)
                if (statusCheckOfCB[i])
                    if (!dp.DSCTDVAdd(maCTHD, dsDV[i].MaDichVu))
                    { 
                        MessageBox.Show("Lưu thất bại");
                        return;
                    }
            MessageBox.Show("Lưu thành công");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
