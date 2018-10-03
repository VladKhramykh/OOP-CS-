using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        public static void Sum(int A, int B, out int _sum)
        {
            _sum = A + B;
        }

        public static void Change(int _c, ref int _d)
        {
            _d += _c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Статик переменная сейчас: " + Vector.Count);
            Console.WriteLine(Vector.labName);
            Vector v1 = new Vector();
            v1.PrintArray();
            Console.WriteLine(v1.GetType());
            Console.WriteLine("\n Сумма элементов: {0}", v1.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v1.MulpiplyArray());
            Console.WriteLine("\n--------------------------------");

            Vector v2 = new Vector(8);
            v2.PrintArray();
            Console.WriteLine("\n Сумма элементов: {0}", v2.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v2.MulpiplyArray());
            Console.WriteLine("\n--------------------------------");

            Vector v3 = new Vector(43, -5, 0, 90, 4);
            v3.PrintArray();
            Console.WriteLine("\n Сумма элементов: {0}", v3.SumArray());
            Console.WriteLine(" Произведение элементов: {0}", v3.MulpiplyArray());
            Console.WriteLine("\n--------------------------------\n");

            Console.WriteLine("А сейчас она изменилась: " + Vector.Count);
            Console.WriteLine("Всего объектов: " + Vector.GetCount());

            Vector[] vectors = { v1, v2, v3 };

            for (int i = 0; i < vectors.Length; i++)
            {
                if (vectors[i].IsNullInArray())
                    Console.WriteLine("В массиве {0}-го объекта есть ноль! ", (i + 1));
            }

            for (int i = 0; i < vectors.Length; i++)
                Console.WriteLine("Минимальный элемент {0} в массиве: {1}", i + 1, vectors[i].GetMin());
            Console.WriteLine("\n--------------------------------\n");

            int a, b, c, d, sum;
            a = 5;
            b = 10;
            c = 20;
            d = 25;
            Console.WriteLine("a = {0}\nb = {1}\nc = {2}\nd = {3}", a, b, c, d);
            Sum(a, b, out sum);
            Console.WriteLine("Сумма a и b равна: " + sum);
            Change(c, ref d);
            Console.WriteLine("После работы с ref: ");
            Console.WriteLine("\nc = {0} \nd = {1})", c, d);
            Console.WriteLine("\n--------------------------------\n");

            Student Alex = new Student("Alex", 23);
            Student Masha = new Student("Masha", 19);

            Console.WriteLine("\nИмя: {0}", Alex.Name);
            Console.WriteLine("Возраст: {0}", Alex.Age);
            Console.WriteLine("Хеш-код: {0}", Alex.GetHashCode());

            Console.WriteLine("\nИмя: {0}", Masha.Name);
            Console.WriteLine("Возраст: {0}", Masha.Age);
            Console.WriteLine("Хеш-код: {0}", Masha.GetHashCode());
            Console.WriteLine(Masha.Equals(Alex) ? " \nЭти объекты одинаковы\n" : "\nЭти объекты НЕ одинаковы\n");
            Console.WriteLine("Тип объекта Alex: {0}", Alex.GetType());
            Console.WriteLine("\n--------------------------------\n");
            var anon = new {x = 5, name = "zldg" };
            Console.WriteLine(anon.GetType());
            
            
        }

        
    }
}
