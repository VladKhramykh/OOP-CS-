using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Vector
    {
        public const String labName = "Лабороторная работа №3";

        static int VectorCount = 0;
        public static int Count { get; private set; } = 0;
        int[] array;
        int Length = 0;
        public readonly string myName = " Храмых Владислав";
        Random rnd = new Random();        
        static Vector()
        {
            Count++;
        }
        public Vector()
        {
            array = new int[10];
            Length = 10;
            for (int count = 0; count<Length; count++)
                array[count] = (rnd.Next(-100,100)/13);
            VectorCount++;
        }

        public Vector(int size)
        {
            array = new int[size];
            Length = size;
            for (int count = 0; count < Length; count++)
                array[count] = (rnd.Next(-100,100)/3);
            VectorCount++;
        }

        public Vector(int Item1, int Item2, int Item3, int Item4, int size)
        {
            array = new int[] { Item1, Item2,Item3,Item4};
            Length = size;
            VectorCount++;
        }

        public int this[int i]
        {
            get
            {
                if (i < 0 && i > Length)
                    Console.WriteLine("Пpоверьте диапазон элементов массива");
                return 101;
            }
            set
            {
                if (i >= 0 && i <= Length)
                {

                    if (value <= 100 & value > -100)
                        array[i] = value;
                    else
                        Console.WriteLine("Пpоверьте диапазон заданных значений");
                }
                else
                    Console.WriteLine("Пpоверьте диапазон элементов массива");
            }
        }

        public void PrintArray()
        {
            for (int count = 0; count < this.Length; count++)
                Console.Write(array[count]+" ");
        }

        public int SumArray()
        {
            int sum = 0;
            for (int i = 0; i < this.Length; i++)
                sum += array[i];
            return sum;
        }

        public int MulpiplyArray()
        {
            int Mul = 1;
            for (int i = 0; i < this.Length; i++)
                Mul += array[i];
            return Mul;
        }

        public bool IsNullInArray()
        { 
            for(int i = 0; i<this.Length; i++)
            {
                if (array[i] == 0)                
                    return true;                                            
            }
            return false;
        }
        public int GetMin()
        {
            return array.Min();
        }
        public static int GetCount()
        {
            return VectorCount;
        }
    }


    class CloseClass
    {
        CloseClass()
        {
            index++;
        }
        public static int index = 0;
    }

    partial class Student
    {
        public string Name { get; private set;}
        public int Age { get; private set;}

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Student _Equal = (Student)obj;
            return (this.Name == _Equal.Name && this.Age == _Equal.Age);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = string.IsNullOrEmpty(Name)? 0 : Name.GetHashCode();
            hash = (hash * -47) + Age.GetHashCode();
            return hash;
        }
    }

    partial class Student
    {
        public Student(string name, int age )
        {
            this.Name = name;
            this.Age = age;
        }
    }


    
}
