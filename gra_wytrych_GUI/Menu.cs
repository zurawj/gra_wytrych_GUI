using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_wytrych_GUI
{
    public class Menu
    {

        public int IloscSkrzyni { get; set; }

        public int IloscPunktow { get; set; }

        public ConsoleKeyInfo keyPressed;

        private Random Rnd = new Random();
        public Szansa szansa = new Szansa();
        public Menu()
        {
            szansa.SetSzansaLatwy();
        }




        public int GenerujIloscPunktow(Szansa szansa)
        {
            if (szansa.min != szansa.max)
            {
                return Rnd.Next(szansa.min, szansa.max);
            }
            else return 0;


        }

    }
    }
