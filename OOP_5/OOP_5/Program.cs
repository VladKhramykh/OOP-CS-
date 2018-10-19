using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            var bed1 = new Bed("Аврора 7", 2, "200x180", 254.99f, "ООО 'Территория сна'", "Комнатная", "Кровать");
            bed1.Print();
            var sofa1 = new Sofa("Mood Trade", 8, "238x95x110", 899.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            sofa1.Print();
            var sofa2 = new Sofa("Mood Trade", 8, "238x95x110", 399.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            sofa1.Print();
            var sofa3 = new Sofa("Mood Trade", 8, "238x95x110", 199.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            sofa1.Print();
            var sofa4 = new Sofa("Mood Trade", 8, "238x95x110", 1899.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            sofa1.Print();
            var sofa5 = new Sofa("Mood Trade", 8, "238x95x110", 799.99f, "ООО 'Живые диваны'", "Комнатная", "Диван");
            sofa1.Print();
            var wardrobe1 = new Wardrobe("Ревьера", "150x216x58", 1399.99f, 8, "Лагуна", "Комнатная", "Шкаф");
            wardrobe1.Print();
            //Sofa.CostSort();
        }
    }
}
