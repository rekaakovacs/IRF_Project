using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace KaracsonyfaRendeles
{
    public partial class UserControl2 : UserControl
    {

        KaracsonyfaEntities context = new KaracsonyfaEntities();

        //üres váltpzók létrehozása (alkalmazás, munkafüzet, munkalap)
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public UserControl2()
        {
            InitializeComponent();

            tipus();
            meret();
            darab();
            fizmod();

            //CreateExcel();
        }



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
            db.Left = 95;
            this.Controls.Add(db);
        }

        private void fizmod()
        {
            comboBoxfizmod.Items.Add("előre utalás");
            comboBoxfizmod.Items.Add("utánvéttel");
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
                r.datum = Convert.ToDateTime(TextBoxdatum.Text);
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

    
        private void letoltes_Click(object sender, EventArgs e)
        {
            try
            {
                
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                
                CreateTable();
                FormatTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;

            }

            string[] headers;

            void CreateTable()
            {
                
                headers = new string[]
                {

                     "Név",
                     "Telefonszám",
                     "E-mail cím",
                     "Szállítási cím",
                     "Rendelési tétel",
                     "Méret",
                     "Darabszám",
                     "Ár",
                     "Fizetési mód",
                     "Rendelés dátuma"

                };
              

                for (int i = 0; i < headers.Length; i++)
                {
                    xlSheet.Cells[1, i + 1] = headers[i];
                    xlSheet.Cells[2, 1] = ugyfelnev.Text.ToString();
                    xlSheet.Cells[2, 1] = telefonszam.Text.ToString();
                    xlSheet.Cells[2, 1] = email.Text.ToString();
                    xlSheet.Cells[2, 1] = telepules.Text.ToString();
                    xlSheet.Cells[2, 1] = comboBoxtipus.Text.ToString();
                    xlSheet.Cells[2, 1] = comboBoxmeret.Text.ToString();
                    //xlSheet.Cells[2, 1] = db.Text.ToString();
                    //xlSheet.Cells[2, 1] = ugyfelnev.Text.ToString();
                    xlSheet.Cells[2, 1] = comboBoxfizmod.Text.ToString();
                    xlSheet.Cells[2, 1] = TextBoxdatum.Text.ToString();


                }

                
            }

            void FormatTable()
            {

                Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
                headerRange.Font.Bold = true;
                headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerRange.EntireColumn.AutoFit();
                headerRange.RowHeight = 40;
                headerRange.Interior.Color = Color.LightGreen;
                headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            }

            string GetCell(int x, int y)
            {
                string ExcelCoordinate = "";
                int dividend = y;
                int modulo;

                while (dividend > 0)
                {
                    modulo = (dividend - 1) % 26;
                    ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                    dividend = (int)((dividend - modulo) / 26);
                }
                ExcelCoordinate += x.ToString();

                return ExcelCoordinate;
            }
        }
    }
}
