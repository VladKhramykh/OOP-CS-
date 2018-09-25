using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            String MyName = "\nХрамых Владислав Олегович";
            int Age = 18;
            double MyHeight = 1.85d;
            float cource = 2f;
            char gruppe = '6';

            Console.WriteLine(MyName + "\n" + Age + " лет \n" + "ФИТ " + cource + " курс " + gruppe + " группа\n");

            // Неявыне преобразвования
            long NumL = 500;
            double NumD = NumL;
            Console.WriteLine("из long в double " + NumD);
            byte NumB = 4;
            short NumBS = NumB;
            Console.WriteLine("из byte в short " + NumBS);
            float NumF = NumBS;
            Console.WriteLine("из short в float " + NumD);
            NumL = NumB;
            Console.WriteLine("из byte в long " + NumD);
            int NumI = 40;
            NumD = NumI;
            Console.WriteLine("из int в double " + NumD);
            // Явные преобразования
            NumL = (long)NumB;
            NumBS = (short)NumB;
            NumD = (double)NumI;
            NumL = (long)NumI;
            NumI = (int)gruppe;

            int index = 354;
            Console.WriteLine("Работа с неявно типизированной переменной:");
            Console.WriteLine("Разделили (int)354 на 15: " + (double)index / 15);

            System.Nullable<int> x = null;
            //          или так: 
            //          int count? = null;
            int y = x ?? 1; // возвращает левый операнд, если он не равен nullable
            Console.WriteLine(" count стал = " + y);
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");



            String Str1 = "Калач Денис";
            String Str2 = "Немкевич Евгений";
            String Str3 = "Храмых Владислав";

            // Сравнение строк

            //if (Str1 == Str2)
            //    Console.WriteLine("\nДеня и Жека один и тот же чел\n");
            //else
            //    Console.WriteLine("\nЖека и Денис НЕ один и тот же чел\n");

            // или так: 
            if (Str1.Equals(Str2))
                Console.WriteLine("\nДеня и Жека один и тот же чел\n");
            else
                Console.WriteLine("\nЖека и Денис НЕ один и тот же чел\n");

            //Конкатенация строк:

            //String Str12 = Str1 + Str2;
            //Console.WriteLine(Str12);

            // или вот так:
            String StrConcat = "";
            StrConcat = String.Concat(Str1, Str3);
            Console.WriteLine(StrConcat);


            // Копирование строк
            String StrCopy = "";
            StrCopy = String.Copy(Str3);
            Console.WriteLine(Str3);


            // Разделение строки на слова
            String StrSplit = "Я сдам лабу с первого раза";
            byte Count = 0;
            string[] Words = StrSplit.Split(' ');
            foreach (string Word in Words)
            {
                Console.WriteLine(Word);
                Count++;
            }
            Console.WriteLine("\t Всего слов : " + Count);


            // Вставка подстроки 
            String Str123 = " ( ну сдам же )";
            Console.WriteLine(StrSplit.Insert(3, Str123));

            
            // Удаление подстроки
            String StrRemove = "\n Вы не можете принять у меня лабу с первого раза";
            Console.WriteLine(StrRemove);
            Console.WriteLine("\tОЙ , ТУТ ЧТО-ТО ЛИШНЕЕ!");
            Console.WriteLine("Вот! Теперь так: " + StrRemove.Remove(4, 3));


            // null строка
            String StrNull = null;
            String StrNull1 = StrNull;
            String StrNull2 = StrNull;


            // Дествия с null строкой
            StrNull1 = String.Copy(MyName);
            Console.WriteLine(StrNull1);
            StrNull2 = String.Concat(StrNull2, MyName);


            // StringBuider()
            StringBuilder stringBuilder = new StringBuilder("Здесь строка, построенная при помощи объекта StringBuilder");
            Console.WriteLine(stringBuilder);
            Console.WriteLine("\t После удаления последнего и первого элемента: ");
            int SbLength = stringBuilder.Length;
            stringBuilder.Remove(SbLength - 1, 1);
            stringBuilder.Remove(0, 1);
            Console.WriteLine(stringBuilder);
            Console.WriteLine("а теперь встатвим в эти же позиции новые символы: ");
            stringBuilder.Insert(SbLength - 2, "#");
            stringBuilder.Insert(0, "#");
            Console.WriteLine(stringBuilder);
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");



            // Двухмерные матрицы
            int[,] matrix = new int[4, 4];
            Random Rnd = new Random();
            Console.WriteLine(matrix.Length);
            for (int count1 = 0; count1 < 4; count1++)
            {
                for (int count2 = 0; count2 < 4; count2++)
                {
                    matrix[count1, count2] = Rnd.Next(-10, 10);
                    Console.Write("\t{0}", matrix[count1, count2]);
                }
                Console.WriteLine();
            }

            // Массив строк и дейстаия над ним
            String[] StrArray = new String[5] { "Денис", "Влад", "Женя", "Дима", "Саня" };            
            int StrArrayLength = StrArray.Length;
            Console.WriteLine("Всего слов в массиве: {0}", StrArrayLength);
            Console.Write("Вот наш маccив строк: ");
            for (int i = 0; i<StrArrayLength;i++)
                Console.Write(StrArray[i]+"\t");
            Console.Write("\nВ какую позицию ставим?");
            int toArray = Convert.ToInt32(Console.ReadLine());                       
            if (toArray > 0 && toArray < StrArrayLength+1)
            {
                Console.Write("\nKакое слово будем вставлять? \t");
                String NewName = Console.ReadLine();
                StrArray[toArray - 1] = NewName;
                Console.WriteLine("Замена выполнена!!!");
                Console.Write("\tПолучившийся массив:\t");
                for (int i = 0; i < StrArrayLength; i++)
                    Console.Write(StrArray[i] + "\t");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Проверьте номер заменяемого элемента!\n");


            // Работа со ступенчатым массивом
            Console.WriteLine("Работа со ступенчатым массивом: \n Введите элементы в массив: \n");
            int[][] SteppedArray = new int[3][];
            SteppedArray[0] = new int[2];
            SteppedArray[1] = new int[3];
            SteppedArray[2] = new int[4];
            for (int i = 0; i < 3; i++)
            {
                int SteppedArrayLength = SteppedArray[i].Length;
                for(int countA = 0; countA<SteppedArrayLength;countA++)
                {
                    Console.Write("[{0}][{1}] = ", i, countA);
                    SteppedArray[i][countA] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                int SteppedArrayLength = SteppedArray[i].Length;
                for (int countA = 0; countA < SteppedArrayLength; countA++)
                {
                    Console.Write(SteppedArray[ i][countA]+"\t");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Неявно типизированные массив и строка
            var ArrayString = new[] { "Доброе утро", "Good Morning", "Guten Morgen" };
            var ArrayNumbers = new[] {3,145,15,13,5,345,7,2,5,14,124,2};
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");




            // Кортежи

            String Name = "Владислав";
            var Tuple = Corteg(ArrayNumbers, Name);
            Console.WriteLine("Минимальный элемент: {0}\n Максимальный элемент: {1} \n Сумма: {2} \n Первая буква имени: {3}",Tuple.Item1,Tuple.Item2,Tuple.Item3,Tuple.Item4);

            (int age, string name, char group, string facultat, ulong cource) student = (18, "Vlad", '6', "IT", 2);
            Console.WriteLine($"{student}");
            Console.WriteLine($"Студент {student.name}, которому {student.age} лет, учится в {student.group} -ой группе на {student.cource} курсе факультета {student.facultat}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------");



            // Локальные функции
            Console.WriteLine("Сумма чисел до 10(включая 10) с помощью локальной функции ");
            Console.WriteLine(getSum(10));
        }


        static Tuple<int,string,char,string,ulong> Corteg1(int num, string str1,char symbol,string str2, ulong unum)
        {
            return Tuple.Create(num, str1, symbol, str2, unum);
        }


        static Tuple<int, int, int, char> Corteg(int[] ArrayNumbers, string Name)
        {
            int max = ArrayNumbers.Max();
            int min = ArrayNumbers.Min();
            int sum = ArrayNumbers.Sum();
            char FirstSymbol;
            FirstSymbol = Name[0];
            return Tuple.Create<int, int, int, char>(min, max, sum, FirstSymbol);
        }

        static int getSum(int x)
        {
            return LocFunc();

            int LocFunc()
            {
                int sum = 0;
                for (int i = 1; i <= x; i++)
                    sum += i;
                return sum;
            }            
        }

    }
}
