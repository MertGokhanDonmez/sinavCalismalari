using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayerArch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            noteMan nm = new noteMan();

            foreach (var item in nm.GetAll())
            {
                Console.WriteLine("ID: "+item.Id+"Note: "+item.tkg_note);
            }


        }
    }
}
