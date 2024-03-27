using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForCursach.command
{
    public class CartPageCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Go to cart page");
            Console.WriteLine("       _________");
            Console.WriteLine("     //         \\");
            Console.WriteLine(" ___//___________\\___");
            Console.WriteLine("|___/|           |\\__|");
            Console.WriteLine("    |_____________|");
            Console.WriteLine("    |             |");
            Console.WriteLine("    |             |");
            Console.WriteLine("    |             |");
            Console.WriteLine("    |             |");
            Console.WriteLine("    |             |");
            Console.WriteLine("    |_____________|");
            Console.WriteLine("    \\_____________/");
        }
    }
}
