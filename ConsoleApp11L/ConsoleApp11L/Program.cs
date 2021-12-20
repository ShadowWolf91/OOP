using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11L
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("Введите количество символов, равное количесству символов в названии месяца");
            int n = int.Parse(Console.ReadLine());
            IEnumerable<string> Months1 = months.Where(m => m.Length == n);
            foreach (string item in Months1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Только летние и зимние месяцы");
            IEnumerable<string> Months2 = from m in months where m.StartsWith("J") || m.StartsWith("F") || m.StartsWith("Au") || m.StartsWith("D") select m;
            foreach (string item in Months2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Только зимние месяцы");
            IEnumerable<string> Months5 = from m in months where m.StartsWith("Ja") || m.StartsWith("F") || m.StartsWith("D") select m;
            foreach (string item in Months5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Только летние месяцы");
            IEnumerable<string> Months6 = from m in months where m.StartsWith("Ju") || m.StartsWith("Au") select m;
            foreach (string item in Months6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine(" В алфавитном порядке:");
            IEnumerable<string> Months3 = months.OrderBy(s => s);
            foreach (string item in Months3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Месяцы с буквой \"u\" и длиной строки 4 и выше");
            IEnumerable<string> Months4 = months.Where(n1 => n1.Contains("u") && n1.Length >= 4);
            foreach (string item in Months4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------------------------");

            Airline airline1 = new Airline("Минск", "Москва", "БелАвиа", 132, "Пассажирский", "12:12", "14:55", 23, "Суббота", "Без Задержки");
            Airline airline2 = new Airline("Москва", "Париж", "S7", 1557, "Пассажирский", "15:26", "19:05", 14, "Понедельник", "Без Задержки");
            Airline airline3 = new Airline("Лондон", "Санкт-Петербург", "Аэрофлот", 2554, "Пассажирский", "20:07", "23:56", 13, "Суббота", "Задержка на 15 минут");
            Airline airline4 = new Airline("Санкт-Петербург", "Москва", "ПерелетРУ", 7652, "Грузовой", "07:19", "09:14", 4, "Понедельник", "Задержка 10 минут");
            Airline airline5 = new Airline("Лондон", "Париж", "British Airways", 4367, "Пассажирский", "23:36", "01:04", 18, "Суббота", "Без Задержки");
            Airline airline6 = new Airline("Минск", "Гродно", "-", 012, "Военный", "12:47", "13:59", 3, "Среда", "Без Задержки");

            List<Airline> airport = new List<Airline>();
            airport.Add(airline1);
            airport.Add(airline2);
            airport.Add(airline3);
            airport.Add(airline4);
            airport.Add(airline5);
            airport.Add(airline6);

            Console.WriteLine("Введите место прибытия для поиска:");
            string findplacein = Console.ReadLine();
            var air1 = airport.Where(n1 => n1.PlaceIn == findplacein);
            foreach (Airline item in air1)
            {
                Console.WriteLine(item.Type + " " + item.PlaceIn + " " + item.TimeArrival);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Введите день недели для поиска:");
            string finddayinweek = Console.ReadLine();
            var air2 = airport.Where(n2 => n2.DayInWeek == finddayinweek);
            foreach (Airline item in air2)
            {
                Console.WriteLine(item.TimeDeparture + " " + item.PlaceFrom + " " + item.DayInWeek);
            }

            Console.WriteLine("---------------------------------------------------");

            var air3 = airport.Max(n3 => n3.DayInWeek);
            Console.WriteLine("Само много рейсов в: " + air3);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Введите день недели для поиска самого позднего рейса в этом дне недели: ");
            string finddayinweek2 = Console.ReadLine();
            var air41 = airport.Where(n41 => n41.DayInWeek == finddayinweek2);
            foreach (Airline item in air41)
            {}
            var air42 = air41.OrderByDescending(n42 => n42.TimeArrival).Take(1);
            foreach (Airline item in air42)
            {
                Console.WriteLine("Самый поздний рейс в данном дне недели:" + item.PlaceIn + " " + item.AviaCompany + " " + item.TimeArrival);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Cписок рейсов отсортированных по дню:");
            var air5 = airport.OrderBy(n5 => n5.Day);
            foreach (Airline item in air5)
            {
                Console.WriteLine(item.PlaceFrom + " " + item.PlaceIn + " " + item.Day);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Cписок рейсов отсортированных по времени отправления:");
            var air6 = airport.OrderBy(n6 => n6.TimeDeparture);
            foreach (Airline item in air6)
            {
                Console.WriteLine(item.PlaceFrom + " " + item.PlaceIn + " " + item.TimeDeparture);
            }

            Console.WriteLine("---------------------------------------------------");

            int k = 0;
            Console.WriteLine("Введите тип самолета для нахождения кол-ва таких самолетов:");
            string findType = Console.ReadLine();
            var air7 = airport.Where(n7 => n7.Type == findType);
            foreach (Airline item in air7)
            {
                k++;
            }
            Console.WriteLine(k);

            Console.WriteLine("---------------------------------------------------");

            List<City> cities = new List<City>()
            {
                new City { Name = "Rome", Country = "Italy" },
                new City { Name = "Brest", Country = "France" }
            };

            List<Citizen> players = new List<Citizen>()
        {
            new Citizen { Name = "Luis", City = "Brest"},
            new Citizen { Name = "Mark", City = "Brest"},
            new Citizen { Name = "Sergey", City = "Rome"}
        };

            var result = players.Join(cities,
             p => p.City,
             t => t.Name,
             (p, t) => new { Name = p.Name, City = p.City, Country = t.Country });


            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.City} ({item.Country})");

            Console.ReadKey();
        }
    }
}
