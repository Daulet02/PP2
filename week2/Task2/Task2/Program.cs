using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool Prime(int x)
        {
            for (int i = 2; i <= (x/i); i++)
                if ((x % i) == 0) return false;
                if (x <= 1) return false;
            return true;
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 3, 6, 2, 8, 11, 27 };
            FileStream file1 = new FileStream("D:\\input.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i] + " ");
            }
            writer.Close();

            FileStream file2 = new FileStream("D:\\output.txt", FileMode.Create);
            StreamWriter writer2 = new StreamWriter(file2);
            for (int i = 0; i < array.Length; i++)
            {
                if (Prime(array[i]) == true)
                    writer2.Write(array[i] + " ");
            }
            writer2.Close();
            Console.ReadKey();
        }
    }
}
