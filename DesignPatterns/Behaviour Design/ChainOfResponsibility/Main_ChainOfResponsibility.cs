using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{

    //Use the Chain of Responsibility pattern when your program
    //is expected to process different kinds of requests in various
    //ways, but the exact types of requests and their sequences are
    //unknown beforehand.

    //Use the pattern when it’s essential to execute several handlers
    //in a particular order.

    //Use the CoR pattern when the set of handlers and their order
    //are supposed to change at runtime.

    public static class Main_ChainOfResponsibility
    {
        public static void Init()
        {
            var dialog = new Dialog();
            dialog.wikiPageUrl = "www.wiki.com";

            var panel = new Panel();
            //panel.helpText = "This panel does nothing";

            var ok = new Button();
            //ok.toolTipText = "This is a OK button";

            var cancel = new Button();
            //cancel.toolTipText = "This is a CANCEL button";

            panel.Add(ok);
            panel.Add(cancel);
            dialog.Add(panel);

            ok.ShowHelp();
            cancel.ShowHelp();
            panel.ShowHelp();
            //dialog.ShowHelp();
        }
    }
}
