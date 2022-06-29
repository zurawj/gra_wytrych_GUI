using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    public class Menu
    {
        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        public char input;

        public const int SzansaLatwy = 20;
        public int SzansaSredni = 30;
        public int SzansaTrudny = 80;

        private Random rnd = new Random();
        public Menu()
        {   //domyslny poziom latwy
           // Szansa.SetSzansaLatwy();
        }
        

        public void UstawPoziomLatwy()
        {
           // Szansa.SetSzansaLatwy();
            UstawPoziom(20, 4, SzansaLatwy);
        }
        public void UstawPoziomSredni()
        {
            UstawPoziom(10, 7, SzansaSredni);
        }
        public void UstawPoziomTrudny()
        {
            UstawPoziom(5, 10, SzansaTrudny);
        }
        private void UstawPoziom(int IloscWytrychow, int DlugoscSekwencji, int Szansa)
        {
            this.IloscWytrychow = IloscWytrychow;
            this.DlugoscSekwencji = DlugoscSekwencji;
            this.Szansa = Szansa;
        }

       


        public void SleepAndClearConsole()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void SleepAndClearConsole(int time)
        {
            Thread.Sleep(time);
            Console.Clear();
        }
    }
}
