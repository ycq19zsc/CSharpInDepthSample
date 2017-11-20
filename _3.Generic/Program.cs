using System;
using System.Collections.Generic;

namespace _3.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //code 3-3
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };


            var doubles = list.ConvertAll(TakeSquareRoot);

            doubles.ForEach(Console.WriteLine);

            Console.ReadKey();
        }


        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        //private Converter<int, double> converter = TakeSquareRoot;
    }


}
