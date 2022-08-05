using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // The memento class stores the past state of the editor.
    public class Snapshot
    {
        private Editor _editor;
        private string _text;
        private int _curX, _curY, _selectionWidth;

        public Snapshot(Editor editor, string text, int curX, int curY, int selectionWidth)
        {
            _editor = editor;
            _text = text;
            _curX = curX;
            _curY = curY;
            _selectionWidth = selectionWidth;
        }

        // At some point, a previous state of the editor can be
        // restored using a memento object.
        public void Restore()
        {
            _editor.SetText(_text);
            _editor.SetCursor(_curX, _curY);
            _editor.SetSelectionWidth(_selectionWidth);
        }
    }
}
