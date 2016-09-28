using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); //prompts user for name
            string a = Console.ReadLine();
            string b = "Hello " + a + "!";
            Console.WriteLine(b);
            Console.WriteLine("How are you doing today?");
            string c = Console.ReadLine();
            Console.WriteLine("That's " + c + "!");
            Console.WriteLine("I'm glad you're " + c + ". ");
            Console.WriteLine("I'm " + c + " too!");
            Console.WriteLine("Goodbye. Press any key to get back to your "+c+" life, "+a);
            Console.ReadKey();
        }
    }
}
