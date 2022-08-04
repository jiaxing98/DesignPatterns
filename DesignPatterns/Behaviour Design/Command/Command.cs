using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // The base command class defines the common interface for all
    // concrete commands.
    public abstract class Command
    {
        protected Application app;
        protected Editor editor;
        protected string backup;

        public Command(Application app, Editor editor)
        {
            this.app = app;
            this.editor = editor;
        }

        public void SaveBackup()
        {
            backup = editor.text;
        }

        public void Undo()
        {
            editor.text = backup;
        }

        // The execution method is declared abstract to force all
        // concrete commands to provide their own implementations.
        // The method must return true or false depending on whether
        // the command changes the editor's state.
        public abstract bool Execute();
    }

    public class CopyCommand : Command
    {
        public CopyCommand(Application app, Editor editor) : base(app, editor) { }

        // The copy command isn't saved to the history since it
        // doesn't change the editor's state.
        public override bool Execute()
        {
            app.clipboard = editor.GetSelection();
            return false;
        }
    }

    public class CutCommand : Command
    {
        public CutCommand(Application app, Editor editor) : base(app, editor) { }

        // The cut command does change the editor's state, therefore
        // it must be saved to the history. And it'll be saved as
        // long as the method returns true.
        public override bool Execute()
        {
            SaveBackup();
            app.clipboard = editor.GetSelection();
            editor.DeleteSelection();
            return true;
        }
    }

    public class PasteCommand : Command
    {
        public PasteCommand(Application app, Editor editor) : base(app, editor) { }
 
        public override bool Execute()
        {
            SaveBackup();
            editor.ReplaceSelection(app.clipboard);
            return true;
        }
    }

    public class UndoCommand : Command
    {
        public UndoCommand(Application app, Editor editor) : base(app, editor) { }

        public override bool Execute()
        {
            app.Undo();
            return false;
        }
    }

    public class CommandHistory
    {
        private Stack<Command> histories = new Stack<Command>();

        public void Push(Command c)
        {
            histories.Push(c);
        }

        public Command Pop()
        {
            return histories.Pop();
        }
    }
}
