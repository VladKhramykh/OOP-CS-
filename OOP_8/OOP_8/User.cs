using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    class User<T> where T:Sofa
    {
        public T[] Sofas;
        int i;

        public User()
        {
            Sofas = new T[5];
            int i = 0;
        }

        public void Add(T obj)
        {
            if (i == 5)
            {
                Console.WriteLine("Место на складе закончилось!");
                return;
            }
                
            Sofas[i] = obj;
            i++;
        }

        public void PrintShortInfo()
        {
            foreach (T t in Sofas)
                t.ToString();
        }

        public void PrintFullInfo()
        {
            foreach (T t in Sofas)
                t.Print();
        }

    }
}
