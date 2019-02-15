using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class FarManager // create class
    {   //create necessary variables
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0; // start of cursor
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path); // directories in my path
            sz = directory.GetFileSystemInfos().Length; //size of directory
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index) // colors
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;  //cursor will be red
                Console.ForegroundColor = ConsoleColor.Gray; // letters are gray
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo)) //if there are directories
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray; // directories will have gray color
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow; // other files will have yellow color
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            int k = 0; // counter
            for (int i = 0; i < fs.Length; i++)
            {
                Color(fs[i], k);
                Console.WriteLine((i+1) + ". " + fs[i].Name);
                k++;
            }
        }
        //cursors move
        public void Up() 
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1; // show last 
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0; //show first
        }
        
        public void Start() 
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey(); // create key
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow) 
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/User/Desktop/PP 2"; // my path
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}