using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kedi sınıfımdan ürettiğim nesneye değerlerimi girdim. 
            // Normalde bu sınıf içerisinde yazılı hiç bir bilgim yok.
            // Ancak kalıtım uyguladığım için diğer sınıfımdakiler geçiş yaptılar. 
            /*Kedi cat = new Kedi();
            cat.isim = "Tekir";
            cat.cinsiyet = "Dişi";*/

            //Ekrana verme metodumu da çağırdım. 
            /*cat.HayvanBilgiGöster();
            Console.ReadKey();*/

            Marka mrk = new Marka();
            mrk.marka = "BMW";
            mrk.model = "E30";
            mrk.yil = "2020";
            mrk.Bilgi();
            Console.ReadKey();
        }
    }
}
