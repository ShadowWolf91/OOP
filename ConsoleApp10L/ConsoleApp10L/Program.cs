using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ConsoleApp10L
{
    class Program
    {

            static void Reaction(object sender, NotifyCollectionChangedEventArgs e)
            {
                Console.WriteLine("Collection changed: " + e.Action);
            }
            static void Main(string[] args)
            {
                Services serv2, serv3, serv4; // класс по варианту
                Services[] servArr =
                    {
                    new Services(91, 560, "18.08.2021", "Доставка"),
                    serv2 = new Services(157, 2450, "27.03.2021", "Ремонт"),
                    serv3 = new Services(578, 259, "09.01.2022", "Электрическое обслуживание"),
                    serv4 = new Services(346, 780, "15.13.2022", "Дизайн интерьера")
                };
                var servList = new ServicesList(servArr);
                servList.Clear();
                servList.AddLast(serv2);
                servList.AddLast(serv3);
                servList.AddLast(serv4);
                servList.Show();

                Console.WriteLine("==================================");

                servList.RemoveFirst();
                servList.AddLast(serv2); // удалить добавить
                servList.Show();

                Console.WriteLine("==================================");

                Queue<int> list1 = new Queue<int>();
                list1.Enqueue(0);
                list1.Enqueue(1);
                list1.Enqueue(2);
                list1.Enqueue(9);
                list1.Enqueue(8);
                list1.Enqueue(68);

                for (byte i = 0; i < 3; i++)
                {
                    list1.Dequeue();
                }
                foreach (var item in list1)
                Console.WriteLine(item + " ");

                Console.WriteLine("==================================");

                list1.Enqueue(7);

                foreach (var item in list1)
                Console.WriteLine(item + " ");

                Console.WriteLine("==================================");


                var list2 = new List<int>(list1);
                foreach (var item in list2)
                Console.WriteLine(item + " ");

                Console.WriteLine("==================================");

                bool Func(int x)
                {
                return x > 0;
                }

                Console.WriteLine(list2.Find(Func));
                Console.WriteLine(list2.FindIndex(Func));
                Console.WriteLine("==================================");

                var obsColl = new ObservableCollection<Services>(); // 3

                obsColl.CollectionChanged += Reaction;
                obsColl.Add(serv4);
                obsColl.Add(serv3);
                obsColl.Remove(serv3);
                Console.ReadKey();
            }
           
    }
}