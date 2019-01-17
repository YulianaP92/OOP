//A.L1.P4/6.
using System;
using InternetMagazine.FolderShoes;

namespace InternetMagazine
{
    //A.L1.P3/6.
    class Program
    {
        static void Main(string[] args)
        {
            Goods boughtBoots = new Boots();
            Show(boughtBoots);
            var _boughtBoots = (Boots)boughtBoots;
            _boughtBoots.Buy();
            Console.WriteLine();

            Goods boughtSandals = new Sandals();
            Show(boughtSandals);
            var _boughtSandals = (Sandals)boughtSandals;
            _boughtSandals.Buy();
            Console.WriteLine();

            string equal = boughtBoots > boughtSandals ? "Boots is more expensive Sandals" : "Sandals is more expensive Boots";
            Console.WriteLine(equal);
            Console.ReadKey();
        }
        static void Show(Goods goods)
        {
            goods.Catalogs();
            goods.ProductDescription();
        }
    }
}
