using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderTrousers
{
    class Pants : Trousers, IBuy //брюки
    {
        public Pants() : base()
        {
            NameGoods = "Pants";
            PriceGoods = 87.5;
        }

        public void Buy()
        {
            Console.WriteLine("You bought Pants");
        }
        
    }
}
