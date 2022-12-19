using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ogrenci ogr = new Ogrenci();
            //isim değişkenine erişim sağlanılamıyor çünkü private, o yüzden get ve set kullanmamız lazım. 
            ogr.setIsim("Harun");
            string gelen = ogr.getIsim();
            if(gelen == "Harun")
            {
                Console.WriteLine("Başarılı Kapsülleme");
            }
            else
            {
                Console.WriteLine("Başarısız Kapsülleme");
            }
            Console.ReadKey();
            */

            Kitap ktp = new Kitap();
            ktp.setKitap("1984");
            string deger = ktp.getKitap();
            Console.WriteLine(deger);
            Console.ReadKey();
        }
    }
}
