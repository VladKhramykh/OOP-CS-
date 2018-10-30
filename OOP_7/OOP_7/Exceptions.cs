using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    class ChoiceExceptions: Exception
    {
        public string message;
        public int choice;
        public ChoiceExceptions(string info)
        {
            message = info;
        }
        public ChoiceExceptions(string info, int choice)
        {
            this.choice = choice;
            message = info;
        }
    }

    class SetExceptions: Exception
    {
        public string message;
        public double inCorrectCost;
        public Furniture obj;
        public SetExceptions(string info, double cost, object obj)
        {
            message = info;
            inCorrectCost = cost;
            this.obj = (Furniture)obj;
        }
    }

    class StockExceptions: Exception
    {
        public string message;
        public int value;

        public StockExceptions(string message, int value)
        {
            this.message = message;
            this.value = value;
        }
    }
}
