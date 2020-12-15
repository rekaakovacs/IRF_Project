using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaracsonyfaRendeles
{
    class darabButton:Button
    {
        //legfeljebb 5 db karácsonyfát rendelhet
        private int _darab;

        public int Darab
        {
            get { return _darab; }
            set
            {
                _darab = value;
                if (_darab < 0)
                    _darab = 5;
                else if (_darab > 5)
                    _darab = 0;

                if (_darab == 0) Text = "";
                else Text = _darab.ToString();
            }
        }


        public darabButton()
        {
            Height = 30;
            Width = 40;
            BackColor = Color.LightSeaGreen;
            Darab = 0;
            
            MouseClick += DarabButton_MouseClick;
        }

        private void DarabButton_MouseClick(object sender, MouseEventArgs e)
        {
            Darab++;
        }

        
        
    }
}
