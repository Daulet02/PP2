using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Palindrom(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("D:\\text.txt");
            writer.WriteLine("Skyrim");
            writer.Close();

            StreamReader reader = new StreamReader("D:\\text.txt");
            string s = reader.ReadLine();
            if (Palindrom(s) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
