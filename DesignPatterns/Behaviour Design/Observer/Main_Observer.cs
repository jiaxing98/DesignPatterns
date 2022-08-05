using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    //Use the Observer pattern when changes to the state of one
    //object may require changing other objects, and the actual set
    //of objects is unknown beforehand or changes dynamically.

    //Use the pattern when some objects in your app must observe
    //others, but only for a limited time or in specific cases.

    public static class Main_Observer
    {
        public static void Init()
        {
            Editor editor = new Editor();
            LoggingListener logger = new LoggingListener("Someone has opened this logger");
            EmailAlertsListener alert = new EmailAlertsListener("dumb@gmail.com", "Why you so dumb?");

            editor.eventManager.Subscribe("Open", logger);
            editor.eventManager.Subscribe("Save", alert);

            editor.OpenFile("dumb.dat");
            editor.SaveFile("dumb.dat");
        }
    }
}
