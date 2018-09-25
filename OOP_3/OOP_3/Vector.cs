using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Vector
    {
        int[] array;
        int status = 0;
        int length = 0;
        public readonly string myName = " Храмых Владислав";
        Random rnd = new Random();

        public Vector()
        {
            array = new int[10];
            length = 10;
            //for (int count = 0; count<length; count++)
            //    array[count] = (rnd.Next(100)/13);    
        }

        public Vector(int size)
        {
            array = new int[size];
            length = size;
            for (int count = 0; count < length; count++)
                array[count] = (rnd.Next(-100,100)/3);
        }

        public Vector(int Item1, int Item2, int Item3, int Item4, int size)
        {
            array = new int[] { Item1, Item2,Item3,Item4};
            length = size;
        }

        public int this[int i]
        {
            get
            {
                if (i < 0 && i > length)
                    status = 100;
                return status;
            }
            set
            {
                if (i >= 0 && i <= length)
                {

                    if (value <= 100 & value > -100)
                        array[i] = value;
                    else
                        status = 200;
                }
                else
                    status = 100;
            }
        }

        public void PrintArray()
        {
            for (int count = 0; count < this.length; count++)
                Console.Write(array[count]+" ");
        }

        public int SumArray()
        {
            int sum = 0;
            for (int i = 0; i < this.length; i++)
                sum += array[i];
            return sum;
        }

        public int MulpiplyArray()
        {
            int Mul = 1;
            for (int i = 0; i < this.length; i++)
                Mul += array[i];
            return Mul;
        }

        public bool isNullInArray()
        { 
            for(int i = 0; i<this.length; i++)
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
    }


    class CloseClass
    {
        CloseClass()
        {
            this.index = 30;
        }
        public int index = 10;
    }

    class StaticClass
    {
        static public int countSC = 0;
        static StaticClass()
        {
            countSC++;
        }
    }
}
