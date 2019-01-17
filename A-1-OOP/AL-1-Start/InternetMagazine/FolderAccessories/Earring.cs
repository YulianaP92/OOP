using System;
using InternetMagazine.FolderGoods;

namespace InternetMagazine.FolderAccessories
{
    class Earring : Accessories, IBuy
    {
        public Earring() : base()
        {
            NameGoods = "Earring";
            PriceGoods = 67.8;
        }

        public void Buy()
        {
            Console.WriteLine("You bought earring");
        }      
    }
}
