using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderJackets
{
    class Blazer:Jackets,IBuy
    {
        public Blazer() : base()
        {
            NameGoods = "Blazer";
            PriceGoods = 45.8;
        }

        public void Buy()
        {
            Console.WriteLine("You bought blazer");
        }
      
    }
}
