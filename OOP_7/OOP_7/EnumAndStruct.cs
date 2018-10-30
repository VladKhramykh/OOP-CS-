using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_7
{
    struct Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Write()
        {
            Console.WriteLine($" Имя: {name}\n Воозраст: {age}\n");
        }
    }

    enum DaysOfWeek
    {
        monday = 1,
        tuesday,
        westerday,
        thursday,
        friday,
        saturday,
        sunday
    }


}