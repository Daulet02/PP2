using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        public static bool IsPrime(int x)  //function
        {
            // formula to find prime numbers
            for (int i = 2; i <= x / i; i++)     
                if ((x % i) == 0) return false;
            if (x <= 1) return false;  //ignore element which less of equal 1
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // intput size of array
            string s = Console.ReadLine();
            n = s.Length;
            string[] array = s.Split();
            int cnt = 0;  // create counter
            for (int j = 0; j <= array.Length; j++)
                if (IsPrime(j))  // if element is prime
                {
                    cnt++;  // increase counter
                    Console.WriteLine(j);
                }
            Console.WriteLine(cnt + "\n");
            Console.ReadKey();
        }
    }
}