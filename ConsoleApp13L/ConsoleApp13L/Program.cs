using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp13L
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите имя диска (напимер D, C...):");
                string DriveName = Console.ReadLine();

                SDSLog.SDSDiskInfo.ShowFreeSpace(DriveName);
                SDSLog.SDSDiskInfo.ShowFileSystem(DriveName);
                SDSLog.SDSDiskInfo.AllInfo();

                Console.WriteLine("Введите путь к файлу по которому будем получать информацию:");
                string path1 = Console.ReadLine();         
                SDSLog.SDSFileInfo.ShowFilePath(path1);
                SDSLog.SDSFileInfo.ShowFileSizeExtAndName(path1);
                SDSLog.SDSFileInfo.ShowCreationTime(path1);

                Console.WriteLine("Введите путь к папке по которой будем получать информацию:"); 
                string path2 = Console.ReadLine();
                SDSLog.SDSDirInfo.NumberOfFiles(path2);
                SDSLog.SDSDirInfo.ListOfDirectory(path2);
                SDSLog.SDSDirInfo.ParentDirectory(path2);

                SDSLog.SDSFileManager.Task_a();


                Console.WriteLine("Введите путь к папке, из которой будут скопированы все файлы с расширением docx:"); 
                string path3 = Console.ReadLine();

                SDSLog.SDSFileManager.Task_b(path3);

                SDSLog.SDSFileManager.ForObserver.ObservActiones();

        }
    }
}
