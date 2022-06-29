using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    public class Skrzynia
    {
        private const char L = 'L';
        private const char P = 'P';
        private const int Min = 0;
        private const int Max = 99;
        public char[] SkrzyniaArray { get; set; }
        private Random Rnd = new Random();

        public Skrzynia(int dlugosc)
        {
            this.SkrzyniaArray = new char[dlugosc];
        }
        public void GenerowanieSekwencji(int dlugosc)
        {

            for (int i = 0; i < dlugosc; i++)
            {
                if (Rnd.Next(0, 2) > 0)
                {
                    this.SkrzyniaArray[i] = L;
                }
                else this.SkrzyniaArray[i] = P;
            }
        }
        public bool ZlamanieWytrycha(int szansa)
        {
            return Rnd.Next(Min, Max) <= szansa;
        }
    }



    
}

