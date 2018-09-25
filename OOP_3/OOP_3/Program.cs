using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Vector v1 = new Vector();
            for(int i = 0; i < 10; i++)
                v1[i] = rnd.Next(-100,100);          
            v1.PrintArray();
            Console.WriteLine("\n Сумма элементов: {0}",v1.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v1.MulpiplyArray());
            Console.WriteLine("\n--------------------------------");

            Vector v2 = new Vector(8);
            v2.PrintArray();
            Console.WriteLine("\n Сумма элементов: {0}", v2.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v2.MulpiplyArray());
            Console.WriteLine("\n--------------------------------");

            Vector v3 = new Vector(4,5,0,90,4);    
            v3.PrintArray();
            Console.WriteLine("\n Сумма элементов: {0}", v3.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v3.MulpiplyArray());
            Console.WriteLine("\n--------------------------------\n");

            bool[] isNull = { v1.isNullInArray(), v2.isNullInArray(), v3.isNullInArray() };
            for(int i = 0; i<isNull.Length; i++)
            {
                if (isNull[i] == true)
                    Console.WriteLine("В {0} массив ноль! ", (i + 1));
            }

            int[] ArrayMin = { v1.GetMin(), v2.GetMin(), v3.GetMin() };
            for (int i = 0; i < ArrayMin.Length; i++)
                Console.WriteLine("Минимальный элемент {0} в массиве: {1}", i + 1, ArrayMin[i]);

            //CloseClass CC1 = new CloseClass(); 

            StaticClass SC1 = new StaticClass();
            StaticClass SC2 = new StaticClass();
            StaticClass SC3 = new StaticClass();
            StaticClass SC4 = new StaticClass();
            StaticClass SC5 = new StaticClass();
            Console.WriteLine("Количество экземпляров со статическим коструктором: {0}", StaticClass.countSC);
        }
    }
}
