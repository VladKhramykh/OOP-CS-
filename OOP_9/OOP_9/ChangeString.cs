using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    public static class ChangeString
    {

        public static void Operation(string str, Action<string> action) => action(str);
        public static int Operation(string str, Func<string, int> func) => func(str);
        


        public static int CountVowel(string str)
        {
            int count = 0;

            char[] Vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё','И','О','У','Э','Ю','Я'};

            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j<Vowels.Length; j++)
                {
                    if (str[i] == Vowels[j])
                    {
                        count++;
                        break;
                    }
                }                
            }
            
            return count;
        }
        

        public static int CountWords(string str)
        {
            int count = 0;

            char[] symbols = { ' ', ',', '.', '!', ':', '?', '-' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (str[i] == symbols[j])
                    {
                        for (int k = 0; k < symbols.Length; k++)
                        {
                            if (str[i - 1] == symbols[k])
                                count--;
                        }
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        public static int CountSeparators(string str)
        {
            int count = 0;

            char[] symbols = { ' ', ',', '.', '!', ':', '?', '-', '(', ')', '=', '+', '/', '*', '&', '$', '#', '@' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (str[i] == symbols[j])
                    {                        
                        count++;
                        break;
                    }
                }
            }
            return count;
        }

            public static void GetLength(string str) => Console.WriteLine($"Длина строки: {str.Length}");
            public static int CountConsonats(string str) => (str.Length - CountVowel(str) - CountSeparators(str));
       

    }
}
