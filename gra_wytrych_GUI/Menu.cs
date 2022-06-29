using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    internal class Menu
    {
        public int IloscWytrychow { get; set; }
        public int Szansa { get; set; }
        public int DlugoscSekwencji { get; set; }

        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        public char input;

        public const int SzansaLatwy = 20;
        public int SzansaSredni = 30;
        public int SzansaTrudny = 80;

        private Random rnd = new Random();
        public Menu()
        {   //domyslny poziom latwy
            IloscWytrychow = 10;
            DlugoscSekwencji = 4;
            Szansa = 20;
        }
      

        public void UstawPoziomLatwy()
        {
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
        public int GenerujIloscPunktow(int szansa)
        {

            if (szansa == SzansaLatwy)
            {
                int los = rnd.Next(5, 20); //przydziela od 5 do 20 punktów
                return los;
            }
            else if (szansa == SzansaSredni)
            {
                int los = rnd.Next(15, 30);
                return los;
            }
            else if (szansa == SzansaTrudny)
            {
                int los = rnd.Next(25, 40);
                return los;
            }
            else return 0;


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
