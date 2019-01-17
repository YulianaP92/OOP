using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderJackets
{
    class Coat:Jackets,IBuy
    {
        public Coat() : base()
        {
            NameGoods = "Coat";
            PriceGoods = 45.8;
        }

        public void Buy()
        {
            Console.WriteLine("You bought coat");
        }
        
    }
}
