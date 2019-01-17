using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderShoes
{
    class Boots : Shoes, IBuy
    {
        public Boots() : base()
        {
            NameGoods = "Boots";
            PriceGoods = 56.9;
        }

        public void Buy()
        {
            Console.WriteLine("You bought booys");
        }
    }
}
