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
        }

        //Választási lehetőségek
        private void tipus()
        {
            var tipus = from t in context.Fenyo
                      select t;
            comboBoxtipus.DataSource = tipus.Distinct().ToList();
            comboBoxtipus.DisplayMember = "tipus";
            comboBoxtipus.ValueMember = "fenyo_id";
        }

        private void meret()
        {
            var meret = from m in context.Fenyo
                      select m;
            comboBoxmeret.DataSource = meret.Distinct().ToList();
            comboBoxmeret.DisplayMember = "meret";
            comboBoxmeret.ValueMember = "fenyo_id";
        }

        
    }
}
