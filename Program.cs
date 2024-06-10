using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kedi> kediList = new List<Kedi>() {
            new Kedi { kediYasi = 2, kediIsmi = "boncuk",HayvanAyakSayisi=4, },
            new Kedi { kediYasi = 3, kediIsmi = "amavi",HayvanAyakSayisi=5, },
            new Kedi { kediYasi = 4, kediIsmi = "blue",HayvanAyakSayisi=6, },
            new Kedi { kediYasi = 5, kediIsmi = "boz",HayvanAyakSayisi=8, }
            };
        













            Console.ReadKey();
        }
    }
}
