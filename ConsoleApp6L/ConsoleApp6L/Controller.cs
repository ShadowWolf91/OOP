using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6L
{
    partial class Controller
    {
        public static int FindWardrobePrice(List<Wardrobe> wardrobes)
        {
            int st;
            st = wardrobes[0].Price;
            for (int i = 1; i < wardrobes.Count; i++)
            {
                st += wardrobes[i].Price;
            }
            return st;
        }

        public static string FindCreator(List<Furniture> furnitures)
        {
            string total;
            Console.WriteLine("Введите название производителя мебели: ");
            string inp = Console.ReadLine();
            total = furnitures[0].Creator;
            for (int i = 0; i < furnitures.Count; i++)
            {
                if (inp == furnitures[i].Creator)
                {
                    Console.WriteLine(furnitures[i].Productname + " от введенного производителя: " + furnitures[i].Creator);
                }
                else
                {
                    Console.WriteLine("У такого производителя нет " + furnitures[i].Productname);
                }
            }
            return inp;
        }
    }
}
