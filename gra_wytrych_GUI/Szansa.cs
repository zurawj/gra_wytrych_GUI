using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    public static class Szansa
    {
        public static int Latwy = 30; //30% szansy na złamanie wytrycha przy złym ruchu
        public static int Sredni = 50;
        public static int Trudny = 80;
        public static int min = 0;
        public static int max = 0;
        public static int IloscWytrychow { get; set; }
        public static int TempIloscWytrychow; //zabezpieczenie przed naliczaniem ujemnych wytrychów
        public static int Chance { get; set; }
        public static int DlugoscSekwencji = 4; // domyślny poziom łatwy

        public static void SetSzansaLatwy()
        {
            Chance = Latwy;
            IloscWytrychow = 20;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 8;
            min = 5;  //zakres ilości punktów jakie zostaną przydzielone po otwarciu skrzyni
            max = 20;
        }
        public static void SetSzansaSredni()
        {
            Chance = Sredni;
            IloscWytrychow = 10;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 7;
            min = 15;
            max = 30;
        }
        public static void SetSzansaTrudny()
        {
            Chance = Trudny;
            IloscWytrychow = 5;
            TempIloscWytrychow = IloscWytrychow;
            DlugoscSekwencji = 10;
            min = 25;
            max = 40;
        }

        public static void UstawMalaSzanseZlamaniaWytrycha()
        {
            Chance = Latwy;
        }
        public static void UstawSredniaSzanseZlamaniaWytrycha()
        {
            Chance = Sredni;
        }
        public static void UstawDuzaSzanseZlamaniaWytrycha()
        {
            Chance = Trudny;
        }
   
    }
}
