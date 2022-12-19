using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    class Tadilat
    {
        /*
         - Çok biçimlilikte amacım kalıtım yaptığım bazı değerleri(hepsini değil)
            alıp kullanmak
         - Bunu yaparkende override(ezmek) işlemini kullanıyorum
         */

        public virtual void change()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "BU BİR TADİLAT PROJESİDİR";
            Console.WriteLine("");

            Console.WriteLine("SALONUN DUVAR RENGİ ORJINALİNDE MAVİDİR");
        }
    }
}
