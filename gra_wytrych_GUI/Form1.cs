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
        Opcje opcje = new Opcje();
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
            opcje.CheckLevel();
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(Szansa.DlugoscSekwencji);
            LblOutput.Text = "Otwórz skrzynię!";
            Resetuj();
            BtnLewo.Show();
            BtnPrawo.Show();

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
            skrzynia.GenerowanieSekwencji(4);
        }
        private void Resetuj()
        {
            punkty = 0;
            Szansa.IloscPunktow = 0;
            Szansa.IloscSkrzyni = 0;
            Szansa.IloscWytrychow = Szansa.TempIloscWytrychow;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (Szansa.IloscSkrzyni).ToString();
            LblLiczbaWytrychow.Text = (Szansa.IloscWytrychow).ToString();
        }
        private int Sprawdz(Skrzynia skrzynia, char znak)

        {
            if (counter < skrzynia.SkrzyniaArray.Length)
            {

                if ((znak == skrzynia.SkrzyniaArray[counter]) && (znak == L || znak == P))
                {
                    LblOutput.Text = "OK";
                    counter++;

                    return Szansa.IloscPunktow = skrzynia.GenerujIloscPunktow();


                }
                else if ((znak != skrzynia.SkrzyniaArray[counter]) && (znak == L || znak == P))
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
                            //fail = true;
                            return Szansa.IloscPunktow;
                        }
                    }
                    else
                    {
                        LblOutput.Text = "Zły ruch! Zaczynasz od nowa.";
                        counter = 0;
                        return Szansa.IloscPunktow = skrzynia.GenerujIloscPunktow();
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



        private void WyswietlPunkty()
        {
            LblOutput.Text = (Szansa.IloscPunktow).ToString();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpcje_Click(object sender, EventArgs e)
        {
          
            opcje.Show();
            opcje.CheckLevel();
            Resetuj();
        }
    }
}
