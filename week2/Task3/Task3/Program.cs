using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
     /*   static void Ex1()
        {
            FileInfo fileInfo = new FileInfo("C:/Users/User/Desktop/PP 2");
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Directory);
        }

        static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo("C:/Users/User/Desktop/");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Parent);
        }

        static void Ex3()
        {
            DirectoryInfo directory = new DirectoryInfo("/Users/User/Desktop/PP 2/week2");
            FileInfo[] files = directory.GetFiles();

            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.WriteLine();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach(DirectoryInfo dInfo in directories)
            {
                Console.WriteLine(dInfo.Name);
            }
        }
        */
        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("    ");
        }
        
        static void Ex4(DirectoryInfo directory, int level)
        {
            DirectoryInfo[] directories = directory.GetDirectories();
            
            foreach(DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Ex4(d, level + 1);
            }
            

            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }
        }
        
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("C:/Users/User/Desktop/PP 2/week2");
            Ex4(d, 0);
            Console.ReadKey();
        }
    }
}