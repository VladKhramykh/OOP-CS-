using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    class Controller
    {
        Stock stock;

        public Controller(object obj)
        {
            stock = (Stock)obj;
        }

        public double SumOfSofas()
        {
            double sum = 0;
            for(int i = 0; i<stock.getCount(); i++)
            {
                if (stock[i] is Sofa)
                    sum += (stock[i] as Sofa).Cost;
            }

            return sum;
        }

        public void SearchName(string manufacturer)
        {
            bool flag = false;
            string thisName;
            for (int i = 0; i < stock.getCount(); i++)
            {
                
                if (stock[i] is Sofa)
                {
                    thisName = (stock[i] as Sofa).manufacturer;
                    if (String.Compare(thisName, manufacturer) == 0)
                    {
                      (stock[i] as Sofa).ToString();
                        flag = true;
                    }
                }

                if (stock[i] is Bed)
                {
                    thisName = (stock[i] as Bed).manufacturer;
                    if (String.Compare(thisName, manufacturer) == 0)
                    {
                       (stock[i] as Bed).ToString();
                        flag = true;
                    }
                }

                if (stock[i] is Wardrobe)
                {
                    thisName = (stock[i] as Wardrobe).manufacturer;
                    if (String.Compare(thisName, manufacturer) == 0)
                    {
                        (stock[i] as Wardrobe).ToString();
                        flag = true;
                    }
                }
                
                thisName = "";
            }
            if(!flag)
                    Console.WriteLine("Соответствие не найдено!");

        }
    }
}
