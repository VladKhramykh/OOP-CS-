using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();
            LinkedList<bool> linkedList = new LinkedList<bool>();
            Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            ObservableCollection<Student> numbers = new ObservableCollection<Student>();

            Student Vlad = new Student("Vlad", 18);
            Student Dima = new Student("Dima", 19);
            Student Denis = new Student("Denis", 18);
            Student Yura = new Student("Yura", 17);
            Student Roma = new Student("Roma", 19);

            int choice;
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\n1-Работа с необобщённой коллекцией\n2-Работа с обобщённой коллекцией\n0-Выход\n");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------------------------");
                    switch (choice)
                    {
                        case 1:
                            {
                                arrayList.Add(5);
                                arrayList.Add(4);
                                arrayList.Add(11);
                                arrayList.Add(23);
                                arrayList.Add(-12);
                                arrayList.Add("Дороу");
                                arrayList.Add(Vlad);

                                foreach (object o in arrayList)
                                    Console.WriteLine(o.ToString());

                                Console.WriteLine("Удалил 4 элемент");
                                arrayList.RemoveAt(2);

                                foreach (object o in arrayList)
                                    Console.WriteLine(o.ToString());
                                Console.WriteLine($"Количество элементов в коллекции LinkedList:{arrayList.Count}\n");

                                foreach (object o in arrayList)
                                    Console.WriteLine(o.ToString());


                                continue;
                            }
                        case 2:
                            {
                                linkedList.AddLast(true);
                                linkedList.AddLast(false);
                                linkedList.AddLast(true);
                                linkedList.AddLast(true);
                                linkedList.AddLast(true);
                                linkedList.AddLast(false);
                                linkedList.AddLast(false);
                                linkedList.AddLast(true);
                                

                                foreach (bool o in linkedList)
                                    Console.WriteLine(o);

                                int i = 1;
                                foreach (bool o in linkedList)
                                {
                                    keyValuePairs.Add(i, o);
                                    i++;
                                }
                                i = 1;

                                Console.WriteLine();
                                foreach (object o in keyValuePairs)
                                    Console.WriteLine(o);


                                students.Add(i++, Vlad);
                                students.Add(i++, Denis);
                                students.Add(i++, Dima);
                                students.Add(i++, Yura);
                                students.Add(i++, Roma);


                                foreach (var pair in students)
                                    Console.WriteLine($"\n{pair.Value.ToString()}\nID: {pair.Key}");

                                numbers.CollectionChanged += Numbers_CollectionChanged;

                                numbers.Add(Vlad);
                                numbers.Add(Denis);
                                numbers.Add(Roma);
                                numbers.Remove(Roma);
                                numbers.Add(Dima);
                                numbers.Remove(Dima);
                                numbers.Add(Yura);

                                continue;
                            }
                        case 0:
                            {
                                flag = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Проверьте ваш выбор!");
                                continue;
                            }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static void Numbers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Console.WriteLine($"\nЗачислен студент: {((e.NewItems[0])as Student).GetName()}");
                        break;
                    }
                case NotifyCollectionChangedAction.Remove:
                    {
                        Console.WriteLine($"\nОтчислен: {((e.OldItems[0]) as Student).GetName()}");
                        break;
                    }
                case NotifyCollectionChangedAction.Replace:
                    {
                        Console.WriteLine($"Число: {((e.OldItems[0]) as Student).GetName()} заменено на {((e.NewItems[0]) as Student).GetName()}");
                        break;
                    }
            }
        }


    }
}
