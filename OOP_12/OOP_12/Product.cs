using System;


namespace OOP_12
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
    }

    interface IFurnitures
    {
        void Print();
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
        public abstract void ToString();
    }

    class Sofa : Furniture, IFurniture, IComparable
    {
        private int places;
        private string sizes;
        static int Count = 0;
        public static Sofa[] sofas = new Sofa[0];

        public int CompareTo(Object obj)
        {
            Sofa sofa = (Sofa)obj;
            if (this.Cost > sofa.Cost)
                return 1;
            if(this.Cost < sofa.Cost)
                return -1;
            return 0;
        }

        public Sofa(string model, int places, string sizes, double cost, string manufacturer, string type, string name) : base(type, name)
        {
            this.model = model;
            this.places = places;
            this.Cost = cost;
            this.sizes = sizes;
            this.manufacturer = manufacturer;
            Array.Resize(ref sofas, sofas.Length+1);
            sofas[Count] = this;            
            Count++;
        }

        
        public static void PrintSortSofas()
        {
            Array.Sort(sofas);
            for (int i = 0; i < sofas.Length; i++)
                sofas[i].Print();
        }

        void IFurniture.Print()
        {
            Console.WriteLine();
            Console.WriteLine("\tИспользуя интерфейс");
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Количество мест: {places}");
            Console.WriteLine($"Длина х Высота х Глубина: {sizes}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("\tИспользуя абстрактный класс");
            Console.WriteLine($"Тип мебели: {type}");
            Console.WriteLine($"Название мебели: {name}");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Количество мест: {places}");
            Console.WriteLine($"Длина х Высота х Глубина: {sizes}");
            Console.WriteLine($"Проиводитель: {manufacturer}");
            Console.WriteLine($"Цена: {Cost} р");
            Console.WriteLine("----------------------------------------");
        }   
        
        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");           

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

        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");

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

        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");
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

        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");

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

        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");

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

        public override void ToString()
        {
            Console.WriteLine("О объекте: ");
            Console.WriteLine($"Модель: {model}");
            Console.WriteLine($"Цена: {Cost}");
            Console.WriteLine($"Тип мебели: {name}\n");

        }
    }
}
