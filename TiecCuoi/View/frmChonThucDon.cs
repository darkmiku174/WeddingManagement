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
    public partial class frmChonMenu : Form
    {
        private string maCTHD = "";
        bool[] statusCheckOfCB;
        List<ThucAn> menu = new List<ThucAn>();
        public frmChonMenu(string maCTHD)
        {
            InitializeComponent();
            this.maCTHD = maCTHD;
            LoadMatrix();
        }
        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            menu = dp.MenuSelectAll();
            statusCheckOfCB = new bool[menu.Count];
            List<string> dsMaMonAn = dp.DSCTMenuSelectFollowMaCTHD(maCTHD);
            bool checkExist = false;
            if (dsMaMonAn != null && dsMaMonAn.Count > 0)
                checkExist = true;
            foreach (ThucAn ta in menu)
            {
                CheckBox cb = new CheckBox { Width = 20, Height = 20,Location=new Point(0,0) };
                Label lb = new Label { Text = ta.TenMonAn, Location = new Point(20, 0), AutoSize = true };
                Panel pn = new Panel();
                if(checkExist)
                    foreach(string ma in dsMaMonAn)
                        if(ma==ta.MaMonAn)
                        {
                            cb.Checked = true;
                            cb.Enabled = false;
                        }
                pn.Controls.Add(cb);
                pn.Controls.Add(lb);
                cb.CheckedChanged += (sender, e) => CheckChange(sender, e, ta.MaMonAn);
                flpanelCheckBox.Controls.Add(pn);
            }
            
        }

        private void CheckChange(object sender, EventArgs e, string maMonAn)
        {
            for (int i = 0; i < menu.Count; i++)
                if (menu[i].MaMonAn == maMonAn)
                    statusCheckOfCB[i] = !statusCheckOfCB[i];
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            for (int i = 0; i < menu.Count; i++)
                if (statusCheckOfCB[i])
                    if (!dp.DSCTMenuAdd(maCTHD, menu[i].MaMonAn))
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
