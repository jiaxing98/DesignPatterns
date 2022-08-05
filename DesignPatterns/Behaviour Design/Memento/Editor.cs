using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // The originator holds some important data that may change over
    // time. It also defines a method for saving its state inside a
    // memento and another method for restoring the state from it.
    public class Editor
    {
        private string _text;
        private int _curX, _curY, _selectionWidth;

        public void SetText(string text)
        {
            _text = text;
        }

        public void SetCursor(int x, int y)
        {
            _curX = x;
            _curY = y;
        }

        public void SetSelectionWidth(int width)
        {
            _selectionWidth = width;
        }

        // Saves the current state inside a memento.
        public Snapshot CreateSnapshot()
        {
            // Memento is an immutable object; that's why the
            // originator passes its state to the memento's
            // constructor parameters.
            return new Snapshot(this, _text, _curX, _curY, _selectionWidth);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Text: {_text}, CurX: {_curX}, CurY: {_curY}, SelectionWidth: {_selectionWidth}");
        }
    }
}
