using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Use the Command pattern when you want to parametrize
    //objects with operations.

    //Use the Command pattern when you want to queue operations,
    //schedule their execution, or execute them remotely.

    //Use the Command pattern when you want to implement
    //reversible operations.

    public static class Main_Command
    {
        private static Application app = new Application();

        public static void Init()
        {
            var copy = new CopyCommand(app, app.activeEditor);
            var cut = new CutCommand(app, app.activeEditor);
            var paste = new PasteCommand(app, app.activeEditor);
            var undo = new UndoCommand(app, app.activeEditor);

            Console.WriteLine("Before Any Commmands");
            Console.WriteLine($"Clipboard: {app.clipboard}, Editor: {app.activeEditor.text}");

            Console.WriteLine("Copy");
            app.ExecuteCommand(copy);
            Console.WriteLine($"Clipboard: {app.clipboard}, Editor: {app.activeEditor.text}");

            Console.WriteLine("Cut");
            app.ExecuteCommand(cut);
            Console.WriteLine($"Clipboard: {app.clipboard}, Editor: {app.activeEditor.text}");

            Console.WriteLine("Paste");
            app.ExecuteCommand(paste);
            Console.WriteLine($"Clipboard: {app.clipboard}, Editor: {app.activeEditor.text}");

            Console.WriteLine("Undo");
            app.ExecuteCommand(undo);
            Console.WriteLine($"Clipboard: {app.clipboard}, Editor: {app.activeEditor.text}");

//          //Bind the command to the button
//          copy = function() { executeCommand(new CopyCommand(this, activeEditor)) }
//          copyButton.setCommand(copy) -- Button.setCommand(Command c)***
//          shortcuts.onKeyPress("Ctrl+C", copy)
        }
    }
}
