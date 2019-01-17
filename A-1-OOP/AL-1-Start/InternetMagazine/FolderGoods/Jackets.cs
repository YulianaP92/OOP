using System;

namespace InternetMagazine.FolderGoods
{
    class Jackets:Goods
    {
        private int id; //id товаров Jackets
        public Jackets()
        {
            id = 2;
        }
        public override void Catalogs()
        {
            Console.WriteLine("You are loggen in catalog 'Jackets'");
        }
        public override void ProductDescription()
        {
            base.ProductDescription();
            Console.WriteLine($"ID -{id}");
        }
    }
}
