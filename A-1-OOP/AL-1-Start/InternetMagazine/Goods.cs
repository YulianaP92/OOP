using System;

namespace InternetMagazine
{
    class Goods //товар
    {
        public string NameGoods { get; set; }
        public double PriceGoods { get; set; }
        public virtual void ProductDescription()//описание продукта
        {
            Console.WriteLine($"Name -{NameGoods}\nPrice {PriceGoods} rub");
        }
        public virtual void Catalogs()//каталог, в котором находится продукт
        {
            Console.WriteLine("Select product catalog");
        }
        //A.L1.P6/6*.
        public static bool operator >(Goods goods1, Goods goods2)
        {
            return goods1.PriceGoods > goods2.PriceGoods;
        }
        public static bool operator <(Goods goods1, Goods goods2)
        {
            return goods1.PriceGoods < goods2.PriceGoods;
        }
        public static bool operator ==(Goods goods1, Goods goods2)
        {
            return goods1.Equals(goods2);
        }
        public static bool operator !=(Goods goods1, Goods goods2)
        {
            return !goods1.Equals(goods2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Goods))
                return false;
            return ((Goods)obj).PriceGoods == this.PriceGoods;
        }

        public override int GetHashCode()
        {
            return this.PriceGoods.GetHashCode();
        }
    }
}
