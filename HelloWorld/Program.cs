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
                Console.WriteLine("you didnt say \"something\" also what's that todo file on your desktop");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllLines(path + "\\epik todo list.txt", new string[] {
                    "EPIK TODO LIST (amazing) ;)",
                    "",
                    "-troll someone on 4chan",
                    "-make a dank maymay",
                    "-all hail potatos",
                    "-be ugly"});
                Console.WriteLine("interesting content");
            }
            Console.ReadKey();
            Console.WriteLine("- shush child no talking");
            Console.ReadKey();
            Console.WriteLine("- shhh");
            Console.ReadKey();
            Console.WriteLine("- ok bye also if you see this you can claim a cookie ;)");
        }
    }
}