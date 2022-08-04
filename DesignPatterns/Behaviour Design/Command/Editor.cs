using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //The editor class has actual text editing operations. It plays
    // the role of a receiver: all commands end up delegating
    // execution to the editor's methods.
    public class Editor
    {
        public string text = "I'm editor";

        public string GetSelection()
        {
            return text;
        }

        public void DeleteSelection()
        {
            text = "";
        }

        public void ReplaceSelection(string text)
        {
            this.text = text;
        }
    }
}
