using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_inheritance
{
    internal class Program
    {
        static void Main(string[]args)
        {
            // --------- Villa1 ---------
            Villa villa1 = new Villa();
            string villa1_adres = "adatepe mah.";
            villa1.setAdres(villa1_adres);
            //Console.WriteLine(villa1.getAdres());
            bool villa1_dg = true;
            villa1.setDogalgaz(villa1_dg);
            //Console.WriteLine(villa1.getDogalgaz());

            // --------- Apartman 1 ---------
            Apartman Apartman1 = new Apartman();
            bool Apartman1_dg = true;
            Apartman1.setDogalgaz(Apartman1_dg);
            //Console.WriteLine(Apartman1.getDogalgaz());

            // --------- Apartman 2 ---------
            Apartman Apartman2 = new Apartman();
            bool Apartman2_dg = false;
            Apartman1.setDogalgaz(Apartman2_dg);
            //Console.WriteLine(Apartman2.getDogalgaz());

            // --------- Villa 2 ---------
            Villa villa2 = new Villa();
            bool villa2_dg = true;
            villa2.setDogalgaz(villa2_dg);
            //Console.WriteLine(villa2.getDogalgaz());


            // Soru
            Console.WriteLine("Ev seciniz: \n" +
                "1- Villa1 \n" +
                "2- Villa2 \n" +
                "3- Apartman1 \n" +
                "4- Apartman2 \n");
            int secim = Int32.Parse(Console.ReadLine());

            // dogalgaz durumunu gosteren metod
            void dogDurum(bool secilen)
            {
                if (secilen)
                {
                    Console.WriteLine("Secilen evimiz dogalgazlidir.");
                }
                else
                {
                    Console.WriteLine("Malesef dogalgaz bulunmuyor.");
                }
                
            }

            // program
            switch (secim)
            {
                case 1:
                    dogDurum(villa1.getDogalgaz());
                    break;
                case 2:
                    dogDurum(villa2.getDogalgaz());
                    break ;
                case 3:
                    dogDurum(Apartman1.getDogalgaz());
                    break;
                case 4:
                    dogDurum(Apartman2.getDogalgaz());
                    break;
            }

        }
    }
}
