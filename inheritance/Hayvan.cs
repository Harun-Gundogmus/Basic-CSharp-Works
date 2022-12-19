using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Hayvan
    {
        // Erişim belirleyicimi public yani herkese açık hale getirdikten sonra değişkenlerimi
        // oluşturdum.
        public string isim;
        public string cinsiyet;

        //private olarak tanımlanan değişkenime main method üzerinden erişemiyorum.
        private int yas;

        public void HayvanBilgiGöster()
        {
            Console.WriteLine("Hayvanın İsmi: " + isim);
            Console.WriteLine("Hayvanın Cinsiyeti: " + cinsiyet);
        }
    }
}
