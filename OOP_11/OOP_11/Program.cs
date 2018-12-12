using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int n = 5;
            List <Vector> vectors = new List<Vector>();

            //var selectedMonths = from t in months
            //                     where t.Length == n
            //                     orderby t
            //                     select t;
            
            var selectedMonths = months.Where(t => t.Length == n).OrderBy(t => t);
           
            var summerMonths = months.Where(t => (t == "June" || t == "July" || t == "August")).OrderBy(t=>t);
            var winterMonths = months.Where(t => (t == "December" || t == "January" || t == "February")).OrderBy(t=>t);
            var containMonths = months.Where(t => ((t.Contains("u")) && t.Length >= 4)).OrderBy(t=>t);

            foreach (var t in selectedMonths)
                Console.WriteLine(t);
            Console.WriteLine("\nЛетние месяцы:");
            foreach (var t in summerMonths)
                Console.WriteLine($"\t{t}");
            Console.WriteLine("\nЗимние месяцы:");
            foreach (var t in winterMonths)
                Console.WriteLine($"\t{t}");
            Console.WriteLine("\nСодержит 'u':");
            foreach (var t in containMonths)
                Console.WriteLine($"\t{t}");

            Vector vector1 = new Vector();
            Vector vector2 = new Vector(8);
            Vector vector3 = new Vector(3, 8, 1, 0, 4);

            vectors.Add(vector1);
            vectors.Add(vector2);
            vectors.Add(vector3);

            vector1.PrintArray();
            vector2.PrintArray();
            vector3.PrintArray();

            var nullInArray = vectors.Where(t => (t.IsNullInArray() == true));
            var minInArray = vectors.Where(t =>t.GetLength()>0).Min(t=>t.GetLength());
            var maxInArray = vectors.Where(t => t.GetLength() > 0).Max(t => t.GetLength());
            var sizeArray5 = vectors.Where(t => (t.GetLength() == 4 || t.GetLength() == 8));
            var SortArray = vectors.Where(t => t.GetLength() > 0).OrderBy(t => t.GetLength());

            Console.WriteLine($"Мин длинна вектора: {minInArray}");
            Console.WriteLine($"Макс длинна вектора: {maxInArray}");
            Console.WriteLine("Вектора, в которых есть 0:");
            foreach (var t in nullInArray)
                t.PrintArray();
            Console.WriteLine("Длина векторов = 4 и 8:");
            foreach (var s in sizeArray5)
                s.PrintArray();
            Console.WriteLine("По возрастанию:");
            foreach (var s in SortArray)
                s.PrintArray();

            var ownSample = vectors.Where(t=>t.GetLength() > 0).OrderBy(t=>t.SumArray()).Last().SumArray();
            Console.WriteLine($"Самая большая сумма вектора: {ownSample}\n");

            List<Player> players = new List<Player>()
            {
                new Player{Name = "Miracle~", Team = "TeamLiquid"},
                new Player{Name = "No[o]ne~", Team = "Virtus Pro"},
                new Player { Name = "RAMZES666", Team = "Virtus Pro" },
                new Player { Name = "fy", Team = "PSG.LGD" }
            };

            List<Team> teams = new List<Team>()
            {
                new Team {Name = "TeamLiquid", Country = "Европа"},
                new Team {Name = "Virtus Pro", Country = "СНГ"},
                new Team { Name = "PSG.LGD", Country = "Китай" }
            };

            var plInfo = from pl in players
                         join t in teams on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            foreach (var pl in plInfo)
                Console.WriteLine($"Игрок: {pl.Name}\nКоманда: {pl.Team}\nСтрана: {pl.Country}\n--------------------------------");


        }
    }

    class Player
    {
        public string Name;
        public string Team;
    }

    class Team
    {
        public string Name;
        public string Country;
    }

}
