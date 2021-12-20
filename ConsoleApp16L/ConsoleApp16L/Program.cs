using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace ConsoleApp16L
{
    class Program
    {
        static BlockingCollection<int> ts = new BlockingCollection<int>();
        static int fact(int n)
        {
            int i = n;
            int count = 1;
            while (i > 0)
            {
                count = count * i;
                i--;
            }
            return count;
        }

        static void post(int n)
        {
            for (int i = n; i < n + 100; i++)
            {
                ts.Add(i);
                Console.WriteLine("Товар " + i + " добавлен");
                Thread.Sleep(1000);
            }

        }
        static void pok()
        {
            ts.TryTake(out int take);
            Console.WriteLine("Товар " + take + " куплен");
            Thread.Sleep(1000);

        }
        static void SieveEratosthenes(uint n, CancellationToken token)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {

                    numbers.Remove(numbers[i] * j);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));

        }
        static void Display(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
            Console.WriteLine($"Id предыдущей задачи: {t.Id}");
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Простые числа до заданного {0}:", n);
            Task Eratosfen = new Task(() => SieveEratosthenes(n, token));
            Console.WriteLine(Eratosfen.Id + "   " + Eratosfen.IsCompleted + "  " + Eratosfen.Status);
            Eratosfen.Start();
            Stopwatch stopwatch = new Stopwatch();
            while (!Eratosfen.IsCompleted)
            {
                stopwatch.Start();
                if (stopwatch.Elapsed.Seconds == 5)
                {
                    cancelTokenSource.Cancel();
                    break;
                }
                Console.WriteLine(stopwatch.Elapsed);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k");
            int k = Convert.ToInt32(Console.ReadLine());
            Task<int> kfact = new Task<int>(() => fact(k));
            Task<int> mfact = new Task<int>(() => fact(m));
            Task<int> kmfact = new Task<int>(() => fact(k - m));
            kfact.Start(); mfact.Start(); kmfact.Start();
            int C = kfact.Result / (mfact.Result * kmfact.Result);
            Console.WriteLine(C);

            Task task1 = new Task(() =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });

            // задача продолжения
            Task task2 = task1.ContinueWith(Display);

            task1.Start();

            // ждем окончания второй задачи
            task2.Wait();
            task1 = Task.Run(() => Console.WriteLine("Allo"));
            task1.GetAwaiter().OnCompleted(() => Console.WriteLine("Allo2"));
            task1.GetAwaiter().OnCompleted(() => Console.WriteLine("Allo3"));
            task1.Wait();
            Console.WriteLine("Выполняется работа метода Main");

            Parallel.For(1, 100, (i) => { Console.WriteLine(i); });

            Parallel.Invoke(new Action[]
            {
                () => SieveEratosthenes(1000,token),
                () => SieveEratosthenes(200,token)
            });


            Task.Run(() => post(1));
            Task.Run(() => post(100));
            Task.Run(() => post(200));
            Task.Run(() => post(300));
            Task.Run(() => post(400));
            Thread.Sleep(100);

            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());
            Task.Run(() => pok());

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
