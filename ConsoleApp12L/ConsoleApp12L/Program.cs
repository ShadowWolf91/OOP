using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ConsoleApp12L
{
    static class Reflection

    {
        static public Type GetType(string str) 
        {

            return Type.GetType("ConsoleApp12L." + str);
        }

        static public void AllClassContent(string str)
        {
            string writePath = @"C:\Users\Lenovo-PC\source\repos\ConsoleApp12L\new.txt";


            StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default);

            Type m = GetType(str);
            MemberInfo[] members = m.GetMembers();
            foreach (MemberInfo item in members)
            {
                sw.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");
            }
            sw.Close();
        }

        static public void AssemblyName(object obj)
        {
            Type m = obj.GetType();
            Assembly ass = m.Assembly;
            Console.WriteLine("Имя сборки: ");
            Console.WriteLine(ass);
        }

        static public void IsPublicConstructors(object obj)
        {
            Type m = obj.GetType();
            ConstructorInfo[] pubConstructors = m.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Только публичные конструкторы: ");
            foreach (ConstructorInfo item in pubConstructors)
            {
                Console.WriteLine(item.Name);
            }
        }

        static public void PublicMethods(object obj)
        {
            Type m = obj.GetType();
            MethodInfo[] pubMethods = m.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Только публичные методы: ");
            foreach (MethodInfo item in pubMethods)
            {
                Console.WriteLine(item.ReturnType.Name + " " + item.Name);
            }
        }


        static public void FieldsAndProperties(object obj)
        {
            Type m = obj.GetType();
            Console.WriteLine("Поля: ");
            FieldInfo[] fields = m.GetFields();

            foreach (FieldInfo item in fields)
            {
                Console.WriteLine(item.FieldType + " " + item.Name);

            }
            Console.WriteLine("Свойства: ");
            PropertyInfo[] properties = m.GetProperties();
            foreach (PropertyInfo item in properties)
            {
                Console.WriteLine($"{item.PropertyType} {item.Name}");
            }
        }


        static public void Interfaces(object obj)
        {
            Type m = obj.GetType();
            Console.WriteLine("Реализованные интерфейсы: ");
            foreach (Type item in m.GetInterfaces())
            {
                Console.WriteLine(item.Name);
            }
        }

        static public void MethodsWithParams(object obj)
        {
            Console.WriteLine("Введите название типа для параметров: ");
            string findType = Console.ReadLine();

            Type m = obj.GetType();
            MethodInfo[] methods = m.GetMethods();
            foreach (MethodInfo item in methods)
            {
                ParameterInfo[] p = item.GetParameters();

                foreach (ParameterInfo param in p)
                {
                    if (param.ParameterType.Name == findType)
                    {
                        Console.WriteLine("Метод: " + item.ReturnType.Name + " " + item.Name);
                    }
                }

            }
        }

        public static void Invoke(object obj)
        {
            StreamReader reader = null;
            reader = new StreamReader("C://Users//Lenovo-PC//source//repos//ConsoleApp12L//new.txt", Encoding.Default);
            int counter = 0;

            foreach (string str in File.ReadAllLines("C://Users//Lenovo-PC//source//repos//ConsoleApp12L//new.txt"))
            {
                counter++;
            }


            string[] arr = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                arr[i] = reader.ReadLine();
                Console.WriteLine(arr[i] + "\n");
            }
             reader.Close();
        }

        public static void Create<T>(T obj)
        {
            Console.WriteLine();
        }

    }
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


            Reflection.AllClassContent("Bed");
            Reflection.AssemblyName(hanger);
            Reflection.IsPublicConstructors(chair);
            Reflection.PublicMethods(curbstone);
            Reflection.FieldsAndProperties(bed);
            Reflection.Interfaces(closet);
            Reflection.MethodsWithParams(wardrobe);

            Reflection.Invoke(closet);

            Type myType = Type.GetType("ConsoleApp12L.Hanger", false, true);
            Console.WriteLine(myType);

            Console.ReadKey();
        }
    }
}
