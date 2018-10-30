using System;
using System.Diagnostics;

namespace OOP_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            for (; ; )
            {
                Console.WriteLine("\n\nВыберите действие:\n \t1 - Работа с объектами + сортировка по цене\n \t2 - is и as \n \t3 - Структуры и перечисления");
                Console.WriteLine("\t4 - Работа с классом-контейнером\n \t5 - Деление на ноль\n \t6 - Assert\n");
                try
                {  
                    
                    var bed1 = new Bed("Аврора 7", 2, "200x180", 254.99d, "ООО 'Территория сна'", "Комнатная", "Кровать");
                    var sofa1 = new Sofa("Счастье", 8, "238x95x120", 899.99d, "ООО 'Живые диваны'", "Комнатная", "Диван");
                    IFurniture sofa2 = new Sofa("Радость", 8, "138x135x170", 399.99d, "ООО 'Живые диваны'", "Комнатная", "Диван");
                    var sofa3 = new Sofa("Здоровье", 8, "268x95x140", 199.99d, "ООО 'ВитебскДиван'", "Комнатная", "Диван");
                    var sofa4 = new Sofa("Апполинария", 8, "178x95x120", 1899.99d, "ООО 'ПинскДрев'", "Комнатная", "Диван");
                    var sofa5 = new Sofa("Штормград", 8, "238x95x110", 799.99d, "ООО 'Ами Мебель'", "Комнатная", "Диван");
                    var wardrobe1 = new Wardrobe("Ревьера", "150x216x58", 1399.99d, 8, "Лагуна", "Комнатная", "Шкаф");
                    int intChoice; 
                    string choice = Console.ReadLine();
                    if (!(Int32.TryParse(choice, out intChoice)))
                        throw new ChoiceExceptions("Что ты там нажал!");
                    else if(intChoice < 0 || intChoice > 6)
                        throw new ChoiceExceptions("Неккоректно выбрано действие!", intChoice);


                    switch (intChoice)
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
                                stock.Remove(3);

                                stock[8] = 228;

                                //stock.Print();

                                Controller controller = new Controller(stock);
                                controller.SearchName("ООО 'Живые диваны'");
                                Console.WriteLine(stock.getCount());
                                Console.WriteLine($"Сумма всех диванов на складе: {controller.SumOfSofas()}");


                                continue;
                            }

                        case 5:
                            {
                                int nool = 0;
                                int i = 4 / nool;
                                continue;
                            }
                            

                        case 6:
                            {
                                int x = 10;
                                Debug.Assert(x < 8);
                                continue;
                            }
                            

                        case 0:
                            break;

                        default:
                            //Console.WriteLine("Проверьте выбор!");
                            continue;
                    }

                    Console.WriteLine();
                }
                catch(ChoiceExceptions e)
                {
                    Console.WriteLine("\n\t!!! ОШИБКА !!!");
                    Console.WriteLine($"Ошибка: {e.message}");
                    Console.WriteLine($"Неверное значение: {e.choice}\n");                    
                }

                catch (SetExceptions e)
                {
                    Console.WriteLine("\n\t!!! ОШИБКА !!!");
                    Console.WriteLine($"Ошибка: {e.message}");
                    e.obj.PrintInfo();
                    Console.WriteLine($"Нельзя задать отрицательную цену: {e.inCorrectCost}\n");
                   
                    
                }

                catch (StockExceptions e)
                {
                    Console.WriteLine("\n\t!!! ОШИБКА !!!");
                    Console.WriteLine($"Ошибка: {e.message}");                    
                    Console.WriteLine($"Такого товара нету: {e.value}\n");

                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("\n\t!!! ОШИБКА !!!");
                    Console.WriteLine("Ошибка:" + e.Message);
                   
                }
                
                finally
                {
                    Console.WriteLine(" ОПА ЭФ 5");
                }


            }
            
        }
        
    }





}