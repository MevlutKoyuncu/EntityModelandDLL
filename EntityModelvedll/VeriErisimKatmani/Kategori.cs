using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Kategori
    {
        //SINIFI PUBLİC YAPMAK ZORUNDAYIZ Kİ DİĞER NAMESPACE ÜZERİNDEN ETKİLENMESİ İÇİN

        public int ID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }

    }
}
