using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // The concrete publisher contains real business logic that's
    // interesting for some subscribers. We could derive this class
    // from the base publisher, but that isn't always possible in
    // real life because the concrete publisher might already be a
    // subclass. In this case, you can patch the subscription logic
    // in with composition, as we did here.
    public class Editor
    {
        public EventManager eventManager;
        private string _filename = "";

        public Editor()
        {
            eventManager = new EventManager();
        }

        public void OpenFile(string filename)
        {
            _filename = filename;
            eventManager.Notify("Open", _filename);
        }

        public void SaveFile(string filename)
        {
            eventManager.Notify("Save", filename);
        }
    }
}
