using System;

namespace OOP_6
{
    partial class Slideng: Furniture, IFurniture
    {
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
}
