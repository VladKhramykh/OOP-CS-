using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    class Stock
    {
        ArrayList stock = new ArrayList();
        
        public object this[int i]
        {
            get
            {
                return stock[i];
            }

            set
            {
                if (i > 0 && i < stock.Count)
                    stock.Insert(i, value);
                else
                    throw new StockExceptions($"На складе товара c {i} индексом нет!", i);
            }
        }


        public void Add(object obj)
        {
            stock.Add(obj);
        }

        public void Remove(int index)
        {
            stock.RemoveAt(index);
        }

        public void Print()
        {

            Console.WriteLine("___________________________");
            foreach (object obj in stock)
            {
                if (obj is Sofa)
                    (obj as Sofa).ToString();

                if (obj is Bed)
                    (obj as Sofa).ToString();

                if (obj is Wardrobe)
                    (obj as Sofa).ToString();

                if (obj is int)
                    Console.WriteLine(obj + "\n");

                if (obj is string)
                    Console.WriteLine(obj + "\n");

                if (obj is char)
                    Console.WriteLine(obj + "\n");
            }
            Console.WriteLine("___________________________");
        }

        public int getCount()
        {
            return stock.Count;
        }
    }
}
