using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // The application class sets up object relations. It acts as a
    // sender: when something needs to be done, it creates a command
    // object and executes it.
    public class Application
    {
        public string clipboard;
        public Editor activeEditor = new Editor();
        public List<Editor> editors = new List<Editor>();
        public CommandHistory history = new CommandHistory();

        // Execute a command and check whether it has to be added to
        // the history.
        public void ExecuteCommand(Command command)
        {
            if (command.Execute())
                history.Push(command);
        }

        // Take the most recent command from the history and run its
        // undo method. Note that we don't know the class of that
        // command. But we don't have to, since the command knows
        // how to undo its own action.
        public void Undo()
        {
            var command = history.Pop();
            if(command != null)
                command.Undo();
        }
    }
}
