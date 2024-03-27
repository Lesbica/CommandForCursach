using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForCursach.command
{
    public class ProfilePageCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Go to profile page");
            Console.WriteLine("  _______");
            Console.WriteLine(" /       \\");
            Console.WriteLine("|  O   O  |");
            Console.WriteLine("|    ^    |");
            Console.WriteLine("|   \\_/   |");
            Console.WriteLine(" \\_______/");
        }
    }
}
