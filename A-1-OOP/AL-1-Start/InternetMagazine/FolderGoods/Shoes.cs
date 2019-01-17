using System;

namespace InternetMagazine.FolderGoods
{
    class Shoes:Goods
    {
        private int id; //id товаров Shoes
        public Shoes()
        {
            id = 1;
        }
        public override void Catalogs()
        {
            Console.WriteLine("You are loggen in catalog 'Shoes'");
        }
        public override void ProductDescription()
        {
            base.ProductDescription();
            Console.WriteLine($"ID -{id}");
        }
    }
}
