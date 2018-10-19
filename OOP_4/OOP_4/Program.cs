using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Program
    {
        class Date
        {
            public string date = DateTime.Now.ToString();           
        }

        static void Main(string[] args)
        {
            Program.Date Date = new Program.Date();
            Console.WriteLine("Дата создания: {0}", Date.date);
            Console.WriteLine(" Если пароль не соответствует правилам, то он переназначается по умолчанию (12345678)");
            Password pass1 = new Password("1fasasdadsfasf2");
            Password pass2 = new Password();
            Password pass3 = new Password("45Td99_weqsd");
            Password[] PassArray = { pass1, pass2, pass3 };            
            pass2.Pass = "Edf23&dj!kD";            
            pass2.Pass = pass2 - 'и';
            Console.WriteLine(pass2.Pass);
            Console.WriteLine(pass1.Pass.Length + "  " + pass2.Pass.Length);
            if (pass1 > pass2)
                Console.WriteLine("pass1 > pass2)");
            else
                Console.WriteLine("pass1 =< pass2");
            pass1++;
            Console.WriteLine(pass1.Pass);
            if (pass2.RightLength())
                Console.WriteLine("Длина пароля нормальная");
            else
                Console.WriteLine("Проверь длину пароля!");
            if (pass2)
                Console.WriteLine(" Пароль сложный!");
            else
                Console.WriteLine(" Пароль простой!");
            Console.WriteLine(pass1.MidSymbol());

            Console.WriteLine(MathOperations.GetMax(PassArray));
        }
    }
}
