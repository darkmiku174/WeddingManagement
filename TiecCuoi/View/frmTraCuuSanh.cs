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
        #region Properties
        private List<List<Button>> matrix;

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sunday" };

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        #endregion
        public frmTraCuuSanh()
        {
            InitializeComponent();

            //LoadMatrix();

        }


        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y);

                    panelMatrix.Controls.Add(btn);

                    Matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            AddNumberIntoMatrixByDate(dtpDate.Value);
        }

        // Thêm số ngày vào các button đã tạo//
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            DateTime useDate = new DateTime(date.Year, date.Month, 1);


            int line = 0;

            for (int i = 1; i < DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }
    }
}
