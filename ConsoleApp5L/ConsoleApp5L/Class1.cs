using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5L
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
        protected int width;
        protected int height;
        protected int thickness;
        protected string material;

        public string Productname 
        {
            get { return productname; }
            set {productname = value;}
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public int Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("Товар: " + Productname);
            Console.WriteLine("Ширина: " + Width);
            Console.WriteLine("Высота: " + Height);
            Console.WriteLine("Толщина: " + Thickness);
            Console.WriteLine("Материал: " + Material);
            return base.ToString();
        }

        public abstract void Show();
        public abstract void Size();
        public abstract void Place();
        public abstract void There();
    }
    public class Furniture : Product, Ihere
    {
        public Furniture(string productname, int width, int height, string material, int thickness) 
        {
            this.productname = productname;
            this.width = width;
            this.height = height;
            this.material = material;
            this.thickness = thickness;
        }
        public override void Show() 
        {
            Console.WriteLine("Мебель");
        }
        public override void Size() 
        {
            Console.WriteLine("Размер");
            width = 56;
            height = 125;
            thickness = 22;
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
        public Sofa(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Bed(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Wardrobe(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Closet(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Hanger(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Curbstone(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
        public Chair(string name, int thickness, int height, string material, int width, bool BoughtOrNot) : base(name, thickness, height, material, width)
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
}