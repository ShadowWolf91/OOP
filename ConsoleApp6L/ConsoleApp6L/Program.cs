using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6L
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
            set { mass = value; }
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
            get{ return creator; }
            set{ creator = value; }
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
            Sofa sofa = new Sofa("Диван", 50, 120, "Дерево и ткань", "Пинскдрев", true);
            Bed bed = new Bed("Кровать", 40, 150, "Дерево и ткань", "Fandok", true);
            Wardrobe wardrobe0 = new Wardrobe("Шкаф", 55, 200, "Дерево", "Бобруйск мебель", false);
            Wardrobe wardrobe1 = new Wardrobe("Шкаф", 45, 170, "Дерево", "Ami", false);
            Wardrobe wardrobe2 = new Wardrobe("Шкаф", 38, 146, "Дерево", "Fandok", false);
            Closet closet = new Closet("Шкаф-купе", 35, 170, "Дерево", "Ami", true);
            Hanger hanger = new Hanger("Вешалка", 1, 2, "Аллюминий", "Молодечно мебель", true);
            Curbstone curbstone = new Curbstone("Тумба", 25, 50, "Дерево", "Пинскдрев", false);
            Chair chair = new Chair("Стул", 2, 45, "Дерево", "Бобруйск мебель", false);

            Class1.Add(sofa);
            Class1.Add(bed);
            Class1.Add(wardrobe0);
            Class1.Add(wardrobe1);
            Class1.Add(wardrobe2);
            Class1.Add(closet);
            Class1.Add(hanger);
            Class1.Add(curbstone);
            Class1.Add(chair);

            Class1.Add2(wardrobe0);
            Class1.Add2(wardrobe1);
            Class1.Add2(wardrobe2);

            Class1.ShowList();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Производители: " + Controller.FindCreator(Class1.AllFurnitures));
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Общая цена шкафов: " + Controller.FindWardrobePrice(Class1.AllWardrobes));
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Сортировка по массе: ");
            Controller.SortByMass(Class1.AllFurnitures);
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Сортировка по цене: ");
            Controller.SortByPrice(Class1.AllFurnitures);

            Console.ReadKey();
        }
    }
}