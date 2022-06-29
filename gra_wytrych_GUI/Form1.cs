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
        Menu menu = new Menu();
        public Form1()
        {
            InitializeComponent();
        }


        int counter = 0;
        char znak;
        Skrzynia skrzynia = new Skrzynia(Szansa.DlugoscSekwencji);
        bool fail = false;
        public bool otwartoSkrzynie = false;
        int punkty = 0;

        private void BtnNowaGra_Click(object sender, EventArgs e)
        {
           
            fail = false;
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
                znak = 'L';  // zmienic na const
                Sprawdz(skrzynia, znak);
                if (otwartoSkrzynie)
                {
                    OtwartoSkrzynie();
                }
            }
            else LblOutput.Text = "Brak wytrychów! Wciśnij 'Nowa Gra' aby zacząć zagrać jeszcze raz!";



        }
        private void BtnPrawo_Click(object sender, EventArgs e)
        {
            if (Szansa.IloscWytrychow > 0)
            {
                znak = 'P';
                Sprawdz(skrzynia, znak);
                if (otwartoSkrzynie)
                {
                    OtwartoSkrzynie();
                }
            }
            else LblOutput.Text = "Brak wytrychów! Wciśnij 'Nowa Gra' aby zacząć zagrać jeszcze raz!";

        }
        private void OtwartoSkrzynie()
        {
            menu.IloscSkrzyni++;
            punkty += menu.IloscPunktow;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (menu.IloscSkrzyni).ToString();
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(4);
        }
        private void Resetuj()
        {
            punkty = 0;
            menu.IloscPunktow = 0;
            menu.IloscSkrzyni = 0;
            Szansa.IloscWytrychow = 10;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (menu.IloscSkrzyni).ToString();
            LblLiczbaWytrychow.Text = (Szansa.IloscWytrychow).ToString();
        }
        private int Sprawdz(Skrzynia skrzynia, char znak)

        {
            if (counter < skrzynia.SkrzyniaArray.Length)
            {

                if ((znak == skrzynia.SkrzyniaArray[counter]) && (znak == 'L' || znak == 'P'))
                {
                    LblOutput.Text = "OK";
                    counter++;

                    return menu.IloscPunktow = skrzynia.GenerujIloscPunktow();


                }
                else if ((znak != skrzynia.SkrzyniaArray[counter]) && (znak == 'L' || znak == 'P'))
                {
                    if (skrzynia.ZlamanieWytrycha(menu.Szansa))
                    {
                        LblOutput.Text = "Złamany wytrych! Zaczynasz od nowa.";
                        Szansa.IloscWytrychow--;
                        LblLiczbaWytrychow.Text = (Szansa.IloscWytrychow).ToString();
                        counter = 0;

                        if (Szansa.IloscWytrychow == 0)
                        {
                            LblOutput.Text = "Nie masz więcej wytrychów! Koniec Gry!";
                            menu.IloscPunktow = 0;
                            fail = true;
                            return menu.IloscPunktow;
                        }
                    }
                    else
                    {
                        LblOutput.Text = "Zły ruch! Zaczynasz od nowa.";
                        counter = 0;
                        return menu.IloscPunktow = skrzynia.GenerujIloscPunktow();
                    }

                }
                return menu.IloscPunktow = skrzynia.GenerujIloscPunktow();
            }
            if (Szansa.IloscWytrychow == 0)
            {

                LblOutput.Text = "Koniec gry! Zdobywasz " + menu.IloscPunktow + " punktów!";
            }
            else
            {
                LblOutput.Text = "Otwarto skrzynię! Zdobywasz " + menu.IloscPunktow + " punktów!";
                otwartoSkrzynie = true;
                counter = 0;

            }
            return menu.IloscPunktow;
        }



        private void WyswietlPunkty()
        {
            LblOutput.Text = (menu.IloscPunktow).ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Opcje opcje = new Opcje();
            //opcje.Show();
        }


    }
}
