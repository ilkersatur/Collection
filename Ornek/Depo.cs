using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    internal class Depo
    {
        Urun urun = new Urun();
        ArrayList depo = new ArrayList();

        public void UrunEkle(Urun urun)
        {
            depo.Add(urun);
        }
        public ArrayList Lisetele() { return depo; }
        public void UrunSil(int i)
        {
            foreach (Urun urun in depo)
            {
                if (i == urun.Id)
                {
                    depo.Remove(urun);
                }
                break;
            }
        }
    }
}
