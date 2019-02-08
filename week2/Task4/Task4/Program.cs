using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\User\Desktop\PP 2\week2\path");
            FileStream file = new FileStream(@"C:\Users\User\Desktop\PP 2\week2\path\text01.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            string line = "The elder scrolls V: Skyrim";
            writer.WriteLine(line);
            writer.Close();
            file.Close();

            FileInfo f = new FileInfo(@"C:\Users\User\Desktop\PP 2\week2\path\text01.txt");
            Directory.CreateDirectory(@"C:\Users\User\Desktop\PP 2\week2\path1");
            File.Copy(@"C:\Users\User\Desktop\PP 2\week2\path\text01.txt", @"C:\Users\User\Desktop\PP 2\week2\path1\copy.txt", true);
            File.Delete(@"C:\Users\User\Desktop\PP 2\week2\path\text01.txt");
            Directory.Delete(@"C:\Users\User\Desktop\PP 2\week2\path");
        }
    }
}
