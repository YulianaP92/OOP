using System;

namespace InternetMagazine.FolderGoods
{
    class Trousers:Goods
    {
        private int id; //id товаров Trousers
        public Trousers()
        {
            id = 4;
        }
        public override void Catalogs()
        {
            Console.WriteLine("You are loggen in catalog 'Trousers'");
        }
        public override void ProductDescription()
        {
            base.ProductDescription();
            Console.WriteLine($"ID -{id}");
        }
    }
}
