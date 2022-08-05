using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    //Use the Memento pattern when you want to produce snapshots
    //of the object’s state to be able to restore a previous state
    //of the object.

    //Use the pattern when direct access to the object’s fields/getters/
    //setters violates its encapsulation.

    public static class Main_Memento
    {
        public static void Init()
        {
            Editor editor = new Editor();
            Command command = new Command(editor);

            editor.SetText("first");
            editor.SetCursor(0, 0);
            editor.SetSelectionWidth(5);
            editor.PrintInfo();
            command.MakeBackup();

            editor.SetText("second");
            editor.SetCursor(1, 1);
            editor.SetSelectionWidth(6);
            editor.PrintInfo();

            Console.WriteLine("Undo");
            command.Undo();
            editor.PrintInfo();
        }
    }
}
