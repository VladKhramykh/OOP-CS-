using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            var bed1 = new Bed("Аврора 7", 2, "200x180", 254.99f, "ООО 'Территория сна'", "Комнатная", "Кровать");
            var sofa1 = new Sofa("Счастье", 8, "238x95x120", 899.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            IFurniture sofa2 = new Sofa("Радость", 8, "138x135x170", 399.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            var sofa3 = new Sofa("Здоровье", 8, "268x95x140", 199.99f, "ООО 'ВитебскДиван'", "Комнатная", "Диван");
            var sofa4 = new Sofa("Апполинария", 8, "178x95x120", 1899.99f, "ООО 'ПинскДрев'", "Комнатная", "Диван");
            var sofa5 = new Sofa("Штормград", 8, "238x95x110", 799.99f, "ООО 'Ами Мебель'", "Комнатная", "Диван");
            var wardrobe1 = new Wardrobe("Ревьера", "150x216x58", 1399.99f, 8, "Лагуна", "Комнатная", "Шкаф");
            for (; ; )
            {
                int choice;
                Console.WriteLine("Выберите действие:\n \t1 - Работа с объектами + сортировка по цене\n \t2 - is и as \n \t3 - Структуры и перечисления");
                Console.WriteLine("\t4 - Работа с классом-контейнером");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            sofa2.Print();
                            Console.WriteLine("*******************************************\n");
                            Sofa.PrintSortSofas();

                            continue;
                        }
                    case 2:
                        {
                            int number = 228;
                            Bed bed = new Bed("Лагуна", 2, "180x180x50", 399.29, " ЛагунаМебель", "Комнатная", "Кровать");
                            object obj = number;
                            Boolean checkSinW = bed is Product;
                            Boolean checkOinI = obj is int;
                            if (checkSinW)
                                Console.WriteLine("Bed можно преобразовать в Product(абстрактный)");
                            else
                                Console.WriteLine("Bed нельзя преобразовать в Product(абстрактный)");

                            if (checkOinI)
                                Console.WriteLine("object можно преобразовать в int");
                            else
                                Console.WriteLine("object нельзя преобразовать в int");

                            continue;
                        }

                    case 3:
                        {
                            Student student1 = new Student("Влад", 18);
                            student1.Write();

                            DaysOfWeek day = DaysOfWeek.sunday;
                            if ((int)day == 7)
                                Console.WriteLine("7-ой день недели - выходной!");
                            else
                                Console.WriteLine("7-ой день недели не выходной!");

                            continue;
                        }

                    case 4:
                        {
                            Stock stock = new Stock();
                            stock.Add(sofa1);
                            stock.Add(sofa2);
                            stock.Add(sofa3);
                            stock.Add(333);
                            stock.Add(sofa1);
                            stock.Add("строка");
                            stock.Remove(2);

                            stock[0] = 228;

                            stock.Print();


                            continue;
                        }
                    case 0:
                        break;

                    default:
                        Console.WriteLine("Проверьте выбор!");
                        continue;
                }

                Console.WriteLine();
            }
        }
    }





}