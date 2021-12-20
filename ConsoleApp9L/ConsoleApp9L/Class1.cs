using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9L
{
    public class Programmer
    {
        public event takeName renamev;
        public event LanguageChange newproperty;


        public void MakeNewChange(int b)
        {
            renamev?.Invoke(this, null, b);

        }

        public void ToActivate(string Changes)
        {
            newproperty?.Invoke(this, null, Changes);
        }
    }

    public class Programlanguage
    {
        private int year;
        private string languagename;
        private int version;
        public int changeCounter = 1;

        BeChange change; // создаем переменную делегата
        public void RegisterChange(BeChange change)
        {
            this.change = change;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Languagename
        {
            get { return languagename; }
            set { languagename = value; }
        }

        public Programlanguage() { }
        public Programlanguage(int year, int version, string languagename)
        {
            Year = year;
            Version = version;
            Languagename = languagename;
        }

        public void ChangeVersion()
        {
            changeCounter++;
            Console.WriteLine("Версия была изменена");
            change?.Invoke($"Количество изменений свойств: {changeCounter}");
        }

        public void ToActivateProgramLanguage(object sender, EventArgs e, string str)  // обработчик события
        {
            Languagename = str;
            Console.WriteLine($"Новый язык программирования: {Languagename}");
        }
        public void ToActivateNewVersion(object senderer, EventArgs ee, int b)  // обработчик события
        {
            Version = b;
            Console.WriteLine($"Новая версия языка программирования: {Version}");
        }
    }
}
