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
        private const char L = 'L';
        private const char P = 'P';
        
        public Form1()
        {
            InitializeComponent();
        }


        int counter = 0;
        char znak;
        Skrzynia skrzynia = new Skrzynia();
        public bool otwartoSkrzynie = false;
        int punkty = 0;

        private void BtnNowaGra_Click(object sender, EventArgs e)
        {
           
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(Szansa.DlugoscSekwencji);
            Resetuj();
            ShowButtons();

        }

        private void ShowButtons()
        {
            BtnLewo.Show();
            BtnPrawo.Show();
            LblLiczbaWytrychow.Show();
            LblLiczbaSkrzyni.Show();
            LblPunkty.Show();
            LblOutput.Show();

        }

        private void BtnLewo_Click(object sender, EventArgs e)
        {
            if (Szansa.IloscWytrychow > 0)
            {
                znak = L;  
                Sprawdz(skrzynia, znak);
                if (otwartoSkrzynie)
                {
                    OtwartoSkrzynie();
                }
            }
            else LblOutput.Text = "Brak wytrychów!\nWciśnij 'Nowa Gra' aby zagrać jeszcze raz!";

        }
        private void BtnPrawo_Click(object sender, EventArgs e)
        {
            if (Szansa.IloscWytrychow > 0)
            {
                znak = P;
                Sprawdz(skrzynia, znak);
                if (otwartoSkrzynie)
                {
                    OtwartoSkrzynie();
                }
            }
            else LblOutput.Text = "Brak wytrychów!\nWciśnij 'Nowa Gra' aby zagrać jeszcze raz!";

        }
        private void OtwartoSkrzynie()
        {
            Szansa.IloscSkrzyni++;
            punkty += Szansa.IloscPunktow;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (Szansa.IloscSkrzyni).ToString();
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(Szansa.DlugoscSekwencji);
        }

        public void Resetuj()
        {
            punkty = 0;
            Szansa.IloscPunktow = 0;
            Szansa.IloscSkrzyni = 0;
            Szansa.IloscWytrychow = Szansa.TempIloscWytrychow;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (Szansa.IloscSkrzyni).ToString();
            LblLiczbaWytrychow.Text = (Szansa.TempIloscWytrychow).ToString();
            LblOutput.Text = "Otwórz skrzynię!";
        }
        private void HideButtons()
        {
            BtnLewo.Hide();
            BtnPrawo.Hide();
            LblLiczbaWytrychow.Hide();
            LblLiczbaSkrzyni.Hide();
            LblOutput.Hide();
            LblPunkty.Hide();
        }

        private int Sprawdz(Skrzynia skrzynia, char znak)
        {

            if (counter < skrzynia.SkrzyniaArray.Length)
            {
                char znakZeSkrzyni = skrzynia.SkrzyniaArray[counter];
                if ((znak == znakZeSkrzyni) && (znak == L || znak == P))
                {
                    LblOutput.Text = "OK";
                    counter++;
                    Szansa.IloscPunktow = skrzynia.GenerujIloscPunktow();
                }
                else if ((znak != znakZeSkrzyni) && (znak == L || znak == P))
                {
                    if (skrzynia.ZlamanieWytrycha(Szansa.Chance))
                    {
                        LblOutput.Text = "Złamany wytrych! Zaczynasz od nowa.";
                        Szansa.IloscWytrychow--;
                        LblLiczbaWytrychow.Text = (Szansa.IloscWytrychow).ToString();
                        counter = 0;

                        if (Szansa.IloscWytrychow == 0)
                        {
                            LblOutput.Text = "Nie masz więcej wytrychów! Koniec Gry!";
                            Szansa.IloscPunktow = 0;
                            return Szansa.IloscPunktow;
                        }
                    }
                    else
                    {
                        LblOutput.Text = "Zły ruch! Zaczynasz od nowa.";
                        counter = 0;
                        Szansa.IloscPunktow = skrzynia.GenerujIloscPunktow();
                    }

                }
                return Szansa.IloscPunktow = skrzynia.GenerujIloscPunktow();
            }
            if (Szansa.IloscWytrychow == 0)
            {

                LblOutput.Text = "Koniec gry! Zdobywasz " + Szansa.IloscPunktow + " punktów!";
            }
            else
            {
                LblOutput.Text = "Otwarto skrzynię! Zdobywasz " + Szansa.IloscPunktow + " punktów!";
                otwartoSkrzynie = true;
                counter = 0;
            }
            return Szansa.IloscPunktow;
        }

        private void BtnOpcje_Click(object sender, EventArgs e)
        {
            Opcje opcje = new Opcje();
            opcje.Show();
            HideButtons();
        }
    }
}
