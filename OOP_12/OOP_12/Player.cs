using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    public class Player:IComparable

    {

        public string Name { get; private set; }
        public string Team { get; private set; }
        public string Game { get; private set; }

        public Player(string _Name, string _Game, string _Team)
        {
            Name = _Name;
            Game = _Game;
            Team = _Team;
        }

        public int CompareTo(object obj)
        {
            if ((obj as Player).Game == Game)
                return 1;
            else
                return 0;
        }

        public string GetName(string s, int r) => Name;
        public string GetTeam(int i,int t) => Team;
        public string GetGame(double d) => Game;

        public void ShowInfo(string message) => Console.WriteLine($"\nНик игрока:{this.Name}\nКоманда: {this.Team}\nДисциплина: {this.Game}\n{message}\n");
    }
}
