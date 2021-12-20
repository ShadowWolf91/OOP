using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4L
{
    public class Password
    {
        private string login;
        private string email;
        public string password;
        private string checkpassword;

        public void Print()
        {
            Console.WriteLine("Логин: " + login + "; Пароль: " + password + "; ПовПар: " + checkpassword);
        }

        public int Value { get; set; }

        public Password(string login, string email, string password, string checkpassword)
        {
            this.login = login;
            this.email = email;
            this.password = password;
            this.checkpassword = checkpassword;
        }
        public Password(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        //reloads

        public static string operator -(Password password1)
        {
            return password1.password.Remove(password1.password.Length - 1) + "w";
        }

        public static bool operator >(Password password1, Password password2)
        {
            return password1.password.Length > password2.password.Length;
        }
        public static bool operator <(Password password1, Password password2)
        {
            return password1.password.Length < password2.password.Length;
        }

        public static bool operator ==(Password password1, Password password2)
        {
            return password1.Equals(password2);
        }
        public static bool operator !=(Password password1, Password password2)
        {
            return !password1.Equals(password2);
        }

        public static string operator +(Password password1)
        {
            return password1.password.Remove(0, password1.password.Length) + "adfasds";
        }

        public static bool operator true(Password password1)
        {
            if (password1.password.Length > 6)
            {
                return true;
            }
            else return false;
        }
        public static bool operator false(Password password1)
        {
            if (password1.password.Length < 6)
            {
                return false;
            }
            else return true;
        }

        public class Date // класс Date
        {
            private int day;
            private int month;
            private int year;
            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            public void getDate()
            {
                Console.WriteLine("Год:{0}\nМесяц:{1}\nДень:{2}\n", year, month, day);
            }
        }

    }

    public class Owner
    {
        int id;
        string name;
        string org;

        public Owner(int id, string name, string org)
        {
            this.id = id;
            this.name = name;
            this.org = org;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Org
        {
            get { return org; }
            set { org = value; }
        }

        public void getInfo()
        {
            Console.WriteLine("ID:{0}\nИмя:{1}\nОрганизация:{2}", Id, Name, Org);
        }
    }

    public static class StatisticOperation
    {
        public static int Summa(Password password1)
        {
            int sum = 0;
            for (int i = 0; i < password1.password.Length; i++)
            {
                sum += password1.password.Length;
            }
            return sum;
        }

        public static int MinMaxMinus(Password password1)
        {
            int maxnum = -99999;
            for (int i = 0; i < password1.password.Length; i++)
            {
                if (password1.password[i] > maxnum)
                {
                    maxnum = password1.password[i];
                };
            }
            int minnum = 99999;
            for (int i = 0; i < password1.password.Length; i++)
            {
                if (password1.password.Length < minnum)
                {
                    minnum = password1.password.Length;
                };
            }
            int res;
            res = maxnum - minnum;
            return res;
        }

        public static int Middle(Password password1)
        {
            int a = 1;
            for (int i = 0; i < password1.password.Length / 2; i++)
            {
                a++;
            }
            return a;
        }

        public static int CheckLength(Password password1)
        {
            int c = 0;
            if (password1.password.Length > 6 && password1.password.Length < 12)
            {
                c = 0;
                return c;
            }
            else
            {
                c = 1;
                return c;
            }
        }



        class Program
        {
            static void Main(string[] args)
            {
                Password password1 = new Password("ShadowWolf", "petrasmail@gmail.com", "1661dss9", "1661dss9");
                Password password2 = new Password("Shadow", "1691d");
                password1.Print();
                password2.Print();
                Console.WriteLine(-password1);
                Console.WriteLine(password1 != password2);
                Console.WriteLine(password1 > password2);
                Console.WriteLine(+password1);
                
                Owner owner = new Owner(1780401, "Eugen", "BSTU");
                owner.getInfo();
                Password.Date date = new Password.Date(15, 10, 2021);
                date.getDate();
                int sum, res, a, c;
                sum = StatisticOperation.Summa(password1);
                Console.WriteLine("Сумма элементов массива = {0}", sum);
                res = StatisticOperation.MinMaxMinus(password1);
                Console.WriteLine("Разность = {0}", res);
                a = StatisticOperation.Middle(password1);
                Console.WriteLine("Центр = {0}", a);
                c = StatisticOperation.CheckLength(password1);
                if (c == 0) 
                {
                    Console.WriteLine("Проверка: Correct");
                }
                if (c == 1)
                {
                    Console.WriteLine("Проверка: Discorrect");
                }
                Console.ReadKey();
            }
        }
    }
}
