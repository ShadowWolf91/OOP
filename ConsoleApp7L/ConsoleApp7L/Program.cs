using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp7L
{
    interface Iact
    {
        void Show();
        void Input();
        void Size();
        void Place();
    }
    interface Ihere
    {
        void There();
    }
    public abstract class Product : Ihere
    {
        protected string productname;
        protected int mass;
        protected int price;
        protected string material;
        protected string creator;

        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Mass
        {
            get { return mass; }
            set {if (mass >= 0) 
                {
                    throw new Exception("Масса не может быть отрицательной!");
                }
                else
                    mass = value; }
            
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("Товар: " + Productname);
            Console.WriteLine("Масса: " + Mass);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Материал: " + Material);
            Console.WriteLine("Производитель: " + Creator);
            return base.ToString();
        }

        public abstract void Show();
        public abstract void Size();
        public abstract void Place();
        public abstract void There();
    }
    public class Furniture : Product, Ihere
    {
        public Furniture(string productname, int mass, int price, string material, string creator)
        {
            this.productname = productname;
            this.mass = mass;
            this.price = price;
            this.material = material;
            this.creator = creator;
        }
        public override void Show()
        {
            Console.WriteLine("Мебель");
        }
        public override void Size()
        {
            Console.WriteLine("Размер");
        }
        public override void Place()
        {
            Console.WriteLine("Месторасположение");
        }
        public override void There()
        {
            Console.WriteLine("Здесь");
        }
        void Ihere.There()
        {
            Console.WriteLine("И я снова здесь");
        }
    }
    public class Sofa : Furniture
    {
        public bool BoughtOrNot;
        public Sofa(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class Bed : Furniture
    {
        public bool BoughtOrNot;
        public Bed(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class Wardrobe : Furniture
    {
        public bool BoughtOrNot;
        public Wardrobe(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class Closet : Furniture
    {
        public bool BoughtOrNot;
        public Closet(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    sealed public class Hanger : Furniture
    {
        public bool BoughtOrNot;
        public Hanger(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class Curbstone : Furniture
    {
        public bool BoughtOrNot;
        public Curbstone(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class Chair : Furniture
    {
        public bool BoughtOrNot;
        public Chair(string name, int mass, int price, string material, string creator, bool BoughtOrNot) : base(name, mass, price, material, creator)
        {
            this.BoughtOrNot = BoughtOrNot;
        }
        public bool ToCheck()
        {
            if (BoughtOrNot)
                return true;
            else
                return false;
        }
    }
    public class forObject : Object // переопределение методов Object
    {
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            return true;
        }

        public string Name { get; set; }
        int sNumber;

        public override int GetHashCode()
        {
            int hash = 269;
            hash = string.IsNullOrEmpty(Name) ? 0 : Name.GetHashCode();
            hash = (hash * 47) + sNumber.GetHashCode();
            return hash;
        }
    }
    public class Printer
    {
        public void IAmPrinting(Product product)
        {
            Console.WriteLine(product.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            try
            {
                try { Sofa sofa = new Sofa("1", 50, 120, "Дерево и ткань", "Пинскдрев", true); }
                catch (WrongProductname exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Bed bed = new Bed("Кровать", -40, 150, "Дерево и ткань", "Fandok", true);}
                catch (WrongMass exe){ Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Wardrobe wardrobe = new Wardrobe("Шкаф", 55, -200, "Дерево", "Бобруйск мебель", false);
                    //Debug.Assert(wardrobe.Price >= 0);
                }
                catch (WrongPrice exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Closet closet = new Closet("Шкаф-купе", 35, 170, "", "Ami", true); }
                catch (WrongMaterial exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Hanger hanger = new Hanger("Вешалка", 1, 2, "Аллюминий", "Молодечно мебель", true); }
                catch (WrongCreator exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Curbstone curbstone = new Curbstone("Тумба", 25, 50, "Дерево", "Пинскдрев", false); }
                catch (WrongPrice exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                try { Chair chair = new Chair("Стул", 2, 45, "Дерево", "Бобруйск мебель", false); }
                catch (WrongMaterial exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine("Everithing is right"); }

                Chair chair1 = new Chair("Стул", 3, 35, "Пластмасса", "Бобруйск мебель", true);

                try
                {
                    object obj = chair1.Productname;
                    int name = (int)obj;
                    int p = chair1.Mass / 0;
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine(ex.Message + "; " + ex.Source + "; " + ex.StackTrace);
                }
                catch (DivideByZeroException exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }
                finally { Console.WriteLine(""); }



                Sofa sofa1 = new Sofa("Диван", 50, 120, "Дерево и ткань", "Пинскдрев", true);



                Furniture[] furnitures = new Furniture[] { chair1, sofa1 };

                try
                {
                    Console.WriteLine(furnitures[5].Price);
                }
                catch (IndexOutOfRangeException exe)
                {
                    Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace);
                }
                finally { Console.WriteLine(""); }

                Hanger hanger1 = new Hanger("Вешалка", 1, 3, "Пластмасса", "Ami", false);
                try { int p = hanger1.Mass / 0; }
                catch (WrongMass exe) { Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace); }

            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message + "; " + exe.Source + "; " + exe.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
