using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    class Kitap
    {
        private string kitapAdi;
        public void setKitap(string _kitapadi)
        {
            kitapAdi = _kitapadi;
        }
        public string getKitap()
        {
            return kitapAdi;
        }
    }
}
