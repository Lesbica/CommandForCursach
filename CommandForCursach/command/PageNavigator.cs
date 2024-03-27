using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForCursach.command
{
    public class PageNavigator
    {
        private Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

        public PageNavigator()
        {
            commands.Add("home", new HomePageCommand());
            commands.Add("cart", new CartPageCommand());
            commands.Add("profile", new ProfilePageCommand());
        }

        public void ExecuteCommand(string page)
        {
            if (commands.ContainsKey(page))
            {
                commands[page].Execute();
            }
            else
            {
                Console.WriteLine("This page does not exist");
            }
        }
    }
}
