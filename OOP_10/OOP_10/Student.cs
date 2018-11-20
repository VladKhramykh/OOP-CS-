using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_10
{
    class Student
    {

        string Name="";
        int Age = 0;
        const string Facultat = "ИТ";

        public Student(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }

        public string GetName() => Name;

        public override string ToString()
        {
            Console.WriteLine($"Имя студента: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.Write($"Факультет: {Facultat}");
            return "\n";
        }

    }
}