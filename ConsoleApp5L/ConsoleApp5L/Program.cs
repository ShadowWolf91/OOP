using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5L
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofa sofa = new Sofa("Диван", 50, 75, "Дерево и ткань", 175, true);
            Bed bed = new Bed("Кровать", 40, 80, "Дерево и ткань", 185, true);
            Wardrobe wardrobe = new Wardrobe("Шкаф", 55, 200, "Дерево", 100, false);
            Closet closet = new Closet("Шкаф-купе", 50, 170, "Дерево", 75, true);
            Hanger hanger = new Hanger("Вешалка", 1, 15, "Аллюминий", 7, true);
            Curbstone curbstone = new Curbstone("Тумба", 30, 50, "Дерево", 50, false);
            Chair chair = new Chair("Стул", 60, 100, "Дерево", 60, false);

            chair.There();
            ((Ihere)chair).There();

            Console.WriteLine("Диван является диваном: " + (sofa is Sofa));
            Console.WriteLine("Стул является стулом: " + (chair is Chair));
            Console.WriteLine("Шкаф-купе является товаром: " + (closet is Product));
            Console.WriteLine("вешалка является вешалкой: " + (hanger is Hanger));
            Console.WriteLine("Тумба является мебелью: " + (curbstone is Furniture));

            Console.WriteLine("_____________________________________________");

            Console.WriteLine(bed.ToString());
            Console.WriteLine(bed.ToCheck());

            Console.WriteLine("______________________________________________");

            Printer printer = new Printer();
            printer.IAmPrinting(wardrobe);

            Console.WriteLine("-------------------------------------");
            Furniture[] allfurniture = new Furniture[] { sofa, bed, wardrobe, closet, hanger, curbstone, chair };
            for (int i = 0; i < allfurniture.Length; i++)
            {
                printer.IAmPrinting(allfurniture[i]);
                Console.WriteLine("-------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
