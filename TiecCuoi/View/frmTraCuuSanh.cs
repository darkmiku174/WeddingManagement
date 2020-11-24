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
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            
            for (int i = 0; i < Cons.DayOfColumn; i++) 
            {
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y );

                    panelMatrix.Controls.Add(btn);
                    oldBtn = btn;
                }
                oldBtn= new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y+ Cons.dateButtonHeight) };
            }
        }
    }
}

