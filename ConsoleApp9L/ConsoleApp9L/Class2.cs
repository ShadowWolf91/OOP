using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9L
{
    static public class ChangeString
    {
        public static string MyToLower(string str)
        {
            str = str.ToLower();
            return str;
        }

        public static string AddLetter(string str, char letter)
        {
            str = str + letter;
            return str;
        }

        public static string AddDash(string str)
        {
            str = str + " - ";
            return str;
        }

        public static string MyToUpper(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public static string DanDAN(string str)
        {
            str = str.Replace("Danila", "DAN");
            return str;
        }

    }
}
