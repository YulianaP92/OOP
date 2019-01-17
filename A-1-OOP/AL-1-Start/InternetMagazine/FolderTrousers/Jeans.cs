using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderTrousers
{
    class Jeans : Trousers, IBuy
    {
        public Jeans() : base()
        {
            NameGoods = "Jeans";
            PriceGoods = 76.9;
        }

        public void Buy()
        {
            Console.WriteLine("You bought Jeans");
        }

    }
}
