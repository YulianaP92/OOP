using System;

namespace InternetMagazine.FolderGoods
{
    class Accessories:Goods
    {
        private int id; //id товаров Accessories
        public Accessories()
        {
            id = 3;
        }
        public override void Catalogs()
        {
            Console.WriteLine("You are loggen in catalog 'Accessories'");
        }
        public override void ProductDescription()
        {
            base.ProductDescription();
            Console.WriteLine($"ID -{id}");
        }
    }
}
