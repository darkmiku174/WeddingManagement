using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiecCuoi
{
    public partial class frmLapHopDongTiecCuoi : Form
    {
        public frmLapHopDongTiecCuoi()
        {
            InitializeComponent();
        }

        private void btnChonThucDon_Click(object sender, EventArgs e)
        {
            frmChonMenu frmCMenu = new frmChonMenu();
            frmCMenu.Show();
        }

        private void btnChonDichVu_Click(object sender, EventArgs e)
        {
            frmChonDichVu frmCDV = new frmChonDichVu();
            frmCDV.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
