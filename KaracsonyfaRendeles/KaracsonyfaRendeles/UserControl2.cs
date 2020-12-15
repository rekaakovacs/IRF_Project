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
    public partial class UserControl2 : UserControl
    {
        KaracsonyfaEntities context = new KaracsonyfaEntities();
        public UserControl2()
        {
            InitializeComponent();

            tipus();
            meret();
            darab();
            
        }

        //setter ág darabszámhoz

        //Választási lehetőségek
        private void tipus()
        {
            var tipus = from t in context.Tipus
                      select t;
            comboBoxtipus.DataSource = tipus.ToList();
            comboBoxtipus.DisplayMember = "tipusnev";
            comboBoxtipus.ValueMember = "tipus_id";
        }

        private void meret()
        {
            var meret = from m in context.Meret
                        select m;
            comboBoxmeret.DataSource = meret.Distinct().ToList();
            comboBoxmeret.DisplayMember = "meretnev";
            comboBoxmeret.ValueMember = "meret_id";
        }

        private void darab()
        {
            darabButton db = new darabButton();
            db.Top = 140;
            db.Left = 100;
            this.Controls.Add(db);
        }

      

        private void mentes_Click(object sender, EventArgs e)
        {
            Ugyfel u = new Ugyfel();
            Rendeles r = new Rendeles();

            if (ugyfelnev.Text != "" && telefonszam.Text != "" && email.Text != "" && irszam.Text != "" && telepules.Text != "" && utca.Text != "" && hazszam.Text != "" && felhasznalonev.Text != "" && jelszo.Text != "")
            {

                u.nev = ugyfelnev.Text;
                u.telefon = telefonszam.Text;
                u.email = email.Text;
                u.irszam = irszam.Text;
                u.varos = telepules.Text;
                u.utca = utca.Text;
                u.hazszam = hazszam.Text;
                u.username = felhasznalonev.Text;
                u.password = jelszo.Text;

                context.Ugyfel.Add(u);

               
                r.ugyfel_fk = u.ugyfel_id;
                r.fenyo_fk = ((Tipus)comboBoxtipus.SelectedItem).tipus_id;
                //r.datum = TextBoxdatum.Text;
                r.fizmod = comboBoxfizmod.Text;

                context.Rendeles.Add(r);

               

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Sikeres rendelés! Kérlek töltsd le a számlád!");
                    mentes.Enabled = false;
                    letoltes.Visible = true;
                    if (letoltes.Visible == true)
                    {
                        comboBoxmeret.Enabled = false;
                        comboBoxtipus.Enabled = false;
                        comboBoxfizmod.Enabled = false;
                       
                        TextBoxdatum.Enabled = false;
                        ugyfelnev.Enabled = false;
                        telefonszam.Enabled = false;
                        email.Enabled = false;
                        irszam.Enabled = false;
                        telepules.Enabled = false;
                        utca.Enabled = false;
                        hazszam.Enabled = false;
                     
                        felhasznalonev.Enabled = false;
                        jelszo.Enabled = false;

                    }



                }
                catch (Exception)
                {

                    MessageBox.Show("A rendelés sikertelen volt, próbáld újra!");
                }
            }
            else
            {
                MessageBox.Show("Minden adatot ki kell tölteni!");
            }

        }

        private void megse_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }
    }
}
