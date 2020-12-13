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
    public partial class UserControl3 : UserControl
    {
        KaracsonyfaEntities context = new KaracsonyfaEntities();
        public UserControl3()
        {
            InitializeComponent();

            listBox1.DisplayMember = "nev";

            GetUgyfel();
            GetDgw();
        }

        private void GetUgyfel()
        {
            listBox1.DataSource =
                    (
                        from x in context.Ugyfel
                        where x.nev.Contains(textBox1.Text)
                        select x
                    ).ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetUgyfel();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDgw();
        }


        private void GetDgw()
        {
            Ugyfel ugyfel = (Ugyfel)listBox1.SelectedItem;
            var torles = from x in context.Rendeles
                         where x.ugyfel_fk == ugyfel.ugyfel_id
                         select new
                         {
                             Ügyfél = x.Ugyfel.nev,


                         };
            dataGridView1.DataSource = torles.ToList();

            try
            {
                dataGridView1.DataSource = torles.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Ebben az adatbázisban még nem rögzítettünk az ügyfélhez rendelést!");
            }
        }

        private void megse_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }

        private void torles_Click(object sender, EventArgs e)
        {
            try
            {
                Ugyfel ugyfel = (Ugyfel)listBox1.SelectedItem;
                var torles = from x in context.Rendeles
                             where x.ugyfel_fk == ugyfel.ugyfel_id
                             select x;
                context.Rendeles.Remove(torles.FirstOrDefault());
                context.SaveChanges();
                MessageBox.Show("A rendelésed sikeresen törölted!");

            }
            catch (Exception)
            {

                MessageBox.Show("A rendelés törlése sikertelen volt! Próbáld újra!");
            }

            GetUgyfel();
            GetDgw();
        }

        
    }
}
