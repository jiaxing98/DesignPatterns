using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // The base publisher class includes subscription management
    // code and notification methods.
    public class EventManager
    {
        private Dictionary<string, IEventListener> _listeners = new Dictionary<string, IEventListener>();

        public void Subscribe(string eventKey, IEventListener listener)
        {
            _listeners.TryAdd(eventKey, listener);
        }

        public void Unsubscribe(string eventKey, IEventListener listener)
        {
            _listeners.Remove(eventKey);
        }

        public void Notify(string eventKey, string filename)
        {
            foreach(var item in _listeners)
            {
                if(item.Key == eventKey)
                item.Value.Update(filename);
            }
        }
    }
}
