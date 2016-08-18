using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("say something");
            string s = Console.ReadLine();
            if (s == "something")
            {
                Console.WriteLine("k");
            }
            else
            {
                Console.WriteLine("you didnt say \"something\" D-");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllLines(path + "\\todo.txt", new string[] { "troll someone on 4chan", "make a dank maymay", "do another dumb thing" });
            }
            Console.ReadKey();
            Console.WriteLine("- shush child no talking");
            Console.ReadKey();
            Console.WriteLine("- shhh");
            Console.ReadKey();
            Console.WriteLine("- no fuck off");
        }
    }
}