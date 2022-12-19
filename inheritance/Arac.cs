using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    public class Arac
    {
        public string marka;
        public string model;
        public string yil;

        public void Bilgi()
        {
            Console.WriteLine("Arabanın Markası: " + marka);
            Console.WriteLine("Arabanın Modeli " + model);
            Console.WriteLine("Arabanın Yılı: " + yil);
        }

    }
}
