using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3L
{
    partial class Airline
    {
        private readonly int id;
        private string place;
        private uint number;
        private string type;
        private string time;
        private string day;
        static int counterObj = 0; // статический конструктор
        public const int a = 23;
        

        static void classInfo()
        {
            Console.WriteLine(counterObj);
        }

    public Airline(string place, uint number, string type, string time, string day)
        {
            this.place = place;
            this.number = number;
            this.type = type;
            this.time = time;
            this.day = day;
            counterObj++;
        }



        public Airline()
        {
        }

        //private Airline()
        //{
        //    Console.WriteLine("Закрытый конструктор");
        //}

        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public uint Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во рейсов: ");
            uint count = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            Airline[] database = new Airline[count];
            for (int i = 0; i < count; i++)
            {
                database[i] = new Airline();

                Console.WriteLine("Введите пункт назначения: ");
                database[i].Place = Console.ReadLine();

                Console.WriteLine("Введите номер самолета: ");
                database[i].Number = uint.Parse(Console.ReadLine());

                Console.WriteLine("Введите тип самолета: ");
                database[i].Type = Console.ReadLine();

                Console.WriteLine("Введите время прибытия: ");
                database[i].Time = Console.ReadLine();

                Console.WriteLine("Введите день недели: ");
                database[i].Day = Console.ReadLine();

                Console.WriteLine();
            }
            Console.WriteLine("Введите место прибытия: ");
            string place2 = Console.ReadLine();
            bool wr = false;
            for (int i = 0; i < count; i++)
            {
                if (database[i].Place == place2)
                {
                    Console.WriteLine("Найден рейс: " + database[i].Place + ", " + database[i].Day + ", " + database[i].Number + ", " + database[i].Time + ", " + database[i].Type);
                    wr = true;
                }
                if(wr == false)
                {
                    Console.WriteLine("Нет такого рейиса!");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите предпочитаемый Вами день недели: ");
            string day2 = Console.ReadLine();
            bool wr2 = false;
            for (int i = 0; i < count; i++)
            {
                if (database[i].Day == day2)
                {
                    Console.WriteLine("Найден рейс: " + database[i].Place + ", " + database[i].Day + ", " + database[i].Number + ", " + database[i].Time + ", " + database[i].Type);
                    wr2 = true;
                }
                if (wr2 == false)
                {
                    Console.WriteLine("Нет такого рейиса!");
                }

            }
            Airline flight1 = new Airline("Москва", 19, "Грузовой", "13:15", "Суббота");
            Airline flight2 = new Airline("Берлин", 41, "Грузовой", "23:45", "Понедельник");
            Console.WriteLine(flight1.GetHashCode());
            Console.WriteLine(flight1.GetType());
            Console.WriteLine(flight1.ToString());
            Console.WriteLine(flight1.Equals(flight2));

            var user = new { Name = "Данила", Age = 19 }; // анонимный тип
            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}