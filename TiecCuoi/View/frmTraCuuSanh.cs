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
    public partial class frmTraCuuSanh : Form
    {
        
        public frmTraCuuSanh()
        {
            InitializeComponent();

            LoadMatrix();

        }


        void LoadMatrix()
        {
            for (int i = 0; i < 31; i++)
            {
                Button btn = new Button() { Width = 124, Height = 70 };
                flpanelMatrix.Controls.Add(btn);
            }

        }
    }         
}