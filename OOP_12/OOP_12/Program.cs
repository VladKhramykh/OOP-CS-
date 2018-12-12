using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    class Program
    {
        const string path = @"G:\УЧЁБА\ООП_CS\OOP_12\OOP_12\info.txt";
        static void Main(string[] args)
        {
            Player s1mple = new Player("s1mple", "CS:GO", "NAVI");
            Player Miracle = new Player("Miracle~", "Dota2", "TeamLiquid");
            Player Dendi = new Player("Dendi", "Dota2", "NAVI");
            Player device = new Player("device", "CS:GO", "Astralis");
            Player Twistzz = new Player("Twistzz", "CS:GO", "TeamLiquid");

            Reflector.ShowPublicMethods($"{typeof(Player)}");
            Reflector.MethodsAndFieldsInfo($"{typeof(Programmist)}");
            Reflector.ShowInterfaces($"{typeof(Int32)}");
            Reflector.UsersTypeParmInMethods($"{typeof(Player)}", "Int32");
            Reflector.CallFromFile(Miracle, "ShowInfo");

        }
    }
}
