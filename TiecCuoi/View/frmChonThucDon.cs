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
        public frmChonMenu()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void LoadMatrix()
        {

            DataProvider dp = new DataProvider();
            List<ThucAn> menu = dp.MenuSelectAll();
            foreach (ThucAn ta in menu)
            {
                CheckBox cb = new CheckBox { Width = 20, Height = 20,Location=new Point(0,0) };
                Label lb = new Label { Text = ta.TenMonAn, Location = new Point(20, 0), AutoSize = true };
                Panel pn = new Panel();
                pn.Controls.Add(cb);
                pn.Controls.Add(lb);
                flpanelCheckBox.Controls.Add(pn);
            }
        }
    }
}
