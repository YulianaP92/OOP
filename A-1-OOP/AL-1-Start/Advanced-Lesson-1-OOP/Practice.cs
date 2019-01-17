using System;


namespace Advanced_Lesson_1_OOP
{
    public class Figure
    {
        public virtual double CalcArea()
        {
            throw new NotImplementedException();
        }
    }
    public class Circles:Figure
    {
        double r;
        public  Circles(double r)
        {
            this.r = r;
        }
       
        public override double CalcArea()
        {
            return Math.PI * r * r;
        }
    }
    public class Square:Figure
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }

        public override double CalcArea()
        {
            return  a * a;
        }
    }
    public class IsoscelesTriangle : Figure
    {
        double b;
        double h;
        public IsoscelesTriangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public override double CalcArea()
        {
            return (b * h)/2;
        }
    }

    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            var arr = new Figure[] { new Circles(5.7), new Circles(4.5), new Square(5.3), new Square(5.2),new IsoscelesTriangle(7.4,6.3) };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].CalcArea();
                Console.WriteLine(arr[i].CalcArea());
            }
        }

        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            //см.LessonTransport
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
            //см.класс Goods или InternetMagazine
        }
    }
}
