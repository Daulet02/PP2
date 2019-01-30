using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            n = s.Length;
            string[] array = s.Split(); // array with spaces between numbers
            string res = string.Empty;  //create string which will give answer
            for (int i = 0; i < array.Length; i++)  
            {
                if (array[i] == array[i]) // if number equal himself 
                    res += array[i] + " " + array[i] + " "; // throw in string res
            }
            Console.WriteLine(res); // output string res
            Console.ReadKey();
        }
    }
}
