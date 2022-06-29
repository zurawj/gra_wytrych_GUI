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
        Skrzynia skrzynia = new Skrzynia(4);
        bool fail = false;
        public bool otwartoSkrzynie = false;
        int punkty = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            fail = false;
            otwartoSkrzynie = false;
            skrzynia.GenerowanieSekwencji(4);
            LblOutput.Text = "Otwórz skrzynię!";
            Resetuj();
            BtnLewo.Show();
            BtnPrawo.Show();

        }

        private void BtnLewo_Click(object sender, EventArgs e)
        {
            if (menu.IloscWytrychow > 0)
            {
                znak = 'L';
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
            if (menu.IloscWytrychow > 0)
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
            menu.IloscWytrychow = 10;
            LblPunkty.Text = punkty.ToString();
            LblLiczbaSkrzyni.Text = (menu.IloscSkrzyni).ToString();
            LblLiczbaWytrychow.Text = (menu.IloscWytrychow).ToString();
        }
        private int Sprawdz(Skrzynia skrzynia, char znak)

        {
            if (counter < skrzynia.skrzynia.Length)
            {

                if ((znak == skrzynia.skrzynia[counter]) && (znak == 'L' || znak == 'P'))
                {
                    LblOutput.Text = "OK";
                    counter++;

                    return menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);


                }
                else if ((znak != skrzynia.skrzynia[counter]) && (znak == 'L' || znak == 'P'))
                {
                    if (skrzynia.zlamanieWytrycha(menu.Szansa))
                    {
                        LblOutput.Text = "Złamany wytrych! Zaczynasz od nowa.";
                        menu.IloscWytrychow--;
                        LblLiczbaWytrychow.Text = (menu.IloscWytrychow).ToString();
                        counter = 0;

                        if (menu.IloscWytrychow == 0)
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
                        return menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);
                    }

                }
                return menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);
            }
            if (menu.IloscWytrychow == 0)
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
        int Graj1(Skrzynia skrzynia, Menu menu)
        {
            const char L = 'L';
            const char P = 'P';
            bool fail = false;
            bool otwartoSkrzynie = false;
            int counter = 0;
            while (counter < skrzynia.skrzynia.Length)
            {

                //String input = Console.ReadLine();
                if (menu.input == 'L' && menu.input == 'P')
                {
                    char znak = menu.input;
                    if ((znak == skrzynia.skrzynia[counter]) && (znak == L || znak == P))
                    {

                        counter++;
                        menu.IloscPunktow = menu.GenerujIloscPunktow(menu.Szansa);

                    }
                    else if ((znak != skrzynia.skrzynia[counter]) && (znak == L || znak == P))
                    {
                        if (skrzynia.zlamanieWytrycha(menu.Szansa))
                        {
                            Console.WriteLine("Zlamany wytrych! Zaczynasz od nowa.");
                            menu.IloscWytrychow--;
                            counter = 0;
                            if (menu.IloscWytrychow == 0)
                            {
                                Console.WriteLine("Nie masz więcej wytrychów! Koniec Gry!");
                                menu.IloscPunktow = 0;
                                fail = true;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Zły ruch! Zaczynasz od nowa.");
                            counter = 0;
                        }

                    }

                    else if (znak == '0')
                    {
                        fail = true;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieznana komenda!");
                        menu.SleepAndClearConsole();

                    }
                }
                else
                {
                    Console.WriteLine("Nieznana komenda!");
                    menu.SleepAndClearConsole();

                }


            }
            if (fail)
            {
                Console.Clear();
                Console.WriteLine("Koniec gry! Zdobywasz " + menu.IloscPunktow + " punktów!");
                return menu.IloscPunktow;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Otwarto skrzynię! Zdobywasz " + menu.IloscPunktow + " punktów!");
                otwartoSkrzynie = true;
                return menu.IloscPunktow;

            }

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
