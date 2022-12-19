using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Kategoriler.Elektronik);
            Console.ReadKey();
        }
        enum Kategoriler
        {
            Tuhafiye = 3,
            Elektronik = 2,
            Gıda = 1,
            Temizlik = 4,
            Oyuncak = 5
        } 
    }
}
