using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandForCursach.command
{
    public class Invoker
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
