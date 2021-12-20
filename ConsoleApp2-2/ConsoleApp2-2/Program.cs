using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool e = true;            //1
            byte q = 1;
            sbyte qq = -45;
            char r = 'r';
            decimal t = 2.45m;
            double yy = 343546;
            float yu = 12f;
            int w = -35;
            uint ww = 57;
            long i = -26345;
            ulong ii = 57;
            short o = -734;
            ushort oo = 50763;
            string u = "ah;oibhso";
            object p = 2u;
            dynamic a = 34;

            i = ww;
            w = o;
            t = o;
            p = qq;
            yy = o;
            w = (int)ww;
            i = (long)ii;
            yu = (float)yy;
            q = (byte)qq;
            o = (short)oo;
            bool bloo = Convert.ToBoolean(2);

            int cc = 1;
            object ob = cc;
            cc = (int)ob;

            var v = 4;
            cc = v;

            Nullable<uint> jk = null;
            Console.WriteLine(jk);

            //var uui = 76;
            //uui = "dtyjty";

            char q1 = '4', q2 = '5';                      //2
            if (q1 == q2) Console.WriteLine("Равны");

            string k1 = "gggggggg", k2 = "ssssssssss", k3 = "fffffff";
            Console.WriteLine(k1 + k2);
            k1 = k1.Substring(4);
            k3 = k3.Insert(2, k1);
            Console.WriteLine(k1);
            string k4 = "eeeeeeeeeee";
            string[] wo = k4.Split(' ');
            Console.WriteLine("k3: " + k3);

            string emp = "", nu = null;
            Console.WriteLine(string.IsNullOrEmpty(emp));
            Console.WriteLine(string.IsNullOrEmpty(nu));

            StringBuilder rtr = new StringBuilder("Hello Everyone!");
            rtr.Remove(1, 3);
            Console.WriteLine(rtr);
            rtr.Insert(6, "_-_");
            Console.WriteLine(rtr);

            int[,] array1 = new int[,] { { 1, 5 }, { 3, 45 }, { 2, 53 } };                                       //3
            int rr = array1.GetUpperBound(0) + 1;
            int c = array1.Length / rr;
            for (int iii = 0; iii < rr; iii++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(array1[iii, j] + "  ");
                }
                Console.WriteLine();
            }

            string[] array2 = { "a", "b", "c" };
            for (int iiii = 0; iiii < array2.Length; iiii++)
                Console.WriteLine("Letter[{0}] = {1}", iiii, array2[iiii]);
            Console.WriteLine("Length = " + array2.Length);

            Console.WriteLine("Введите 2, 3, 4: ");
            int k = int.Parse(Console.ReadLine());
            int rt = int.Parse(Console.ReadLine());
            int kt = int.Parse(Console.ReadLine());
            int[] aa0 = new int[k];
            Console.WriteLine("Массив: ");
            for (int z = 0; z < k; z++)
            {
                    aa0[z] = int.Parse(Console.ReadLine());
            }
            int[] aa1 = new int[rt];
            Console.WriteLine("Массив: ");
            for (int zz = 0; zz < rt; zz++)
            {
                aa1[zz] = int.Parse(Console.ReadLine());
            }
            int[] aa2 = new int[kt];
            Console.WriteLine("Массив: ");
            for (int zzz = 0; zzz < kt; zzz++)
            {
                aa2[zzz] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Решение : ");
            for (int z = 0; z < k; z++)
            {
                    Console.Write(aa0[z] + "\t");
            }
            Console.WriteLine();
            for (int zz = 0; zz < rt; zz++)
            {
                Console.Write(aa1[zz] + "\t");
            }
            Console.WriteLine();
            for (int zzz = 0; zzz < kt; zzz++)
            {
                Console.Write(aa2[zzz] + "\t");
            }
            Console.WriteLine();

            var not = new[] { 1, 2, 3, 4, 5 };

            (int, string, char, string, ulong) korteg = (-1, "aesfd", 'd', "afsdg", 5 );                                     //4

            Console.WriteLine("элемент 1: {0}", korteg.Item1); 
            Console.WriteLine("элемент 3: {0}", korteg.Item3);
            Console.WriteLine("элемент 4: {0}", korteg.Item4);

            int wa1 = 1;
            string wa2 = "fds";
            char wa3 = 'r';
            string wa4 = "regtrgw";
            ulong wa5 = 4;
            (wa1,wa2,wa3,wa4,wa5) = korteg;

            (int, string, char, string, ulong) korteg1 = (-1, "gfstar", 'r', "sgdr", 245); 
            if (korteg == korteg1) Console.WriteLine("Кортежи равны!"); else Console.WriteLine("Кортежи не равны!");

            (int, int, int, char) lf(int[] mas, string str)             //5
            {
                int max = mas.Max();
                int min = mas.Min();
                int sum = mas.Sum();
                char s1 = str.First();
                return (max, min, sum, s1);
            }
            int[] mas1 = {123,54,345,243,334};
            string str1 = "LKbdjfg";
            Console.WriteLine(lf(mas1,str1));

            int func_checked() // 6
            {
                checked
                {
                    int qw = int.MaxValue;
                    try
                    {
                        return qw + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("переполнение");
                        return qw;
                    }
                }
            }
            int func_unchecked()
            {
                unchecked
                {
                    int qw = int.MaxValue;
                    try
                    {
                        return qw + 1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("переполнение");
                        return qw;
                    }
                }
            }
            Console.WriteLine(func_checked());
            Console.WriteLine(func_unchecked());

            Console.ReadKey();
        }
    }
}
