using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    class Ogrenci
    {
        /*
         kapsüllemeyi, private değişkenlere program içerisinde erişim sağlamak için kullanıyoruz.
        */

        private string isim;

        public void setIsim(string _isim)
        {
            isim = _isim;
        }
        public string getIsim()
        {
            return isim;
        }
    }
}
