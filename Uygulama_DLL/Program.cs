using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matematiksel_Islemler;

namespace Uygulama_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematiksel_Islemler.Islemler islemler = new Matematiksel_Islemler.Islemler();
            Console.WriteLine(islemler.Topla(10, 7));

            Console.ReadLine();
        }
    }
}
