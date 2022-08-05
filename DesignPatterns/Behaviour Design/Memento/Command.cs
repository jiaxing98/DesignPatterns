using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // A command object can act as a caretaker. In that case, the
    // command gets a memento just before it changes the
    // originator's state. When undo is requested, it restores the
    // originator's state from a memento.
    public class Command
    {
        private Snapshot _backup;
        private Editor _editor;

        public Command(Editor editor)
        {
            _editor = editor;
        }

        public void MakeBackup()
        {
            _backup = _editor.CreateSnapshot();
        }

        public void Undo()
        {
            if (_backup != null)
                _backup.Restore();
        }
    }
}
