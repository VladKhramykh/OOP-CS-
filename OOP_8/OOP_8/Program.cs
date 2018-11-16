using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{

    

    class Program
    {
        class Date
        {
            public string date = DateTime.Now.ToString();
        }

        static void Main(string[] args)
        {

            string writePath = @"G:\УЧЁБА\ООП_CS\OOP_8\OOP_8\info.txt"; 

            Program.Date Date = new Date();
            Console.WriteLine("Дата создания: {0}", Date.date);
            Console.WriteLine(" Если пароль не соответствует правилам, то он переназначается по умолчанию (12345678)");
            Password<int> pass1 = new Password<int>("1fasasdadsfasf2");
            pass1.Id = 1;
            Password<string> pass2 = new Password<string>();
            pass2.Id = "Пустой";
            Password<string> pass3 = new Password<string> ("45Td99_weqR1");
            pass3.Id = "Сложный пароль";
            Password<int>[] PassArrayInt = { pass1};
            Password<string>[] PassArrayString = {pass2, pass3 };
            Console.WriteLine(" Минимальная длина: "+MathOperations.GetMax(PassArrayInt, PassArrayString));
            Console.WriteLine(pass3.read());
            pass3.NewValue("chianik");
            Console.WriteLine(pass3.read()+'\n');
            User<Sofa> user = new User<Sofa>();
            user.Add(new Sofa("Старый", 2, "189x150x70", 734.99d, "АМИ Мебель", "Комнатная", "Диван"));
            user.Add(new Sofa("Старый", 2, "189x150x70", 734.99d, "АМИ Мебель", "Комнатная", "Диван"));
            user.Add(new Sofa("Старый", 2, "189x150x70", 734.99d, "АМИ Мебель", "Комнатная", "Диван"));
            user.Add(new Sofa("Старый", 2, "189x150x70", 734.99d, "АМИ Мебель", "Комнатная", "Диван"));
            user.Add(new Sofa("Старый", 2, "189x150x70", 734.99d, "АМИ Мебель", "Комнатная", "Диван"));

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach(Sofa t in user.Sofas)
                    {
                        t.ToStringSW(sw);
                    }

                }
                    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            user.PrintShortInfo();

        }

    }
}
