using System;

namespace _4.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-1
            Nullable<int> nullable = 5;

            object boxed = nullable;    //装箱成“有值的可空类型的实例”
            Console.WriteLine(boxed.GetType());

            int normal = (int)boxed;    //拆箱成非可空变量
            Console.WriteLine(normal);

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable);    //拆箱成可空变量

            nullable = new Nullable<int>();
            boxed = nullable;   //装箱成“没有值的可空类型的实例”

            Console.WriteLine(boxed == null);

            nullable = (Nullable<int>)boxed;    //拆箱成可空变量
            Console.WriteLine(nullable.HasValue);


            //4-4



            int? first = null;
            int? second = 5;
            int? third = 3;

            var last1 = first ?? second;
            var last2 = first ?? second ?? third;
            var last3 = first ?? second ?? third ?? 1;

            Console.ReadKey();
        }
    }

    class Person
    {
        public DateTime Birth { get; set; }
        public DateTime? Death { get; set; }
        public string Name { get; set; }

        public TimeSpan Age
        {
            get
            {
                if (Death == null)
                {
                    return DateTime.UtcNow - Birth;
                }
                else
                {
                    return Death.Value - Birth;
                }

            }
        }

        public Person()
        {

        }
    }

}

