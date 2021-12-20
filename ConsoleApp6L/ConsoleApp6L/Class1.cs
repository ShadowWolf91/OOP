using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6L
{
    partial class Class1
    {

        public static List<Furniture> AllFurnitures = new List<Furniture>();
        public static List<Furniture> allFurnitures { get; set; }

        public static void Add(Furniture furniture)
        {
            AllFurnitures.Add(furniture);
            
        }

        public static void ShowList()
        {
            Console.WriteLine("Полный список Мебели: ");
            foreach (Furniture furniture in AllFurnitures)
            {
                Console.WriteLine($"Мебель: {furniture.Productname}   |   Масса: {furniture.Mass}   |   Цена: {furniture.Price}");
            }
        }

        

        public static List<Wardrobe> AllWardrobes = new List<Wardrobe>();
        public static List<Wardrobe> allwardrobes { get; set; }

        public static void Add2(Wardrobe wardrobe)
        {
            AllWardrobes.Add(wardrobe);
            
        }

        public static void ShowList2()
        {
            Console.WriteLine("Полный список шкафов: ");
            foreach (Wardrobe wardrobe in AllWardrobes)
            {
                Console.WriteLine($"Товар: {wardrobe.Productname}   |   Масса: {wardrobe.Mass}   |   Цена: {wardrobe.Price}");
            }
        }
    }
    partial class Controller : IComparer<Furniture>
    {

        public int Compare(Furniture p1, Furniture p2)
        {
            if (p1.Productname.Length > p2.Productname.Length)
                return 1;
            else if (p1.Productname.Length < p2.Productname.Length)
                return -1;
            else
                return 0;
        }
        public static List<Furniture> SortByMass(List<Furniture> furnitues)
        {
            Furniture temp;
            for (int i = 0; i < furnitues.Count; i++)
            {
                for (int j = i + 1; j < furnitues.Count; j++)
                {
                    if (furnitues[i].Mass > furnitues[j].Mass)
                    {
                        temp = furnitues[i];
                        furnitues[i] = furnitues[j];
                        furnitues[j] = temp;
                    }
                }
                Console.WriteLine(furnitues[i].Productname + " - " + furnitues[i].Mass);
            }

            return furnitues;
        }

        public static List<Furniture> SortByPrice(List<Furniture> furnitues)
        {
            Furniture temp;
            for (int i = 0; i < furnitues.Count; i++)
            {
                for (int j = i + 1; j < furnitues.Count; j++)
                {
                    if (furnitues[i].Price > furnitues[j].Price)
                    {
                        temp = furnitues[i];
                        furnitues[i] = furnitues[j];
                        furnitues[j] = temp;
                    }
                    
                }
                Console.WriteLine(furnitues[i].Productname + " - " + furnitues[i].Price);
            }

            return furnitues;
        }
    }
}
