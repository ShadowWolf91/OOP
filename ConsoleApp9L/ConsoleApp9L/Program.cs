using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9L
{
    public delegate void BeChange(string str);
    public delegate void takeName(object obj, EventArgs args, int b);
    public delegate void LanguageChange(object obj, EventArgs args, string str);
    public delegate void CurrentVersion(Programlanguage b);
    public delegate void CurrentLanguageName(Programlanguage c);


    class Program
    {
        static void Main(string[] args)
        {

            BeChange Massage = (str) => Console.WriteLine(str);
            CurrentVersion currentversion = (show) => Console.WriteLine($"Текущая версия: {show.Version}");
            CurrentLanguageName currlangname = (show1) => Console.WriteLine($"Текущее название языка программирования: {show1.Languagename}");

            Programmer programmer = new Programmer();
            Programlanguage programl0 = new Programlanguage(1973, 1, "С");
            Programlanguage programl1 = new Programlanguage(2011, 11, "С++");
            Programlanguage programl2 = new Programlanguage(2012, 5, "С#");

            currlangname(programl1);
            currentversion(programl1);
            programl1.ChangeVersion();
            programl1.RegisterChange(Massage);
            programmer.renamev += programl1.ToActivateNewVersion;
            programmer.MakeNewChange(14);
            programmer.renamev -= programl1.ToActivateNewVersion;
            Console.WriteLine("-----------------------------------------");

            currentversion(programl1);
            programl1.ChangeVersion();
            programmer.renamev += programl1.ToActivateNewVersion;
            programmer.MakeNewChange(17);
            programmer.renamev -= programl1.ToActivateNewVersion;
            Console.WriteLine("-----------------------------------------");

            currentversion(programl1);
            programl1.ChangeVersion();
            programmer.renamev += programl1.ToActivateNewVersion;
            programmer.MakeNewChange(20);
            programmer.renamev -= programl1.ToActivateNewVersion;
            Console.WriteLine("-----------------------------------------");

            programmer.newproperty += programl1.ToActivateProgramLanguage;
            programmer.ToActivate("Java");
            programmer.newproperty -= programl1.ToActivateProgramLanguage;
            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("-----------------------------------------");
            currlangname(programl2);
            currentversion(programl2);
            programl2.ChangeVersion();
            programl2.RegisterChange(Massage);
            programmer.renamev += programl2.ToActivateNewVersion;
            programmer.MakeNewChange(7);
            programmer.renamev -= programl2.ToActivateNewVersion;
            Console.WriteLine("-----------------------------------------");

            currentversion(programl2);
            programl2.ChangeVersion();
            programmer.renamev += programl2.ToActivateNewVersion;
            programmer.MakeNewChange(9);
            programmer.renamev -= programl2.ToActivateNewVersion;
            Console.WriteLine("-----------------------------------------");

            programmer.newproperty += programl2.ToActivateProgramLanguage;
            programmer.ToActivate("Python");
            programmer.newproperty -= programl2.ToActivateProgramLanguage;
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("-----------------------------------------");
            currlangname(programl0);
            currentversion(programl0);
            Console.WriteLine("-----------------------------------------");

            /////////////////////////////////////////////////

            string str1 = "Hello there! I'm Danila";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Делаем все буквы строчными");
            Console.WriteLine(ChangeString.MyToLower(str1));
            Console.WriteLine();

            Console.WriteLine("Добавляем в конце букву k");
            Console.WriteLine(ChangeString.AddLetter(str1, 'k'));
            Console.WriteLine();

            Console.WriteLine("Меняем Danila на DAN");
            Console.WriteLine(ChangeString.DanDAN(str1));
            Console.WriteLine();

            Console.WriteLine("Делаем все буквы заглавными");
            Console.WriteLine(ChangeString.MyToUpper(str1));
            Console.WriteLine();

            Console.WriteLine("Добавляем в конце '-' ");
            Console.WriteLine(ChangeString.AddDash(str1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}