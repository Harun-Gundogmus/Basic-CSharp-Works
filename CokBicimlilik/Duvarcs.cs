using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    class Duvarcs : Tadilat
    {
        public override void change()
        {
            
            Console.Title = "BU BİR TADİLAT PROJESİDİR";
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("SALONUN DUVAR RENGİ PLANDAKİYLE DEĞİŞİKLİK GÖSTERMEKTEDİR.");
        }
    }
}
