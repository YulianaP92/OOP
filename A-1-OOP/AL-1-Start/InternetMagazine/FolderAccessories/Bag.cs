using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderAccessories
{
    class Bag:Accessories,IBuy
    {
        public Bag() : base()
        {
            NameGoods = "Bag";
            PriceGoods = 45.8;
        }

        public void Buy()
        {
            Console.WriteLine("You bought bag");
        }   
    }
}
