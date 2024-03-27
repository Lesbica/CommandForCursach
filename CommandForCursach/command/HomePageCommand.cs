using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForCursach.command
{
    public class HomePageCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Go to main page");
            Console.WriteLine("    /\\");
            Console.WriteLine("   /  \\");
            Console.WriteLine("  /    \\");
            Console.WriteLine(" /      \\");
            Console.WriteLine("/________\\");
            Console.WriteLine("|        |");
            Console.WriteLine("|  ____  |");
            Console.WriteLine("| |    | |");
            Console.WriteLine("|_|____|_|");
        }
    }
}
