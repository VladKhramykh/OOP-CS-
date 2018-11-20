using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    class Programmist
    {
        public delegate void PrintDel(string Message);

        PrintDel del = ShowMessage;

        string languageName;
        string version;
        bool plus = false;

        public Programmist( string _languageName, string _version)
        {
            languageName = _languageName;
            version = _version;
        }

        public void ReName(string _languageName)
        {
            del($"\tИмя было {languageName} изменено с на {_languageName}");
            languageName = _languageName;            
            
        }

        public void ReVersion(string _version)
        {
            del($"\tВерсия была обновлена с {version} на {_version}");
            version = _version;

        }        

        public void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Название языка: {languageName}");
            Console.WriteLine($"Версия языка: {version}");
            Console.WriteLine($"Full подписка: {(plus ? "Да":"нет")}\n");
        }

        public static void ShowMessage(string Message) => Console.WriteLine(Message);
        

        public void AddPlus(string str)
        {
            plus = true;
            del($"\tПодписка на Full версию оформлена! ({languageName})");
        }

    }
}
