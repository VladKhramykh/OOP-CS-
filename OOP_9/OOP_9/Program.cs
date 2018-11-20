using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    class Program
    {

        static void Main(string[] args)
        {

            Mind mind = new Mind();



            Programmist Cpp = new Programmist("C++", "4.81");
            Programmist Cs = new Programmist("C#", "7.1");
            Programmist Java = new Programmist("Java", "10.01");
            Programmist JavaScript = new Programmist("JavaScript", "9.0");
            Programmist Swift = new Programmist("Swift", "4.8");

            Cpp.ShowInfo();
            Cs.ShowInfo();
            Java.ShowInfo();
            JavaScript.ShowInfo();
            Swift.ShowInfo();
            mind.E_ReName += new Change(Cpp.ReName);
            mind.E_ReName += new Change(Swift.ReName);
            mind.E_AddPlus += new Change(Java.AddPlus);
            mind.E_AddPlus += new Change(JavaScript.AddPlus);
            mind.AllReName("ASSEMBLER");
            mind.AddPlus();
            Cpp.ShowInfo();
            Cs.ShowInfo();
            Java.ShowInfo();
            JavaScript.ShowInfo();
            Swift.ShowInfo();

            string str = "Габен, та за шо нам это? За шо аквилку-то ?";
            Console.WriteLine($"\t{str}\n");
            
            Action<string> action;
            action = ChangeString.GetLength;
            ChangeString.Operation(str, action);

            Func<string,int> func = ChangeString.CountVowel;
            Console.WriteLine($"Количество гласных в строке: { ChangeString.Operation(str, func)}");
            func = ChangeString.CountConsonats;
            Console.WriteLine($"Количество согласных в строке: { ChangeString.Operation(str, func)}");
            func = ChangeString.CountWords;
            Console.WriteLine($"Количество слов в строке: { ChangeString.Operation(str, func)}\n");



        }   
    }
}
