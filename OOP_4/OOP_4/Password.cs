using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Password
    {
        class Ownew
        {
            int Id = 26;
            string Name = "Храмых Влад";
            string UO = "BSTU";

            public Ownew(int Id, string Name, string UO)
            {
                this.Id = Id;
                this.Name = Name;
                this.UO = UO;
            }
        }

        
        string password = "";        
        public int GetLength()
        {
            return this.password.Length;
        }
        public Password()
        {            
            Console.WriteLine("Пустое поле для пароля создано!");
        }
        public Password(string password)
        {
            if (password.Length >= 6 && password.Length <= 12)
                this.password = password;
            else
                Console.WriteLine("Пароль должен содержать 6-12 символов!");
        }

        public string Pass
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 12)
                    password = value;
                else                
                    Console.WriteLine("Пароль должен содержать 6-12 символов! ");                                    
            }
        }

        public static string operator -(Password pass, char symbol)
        {

            int length = pass.password.Length;
            char[] arrayChars = pass.password.ToCharArray();
            arrayChars[length - 1] = symbol;
            string str1 = new string(arrayChars);
            pass.password = str1;
            return pass.password;

        }

        public static bool operator >(Password pass1,Password pass2)
        {

            if (pass1.password.Length > pass2.password.Length)
                return true;
            else
                return false;
        }

        public static bool operator <(Password pass1, Password pass2)
        {

            if (pass1.password.Length < pass2.password.Length)
                return true;
            else
                return false;
        }

        public static bool operator != (Password pass1, Password pass2)
        {
            if (pass1.password == pass2.password)
                return false;
            else
                return true;
        }

        public static bool operator ==(Password pass1, Password pass2)
        {
            if (pass1.password == pass2.password)
                return true;
            else
                return false;
        }

        public static Password operator ++(Password pass)
        {
            pass.password = "12345678";
            return pass;
        }   
        
        public static bool operator true(Password pass)
        {
            string password = pass.password;
            int Length = pass.password.Length;
            Console.WriteLine(Length);
            Console.WriteLine(password);
            int status = 0;
            string u_letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string l_letters = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "1234567890";
            string special = "~!@#$%^&*()-_=+[{]}:',<.>/?|";
            for (int i = 0; i<Length; i++)
            {
                if (u_letters.IndexOf(password[i]) != -1)
                    status += 5;
                else if (l_letters.IndexOf(password[i]) != -1)
                    status += 1;
                else if (digits.IndexOf(password[i]) != -1)
                    status += 2;
                else if (special.IndexOf(password[i]) != -1)
                    status += 3;
            }
            if (Length < 7 || status < 10)
                return false;
            //Console.WriteLine("Ваш пароль простой!");
            if (Length > 10 || (Length > 7 && status > 30))
                return true;
            // Console.WriteLine("Ваш пароль сложный!");
            else
                return false;
                //Console.WriteLine("Ваш пароль средний!");
        }


        public static bool operator false(Password pass)
        {
            string password = pass.password;
            int Length = pass.password.Length;
            int status = 0;
            string u_letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string l_letters = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "1234567890";
            string special = "~!@#$%^&*()-_=+[{]}:',<.>/?|";
            for (int i = 0; i < Length; i++)
            {
                if (u_letters.IndexOf(password[i]) != -1)
                    status += 5;
                else if (l_letters.IndexOf(password[i]) != -1)
                    status += 1;
                else if (digits.IndexOf(password[i]) != -1)
                    status += 2;
                else if (special.IndexOf(password[i]) != -1)
                    status += 3;
            }
            if (Length < 7 || status < 10)
                return false;
            //Console.WriteLine("Ваш пароль простой!");
            else if (Length > 14 || (Length > 10 && status > 30))
                return true;
            // Console.WriteLine("Ваш пароль сложный!");
            else
                return false;
            //Console.WriteLine("Ваш пароль средний!");
        }
    }
}



