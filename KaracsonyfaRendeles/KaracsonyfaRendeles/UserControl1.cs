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
            
        }


        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush lightgreenBrush = new SolidBrush(Color.LightGreen);


            //nagyméretű

            //fatörzs (téglalap)
            g.FillRectangle(brownBrush, 100, 340, 50, 70);
            
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

            
            e.Graphics.FillPolygon(lightgreenBrush, felso);



            //közepes méretű

            //fatörzs (téglalap)
            g.FillRectangle(brownBrush, 365, 340, 50, 70);

            //alsó háromszög
            Point point10 = new Point(270, 340);
            Point point11 = new Point(400, 230);
            Point point12 = new Point(510, 340);

            Point[] also2 =
            {
                 point10,
                 point11,
                 point12
            };

            
            e.Graphics.FillPolygon(lightgreenBrush, also2);



            //középső háromszög
            Point point13 = new Point(290, 300);
            Point point14 = new Point(390, 190);
            Point point15 = new Point(490, 300);

            Point[] kozepso2 =
            {
                 point13,
                 point14,
                 point15
            };

            e.Graphics.FillPolygon(lightgreenBrush, kozepso2);

            //kisméretű

            //fatörzs (téglalap)
            g.FillRectangle(brownBrush, 630, 340, 50, 70);

            //alsó háromszög
            Point point16 = new Point(533, 340);
            Point point17 = new Point(650, 230);
            Point point18 = new Point(760, 340);

            Point[] also3 =
            {
                 point16,
                 point17,
                 point18
            };


            e.Graphics.FillPolygon(lightgreenBrush, also3);


        }

       
    }
}
