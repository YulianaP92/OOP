using System;

namespace Advanced_Lesson_1_OOP
{
    //A.L1.P6/6*

    public class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public static void PriceComparison()
        {
            var trousers = new Goods { Name = "trousers", Price = 56.7 };
            var shoes = new Goods { Name = "shoes", Price = 56.8 };
            var jacket = new Goods { Name = "jacket", Price = 200.56 };

            if (trousers > shoes & trousers > jacket)
                Console.WriteLine("trousers are the most expensive thing in the store");
            else if (shoes > trousers & shoes > jacket)
                Console.WriteLine("shoes are the most expensive thing in the store");
            else
                Console.WriteLine("jacket is the most expensive thing in the store");

            var egualPrice = (trousers == shoes || trousers == jacket || shoes == jacket) ? true : false;
            if (egualPrice)
                Console.WriteLine("prices for some of the goods are equal");

        }
        public static bool operator >(Goods goods1, Goods goods2)
        {
            return goods1.Price > goods2.Price;
        }
        public static bool operator <(Goods goods1, Goods goods2)
        {
            return goods1.Price < goods2.Price;
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
            return ((Goods)obj).Price == this.Price;
        }

        public override int GetHashCode()
        {
            return this.Price.GetHashCode();
        }
    }
}
