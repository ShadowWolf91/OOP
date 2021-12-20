using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8L
{
    interface IGenerise<Type>
    {
        void Add(Type item);
        Type Del(int item);
        void Check();
    }

    public class CollectionType<Type> : IGenerise<Type> where Type : class
    {
       public List<Type> passwords = new List<Type>();

       public void Add(Type item)
       {
          passwords.Add(item);
       }

       public Type Del(int item)
       {
          Type value = passwords[item];
          passwords.RemoveAt(item);
          return value;
       }

       public void Check()
       {
          int count = 0;
          foreach (Type item in passwords)
          { 
              count++;
              Console.WriteLine($"Элемент списка под номером {count}\nТип: {item.GetType()}");
              Console.WriteLine();
          }

       }

       public void WriteToFile()
       {
         StreamWriter f = null;
         try
         {
            f = new StreamWriter("C://Users//Lenovo-PC//source//repos//ConsoleApp8L//8.txt", false, Encoding.Default);
            foreach (Type t in passwords)
            {
                f.WriteLine("Hey, yeah, you!");
            }
         }
         finally
         {
             f.Close();
         }
       }

       public void ReadFromFile()
       {
          StreamReader s = null;
          try
          {
             s = new StreamReader("C://Users//Lenovo-PC//source//repos//ConsoleApp8L//8.txt");
             int counter = 0;

             foreach (string str in File.ReadAllLines("C://Users//Lenovo-PC//source//repos//ConsoleApp8L//8.txt"))
             {
                 counter++;
             }

             
             string[] arr = new string[counter];
             for (int i = 0; i < counter; i++)
             {
                 arr[i] = s.ReadLine();
                    Console.WriteLine(arr[i] + "\n");
             }
          }
          finally
          {
             s.Close();
          }
       }
    }

    public class StandartTypes<Type1, Type2, Type3> where Type1 : struct where Type2 : struct where Type3 : struct
    {
        Type1 A { get; set; }
        Type2 B { get; set; }
        Type3 C { get; set; }

        public StandartTypes(Type1 A, Type2 B, Type3 C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public void ShowTypes()
        {
            Console.WriteLine($"Первый тип {A.GetType()} его значение {A}");
            Console.WriteLine($"Второй тип {B.GetType()} его значение {B}");
            Console.WriteLine($"Третий тип {C.GetType()} его значение {C}");
        }
    }

    public class Password
    {
        private string login;
        public string password;

        public void Print()
        {
            Console.WriteLine("Логин: " + login + "; Пароль: " + password + ";");
        }

        public int Value { get; set; }

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
                Password password1 = new Password("ShadowWolf", "1661dss9");
                Password password2 = new Password("Shadow", "1691d");
                password1.Print();
                password2.Print();

                Console.WriteLine("__________________________________________");

                CollectionType<Password> myCollect = new CollectionType<Password>();
                myCollect.Add(password1);
                myCollect.Add(password2);
                myCollect.Check();

                Console.WriteLine("__________________________________________");

                bool exept = false;
                try
                {
                    Password giveMe = myCollect.Del(0);
                    myCollect.Check();
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex.Source);
                    exept = true;
                }
                finally
                {
                    if (exept)
                    {
                        Console.WriteLine("Исключение обработано");
                    }
                    else
                    {
                        Console.WriteLine("Исключение не обработано либо не произошло");
                    }
                }

                Console.WriteLine("__________________________________________");

                bool exept2 = false;
                try
                {
                    StandartTypes<float, int, byte> types = new StandartTypes<float, int, byte>(1111f, 113, 5); // обобщение для проверки типов
                    types.ShowTypes();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex.Source);
                    exept2 = true;
                }
                finally
                {
                    if (exept2)
                    {
                        Console.WriteLine("Исключение обработано");
                    }
                    else
                    {
                        Console.WriteLine("Исключение не обработано либо не произошло");
                    }

                }

                myCollect.WriteToFile();
                myCollect.ReadFromFile();



                Console.ReadKey();
            }
        }
    }
}
