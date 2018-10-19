using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    class Product
    {
        protected string name;       
        public Product(string name)
        {
            this.name = name;
        }
    }

   

    interface IFurniture 
    {
        void Print();
        void CostSort();
    }



     abstract class Furniture : Product
    {
        protected string type;
        protected string model { get; set; }
        protected string manufacturer;
        protected double cost;

        public double Cost
        {
            get
            {
                return cost;
            }
                
            
                
            
            set
            {
               
                if (value > 0)
                    cost = Math.Round(value, 2);
                else
                    Console.WriteLine("Проверьте значение!");
            }
        }


        public Furniture( string type,string name) : base (name)
        {
            this.type = type;
        }

        public abstract void Print();
        

    }

    class Sofa : Furniture
    {
        private int places;
        private string sizes;
        static int Count = 0;
        static Sofa[] sofas = new Sofa[255];

        public Sofa(string model, int places, string sizes, double cost, string manufacturer,string type, string name ) : base (type,name)
        {
            this.model = model;
            this.places = places;
            this.Cost = cost;
            this.sizes = sizes;
            this.manufacturer = manufacturer;
            sofas[Count] = this;
            Count++;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Количество мест: {places}");
            Console.WriteLine($"Длина х Высота х Глубина: {sizes}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }
         public static void CostSort()
        {
            for(int i = 0; i<Count-1; i++)
            {
                for(int k =1; k<Count; k++)
                {
                    if (sofas[k].Cost < sofas[i].Cost)
                    {
                        Sofa tmp;
                        tmp = sofas[i];
                        sofas[i] = sofas[k];
                        sofas[k] = tmp;
                    }
                }
            }

           for(int i = 0; i<Count; i++)
            {
                sofas[i].Print();
            }


        }
    }

    sealed class Bed : Furniture, IFurniture
    {
        private int places;
        private string sizes;

        public Bed(string model, int places, string sizes, double cost, string manufacturer, string type, string name) : base (type, name)
        {
            this.model = model;
            this.places = places;
            this.Cost = cost;
            this.sizes = sizes;
            this.manufacturer = manufacturer;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Количество мест: {places}");
            Console.WriteLine($"Длина х Ширина: {sizes}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }

        public void CostSort()
        {

        }
    }

    class Wardrobe : Furniture, IFurniture
    {
        private string sizes;
        private int shelves;
        public Wardrobe(string model, string sizes, double cost, int shelves, string manufacturer, string type, string name) : base(type, name)
        {
            this.model = model;
            this.sizes = sizes;
            this.Cost = cost;
            this.shelves = shelves;
            this.manufacturer = manufacturer;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Ширина x Bысота x Глубина: {sizes}");
            Console.WriteLine($"Количество полок: {shelves}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }

        public void CostSort()
        {

        }
    }

    class Slideng : Furniture, IFurniture
    {
        private int sizes;
        private int shelves;
        private int numberOfDoor;
        public Slideng(string model, int sizes, double cost, int shelves, int numberOfDoor, string manufacturer, string type, string name) : base(type, name)
        {
            this.model = model;
            this.sizes = sizes;
            this.Cost = cost;
            this.shelves = shelves;
            this.numberOfDoor = numberOfDoor;
            this.manufacturer = manufacturer;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Ширина x высота: {sizes}");
            Console.WriteLine($"Количество полок: {shelves}");
            Console.WriteLine($"Количество дверей: {numberOfDoor}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }

        public void CostSort()
        {

        }
    }

    

    class Nightstand : Furniture, IFurniture
    {
        private int numberOfBoxes;
        private string sizes;

        public Nightstand(string model, double cost, int numberOfBoxes, string sizes, string manufacturer, string type, string name) : base(type, name)
        {
            this.model = model;
            this.Cost = cost;
            this.numberOfBoxes = numberOfBoxes;
            this.sizes = sizes;
            this.manufacturer = manufacturer;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Ширина x высота: {sizes}");
            Console.WriteLine($"Количество ящиков: {numberOfBoxes}");            
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }

        public void CostSort()
        {

        }
    }

     sealed class Chair : Furniture, IFurniture
    {
        private string typeChair;
        private int heigth;

        public Chair(string model, string typeChair, double cost, int heigth, string manufacturer, string type, string name) : base(type, name)
        {
            this.model = model;
            this.typeChair = typeChair;
            this.Cost = cost;
            this.heigth = heigth;
            this.manufacturer = manufacturer;
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Тип стула: {typeChair}");
            Console.WriteLine($"Высота: {heigth}");
            Console.WriteLine($"Проиводитель: {manufacturer} р");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine("----------------------------------------");
        }

        public void CostSort()
        {

        }
    }
}
