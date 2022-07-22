using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_inheritance
{
    public class Ev
    {
        private int oda;
        private string adres;
        private string renk;
        private bool dogalgaz;

        // oda kapsulleme
        public int getOda()
        {
            return oda;
        }

        public void setOda(int _oda)
        {
            oda = _oda;
        }

        // adres 
        public string getAdres()
        {
            return adres;
        }

        public void setAdres(string _adres)
        {
            adres = _adres;
        }

        // renk
        public string getRenk()
        {
            return renk;
        }

        public void setOda(string _renk)
        {
            renk = _renk;
        }

        // dogalgaz
        public bool getDogalgaz()
        {
            return dogalgaz;
        }

        public void setDogalgaz(bool _dogalgaz)
        {
            dogalgaz = _dogalgaz;
        }

    }
}
