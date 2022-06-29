using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_wytrych_GUI
{
    public partial class Form1 : Form
    {
        Gra gra = new Gra();
        Menu menu = new Menu();
        int counter = 0;
        char znak;
        Skrzynia skrzynia = new Skrzynia(new Menu());
        bool fail = false;
        public bool otwartoSkrzynie = false;
        int punkty = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNowaGra_Click(object sender, EventArgs e)
        {
            fail = false;
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(menu);
            LblOutput.Text = "Otwórz skrzynię!";
            //Resetuj();
            BtnLewo.Show();
            BtnPrawo.Show();
        }

        private void BtnLewo_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrawo_Click(object sender, EventArgs e)
        {

        }
    }
}
