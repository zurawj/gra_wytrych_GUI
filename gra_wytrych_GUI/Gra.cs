﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    internal class Gra
    {
        private bool fail = false;
        public bool otwartoSkrzynie = false;
        public int Graj(Skrzynia skrzynia, Menu menu)
        {
            const char L = 'L';
            const char P = 'P';
            fail = false;
            otwartoSkrzynie = false;
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

        internal void Sprawdz()
        {

        }
    }
}


