using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaracsonyfaRendeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFenyok_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);

            userControl1.Dock = DockStyle.Fill;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);

            userControl2.Dock = DockStyle.Fill;
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);

            userControl3.Dock = DockStyle.Fill;
        }
    }
}
