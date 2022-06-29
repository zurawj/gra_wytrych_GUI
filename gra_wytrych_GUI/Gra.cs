using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    internal class Gra
    {
        const char L = 'L';//symbole w tablicy skrzynia.SkrzyniaArray oznaczające ruch w lewo lub prawo
        const char P = 'P';
        public bool fail = false;//flaga używana przy przegranej w celu wyjscia z gry i wyswietlenia odpowiedniego komunikatu
        public bool otwartoSkrzynie = false;

        public int Graj(Skrzynia skrzynia, Menu menu, Szansa szansa)
        {
            fail = false;
            otwartoSkrzynie = false;
            int counter = 0;
            while (counter < skrzynia.SkrzyniaArray.Length)
            {
                char znak = ZamienNaZnak(Console.ReadKey(true));

                char znakZeSkrzyni = skrzynia.SkrzyniaArray[counter];
                if ((znak == znakZeSkrzyni) && (znak == L || znak == P))
                {
                    Console.WriteLine("OK");
                    counter++;
                    menu.IloscPunktow = menu.GenerujIloscPunktow(szansa);

                }
                else if ((znak != znakZeSkrzyni) && (znak == L || znak == P))
                {
                    if (skrzynia.ZlamanieWytrycha(szansa.Chance))
                    {
                        szansa.IloscWytrychow--;
                        Console.WriteLine("Zlamany wytrych! Zaczynasz od nowa. Pozostało " + szansa.IloscWytrychow + " wytrychów.");
                        counter = 0;
                        if (szansa.IloscWytrychow == 0)
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
  

                }



            }
            if (fail)
            {
                Console.Clear();
                Console.WriteLine("Koniec gry! Zdobywasz " + menu.IloscPunktow + " punktów!");
          

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Otwarto skrzynię! Zdobywasz " + menu.IloscPunktow + " punktów!");
                otwartoSkrzynie = true;
                


            }
            return menu.IloscPunktow;

        }
        private char ZamienNaZnak(ConsoleKeyInfo key)
        {
            char Znak;
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Lewo");

                Znak = L;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Prawo");
                Znak = P;
            }
            else if (key.Key == ConsoleKey.D0)
            {
                Znak = '0';
            }
            else Znak = '1';
            return Znak;

        }

        public void Logic()
        {
            Menu menu = new Menu();
            while (true)
            {


             
                Skrzynia skrzynia = new Skrzynia(menu);
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.D1)
                {
                    //menu.Reset();


                    while (true)
                    {
                       // Clear();
                        Console.WriteLine("Otwórz skrzynie");
                        skrzynia.GenerowanieSekwencji(menu);


                        menu.IloscPunktow += Graj(skrzynia, menu, menu.szansa);
                        if (otwartoSkrzynie)
                        {
                            menu.IloscSkrzyni++;
                        }
                        if (fail)
                        {
                            break;
                        }




                    }
                }
            }
        }
    }
}


