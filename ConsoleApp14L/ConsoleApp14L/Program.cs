using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp14L
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofa sofa1 = new Sofa("Диван", 50, 75, "Дерево и ткань", 175, true);
            Bed bed = new Bed("Кровать", 40, 80, "Дерево и ткань", 185, true);
            Wardrobe wardrobe = new Wardrobe("Шкаф", 55, 200, "Дерево", 100, false);
            Closet closet = new Closet("Шкаф-купе", 150, 170, "Дерево", 75, true);
            Hanger hanger = new Hanger("Вешалка", 1, 15, "Аллюминий", 7, true);
            Curbstone curbstone = new Curbstone("Тумба", 30, 50, "Дерево", 50, false);
            Chair chair = new Chair("Стул", 60, 100, "Дерево", 60, false);
            Furniture[] furnitures = new Furniture[] {sofa1, bed, wardrobe, closet, hanger, curbstone, chair };

            Console.WriteLine("----------------------------------------------------------------");
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, sofa1);
                Console.WriteLine("Объект сериализован");
            }


            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture.dat", FileMode.OpenOrCreate))
            {
                Sofa newsofa = (Sofa)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название мебели: {newsofa.Productname}   Ширина: {newsofa.Width}   Материал: {newsofa.Material}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            SoapFormatter formatter2 = new SoapFormatter();
            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture2.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, bed);
                Console.WriteLine("Объект сериализован");
            }


            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture2.dat", FileMode.OpenOrCreate))
            {
                Bed newbed = (Bed)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название мебели: {newbed.Productname}   Ширина: {newbed.Width}   Материал: {newbed.Material}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            DataContractJsonSerializer formatter3 = new DataContractJsonSerializer(typeof(Wardrobe));

            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture3.json", FileMode.OpenOrCreate))
            {
                formatter3.WriteObject(fs, wardrobe);
                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furniture3.json", FileMode.OpenOrCreate))
            {
                Wardrobe newwardrobe = (Wardrobe)formatter3.ReadObject(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название мебели: {newwardrobe.Productname}   Ширина: {newwardrobe.Width}   Материал: {newwardrobe.Material}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            BinaryFormatter formatter5 = new BinaryFormatter();

            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furnitures.dat", FileMode.OpenOrCreate))
            {
                formatter5.Serialize(fs, furnitures);
                Console.WriteLine("Массив объектов сериализован");
            }


            using (FileStream fs = new FileStream("D:\\OOP\\ConsoleApp14L\\furnitures.dat", FileMode.OpenOrCreate))
            {
                Furniture[] newFurnitures = (Furniture[])formatter.Deserialize(fs);

                Console.WriteLine("Массив объектов десериализован");
                foreach (Furniture item in newFurnitures)
                {
                    Console.WriteLine($"Название мебели: {item.Productname}   Ширина: {item.Width}   Материал: {item.Material}");
                }
            }

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Первый xml запрос (выбор имён):");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D:\\OOP\\ConsoleApp14L\\XMLFile1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes1 = xRoot.SelectNodes("furniture");

            foreach (XmlNode n in childnodes1)
                Console.WriteLine(n.SelectSingleNode("@name").Value);

            Console.WriteLine("Второй xml запрос (материал):");
            XmlNodeList childnodes2 = xRoot.SelectNodes("//furniture/material");

            foreach (XmlNode n in childnodes2)
                Console.WriteLine(n.InnerText);

            Console.WriteLine("Третий xml запрос (получаем по конкретной ширине):");
            XmlNode childnode3 = xRoot.SelectSingleNode("furniture[width='150']");
            if (childnode3 != null)
                Console.WriteLine(childnode3.OuterXml);

            Console.WriteLine("----------------------------------------------------------------");

            XDocument document = new XDocument();
            XElement root = new XElement("countries");

            XElement country1 = new XElement("country");
            root.Add(country1);
            XAttribute number1 = new XAttribute("number", "1");
            country1.Add(number1);
            XElement CounryName1 = new XElement("name", "Belarus");
            country1.Add(CounryName1);
            XElement square1 = new XElement("area", "207595 km2");
            country1.Add(square1);
            XElement population1 = new XElement("population", "10M");
            country1.Add(population1);

            XElement country2 = new XElement("country");
            root.Add(country2);
            XAttribute number2 = new XAttribute("number", "2");
            country2.Add(number2);
            XElement CounryName2 = new XElement("name", "Russia");
            country2.Add(CounryName2);
            XElement square2 = new XElement("area", "17100000 km2");
            country2.Add(square2);
            XElement population2 = new XElement("population", "144M");
            country2.Add(population2);
            document.Add(root);

            document.Save("D:\\OOP\\ConsoleApp14L\\Countries.xml");
            Console.WriteLine("Документ создан при помощи LINQ to XML");

            Console.WriteLine("----------------------------------------------------------------");

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("D:\\OOP\\ConsoleApp14L\\Countries.xml");
            XmlElement Root = xdoc.DocumentElement;

            Console.WriteLine("Первый xml запрос (выбор имён):");
            XmlNodeList childnodes4 = Root.SelectNodes("country");
            foreach (XmlNode n in childnodes4)
                Console.WriteLine(n.SelectSingleNode("name").InnerText);

            Console.WriteLine("Второй xml запрос (получаем площадь):");
            XmlNodeList childnodes5 = Root.SelectNodes("//country/area");
            foreach (XmlNode n in childnodes5)
                Console.WriteLine(n.InnerText);

            Console.WriteLine("Третий xml запрос (нужное население):");
            XmlNode childnode6 = Root.SelectSingleNode("country[population='144M']");
            if (childnode6 != null)
                Console.WriteLine(childnode6.OuterXml);

            Console.ReadKey();
        }
    }
}
