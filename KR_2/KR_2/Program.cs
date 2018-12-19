using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    class Program
    {    

        static void Main(string[] args)
        {
            try
            {
                List<string> Player = new List<string>();

                Player.Add("s1mpe");
                Player.Add("Miracle~");
                Player.Add("no[o]ne");
                Player.Add("Gh");
                Player.Add("fy");

                List<string> Team = new List<string>();

                Team.Add("Virtus Pro");
                Team.Add("Team Liquid");
                Team.Add("PSG.LGD");

                SuperString<List<string>> first = new SuperString<List<string>>(Team, Player);

                Console.WriteLine("Введите искомый элемент");
                string findElement = Console.ReadLine();
                Console.WriteLine(first.Finding(first, findElement));





                Console.WriteLine("Введите длинну названия искомого бренда (количество симовлов)");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите первую букву искомого бренда");
                char firstSymbol = Convert.ToChar(Console.ReadLine());

                string[] phoneBrand = new string[] { "Xiaomi", "Samsung", "Apple", "Huawei", "Prestigio", "Lenovo", "OnePlus" };

                var findBrand = from n in phoneBrand
                                where n.Length == length && n.First() == firstSymbol
                                select n;
                foreach (var n in findBrand)
                    Console.WriteLine(n);


                Gamer firsts = new Gamer("Валера");
                Gamer second = new Gamer("Санчоус");
                firsts.or += ARATb;
                second.or += ARATb;
                firsts.aremGol();
                second.aremGol();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public class SuperString<T> : List<T>
        {
            List<string> olee = new List<string>();
            List<string> aaaa = new List<string>();

            public SuperString(List<string> ammo, List<string> army)
            {
                this.olee = ammo;
                this.aaaa = army;
            }

            public string Finding(SuperString<List<string>> o, string value)
            {
                List<string> newList = new List<string>();
                newList.AddRange(olee);

                newList.AddRange(aaaa);
                if (newList.Contains(value))
                {
                    return value;
                }
                else throw new Exception("нима такого");
            }

        }

        public class Game
        {
            public delegate void GOL(string message);
            public event GOL or;
            public void aremGol()
            {
                if (or != null)
                {
                    Console.WriteLine("Хароош");
                }
            }
        }

        class Gamer : Game
        {
            public string name;
            public Gamer(string name)
            {
                this.name = name;
            }

        }

        public static void ARATb(string message)
        {
            Console.WriteLine(message);
        }
        
    }

}
