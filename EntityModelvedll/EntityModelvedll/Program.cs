using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriErisimKatmani;

namespace EntityModelvedll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Solution'a tıklayıp Add üzerinden new project oluşturuyoruz, class library.net framework oluşturucaz.
            //VeriErişim katmanına sınıf ekliyoruz.

            VeriModeli vm = new VeriModeli();
            List<Kategori> kategoriler = vm.KategorileriGetir();

            for (int i = 0; i < kategoriler.Count; i++)
            {
                Kategori k = kategoriler[i];
                Console.WriteLine($"{k.ID}) {k.Isim} {k.Aciklama}");
            }


        }
    }
}
