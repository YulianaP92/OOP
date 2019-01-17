using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderShoes
{
    class Sandals : Shoes, IBuy 
    {
        public Sandals() : base()
        {
            NameGoods = "Sandals";
            PriceGoods = 76.9;
        }

        public void Buy()
        {
            Console.WriteLine("You bought sandals");
        }
    }
}
