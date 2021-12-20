using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;


namespace ConsoleApp15L
{
    class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            TimerCallback timer = new TimerCallback(Expectation);
            Timer timer2 = new Timer(timer, null, 0, 5000);
            Process[] processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                try
                {
                    Console.WriteLine($"ID: {proc.Id}");
                    Console.WriteLine($"Имя: {proc.ProcessName}");
                    Console.WriteLine($"Приоритет: {proc.PriorityClass}");
                    Console.WriteLine($"Время запуска: {proc.StartTime}");
                    Console.WriteLine($"Отвечает ли: {proc.Responding}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Имя: {proc.ProcessName} {ex.Message}");
                }

                Console.WriteLine("-------------------------------------------------");
            }


            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Имя: {domain.FriendlyName}");
            Console.WriteLine($"ID: {domain.Id}");
            Console.WriteLine($"Путь: {domain.BaseDirectory}");
            Console.WriteLine("Все сборки: ");
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly assem in assemblies)
            {
                Console.WriteLine($"Имя: {assem.GetName().Name}     Версия: {assem.GetName().Version}");
            }

            AppDomain app = AppDomain.CreateDomain("Dan");
            Console.WriteLine($"\nДомен: {app.FriendlyName}");
            app.ExecuteAssembly("D:\\OOP\\ConsoleApp3L\\ConsoleApp3L\\bin\\Debug\\ConsoleApp3L.exe");
            Assembly[] assemblies2 = domain.GetAssemblies();
            foreach (Assembly asm in assemblies2)
            {
                Console.WriteLine($"Имя: {asm.GetName().Name}");
            }
            AppDomain.Unload(app);


            Console.WriteLine("-------------------------------------------------");


            Console.WriteLine("Введите число, до которого будет идти счёт:");
            int number1 = int.Parse(Console.ReadLine());
            Thread thread1 = new Thread(new ParameterizedThreadStart(YourNumbers));
            thread1.Name = "NumberThread";
            thread1.Start(number1);


            int number2 = int.Parse(Console.ReadLine());


            Thread thread2 = new Thread(new ParameterizedThreadStart(EvenAndOdd));
            thread2.Name = "EvenNumberThread";
            thread2.Priority = ThreadPriority.Normal;
            Console.WriteLine($"Поток: {thread2.Name}   Приоритет: {thread2.Priority}");
            thread2.Start(number2);

            Thread thread3 = new Thread(new ParameterizedThreadStart(EvenAndOdd));
            thread3.Name = "OddNumberThread";
            thread3.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine($"Поток: {thread3.Name}   Приоритет: {thread3.Priority}");
            thread3.Start(number2);

            Console.ReadKey();
        }

        public static void Expectation(object NoParametr)
        {
            Console.WriteLine("             Пока-что мы ждемс ответа......              ");
        }

        public static void YourNumbers(object n)
        {
            string writePath = "D:\\OOP\\numbers1.txt";
            Thread t = Thread.CurrentThread;
            for (int i = 1; i <= (int)n; i++)
            {
                Console.WriteLine(i);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i);
                }

                if (i == (int)n)
                {
                    Console.WriteLine($"Имя потока: {t.Name}");
                    Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
                    Console.WriteLine($"Приоритет потока: {t.Priority}");
                    Console.WriteLine($"Статус потока: {t.ThreadState}");
                }

                Thread.Sleep(1000);

            }
        }

        public static void EvenAndOdd(object n)
        {
            string writePath = "D:\\OOP\\numbers2.txt";
            Thread t = Thread.CurrentThread;
            lock (locker)
            {
                for (int i = 1; i <= (int)n; i++)
                {
                    if (t.Name == "EvenNumberThread")
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(i);
                            }
                        }

                        Thread.Sleep(200);
                    }

                    if (t.Name == "OddNumberThread")
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(i);
                            }
                        }
                        Thread.Sleep(200);
                    }

                }

            }
        }
    }
}