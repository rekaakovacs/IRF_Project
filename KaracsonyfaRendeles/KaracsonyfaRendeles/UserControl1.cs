using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaracsonyfaRendeles
{
    public partial class UserControl1 : UserControl
    {
        KaracsonyfaEntities context = new KaracsonyfaEntities();
        public UserControl1()
        {
            InitializeComponent();
            meret();
        }

        private void meret()
        {
            var meret = from m in context.Meret
                        select m;
            comboBoxLuc.DataSource = meret.Distinct().ToList();
            comboBoxLuc.DisplayMember = "meretnev";
            comboBoxLuc.ValueMember = "meret_id";
        }

     

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush lightgreenBrush = new SolidBrush(Color.LightGreen);

            //g.DrawRectangle(p, 100, 340, 50, 100);
            g.FillRectangle(brownBrush, 100, 340, 50, 100);

            //alsó háromszög
            Point point1 = new Point(20, 340);
            Point point2 = new Point(130, 230);
            Point point3 = new Point(240, 340);

            Point[] also =
            {
                 point1,
                 point2,
                 point3
            };

            //e.Graphics.DrawPolygon(p, also);
            e.Graphics.FillPolygon(lightgreenBrush, also);

            //középső háromszög
            Point point4 = new Point(30, 300);
            Point point5 = new Point(130, 190);
            Point point6 = new Point(230, 300);

            Point[] kozepso =
            {
                 point4,
                 point5,
                 point6
            };

            //e.Graphics.DrawPolygon(p, kozepso);
            e.Graphics.FillPolygon(lightgreenBrush, kozepso);

            //felső háromszög
            Point point7 = new Point(40, 260);
            Point point8 = new Point(130, 140);
            Point point9 = new Point(210, 260);

            Point[] felso =
            {
                 point7,
                 point8,
                 point9
            };

            //e.Graphics.DrawPolygon(p, felso);
            e.Graphics.FillPolygon(lightgreenBrush, felso);



        }

        private void comboBoxLuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBoxLuc.Text=="kisméretű")
            {
                
            }
        }
    }
}
