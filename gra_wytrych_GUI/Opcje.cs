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
    public partial class Opcje : Form
    {
        public Opcje()
        {
            InitializeComponent();
        }

        private void RbtnLatwy_CheckedChanged(object sender, EventArgs e)
        {
            Szansa.SetSzansaLatwy();
        }

        private void RbtnSredni_CheckedChanged(object sender, EventArgs e)
        {
            Szansa.SetSzansaSredni();
        }

        private void RbtnTrudny_CheckedChanged(object sender, EventArgs e)
        {
            Szansa.SetSzansaTrudny();
        }

        public void CheckLevel()
        {
            if (RbtnTrudny.Checked == true)
            {
                Szansa.SetSzansaTrudny();
            }
            else if(RbtnSredni.Checked == true)
            {
                Szansa.SetSzansaSredni();
            }
            else
            {
                Szansa.SetSzansaLatwy();
            }

            
        }

        private void BtnZapisz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
