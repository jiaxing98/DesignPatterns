using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // Primitive components may be fine with default help
    // implementation...
    public class Button : Component
    {
        public override void ShowHelp()
        {
            if (toolTipText != null)
                Console.WriteLine($"Showing ToolTip: {toolTipText} from Button class...");
            else
                base.ShowHelp();
        }
    }

    // But complex components may override the default
    // implementation. If the help text can't be provided in a new
    // way, the component can always call the base implementation
    // (see Component class).
    public class Panel : Container
    {
        public string helpText;

        public override void ShowHelp()
        {
            if(helpText != null)
                Console.WriteLine($"Showing ToolTip: {helpText} from Panel class...");
            else
                base.ShowHelp();
        }
    }

    public class Dialog : Container
    {
        public string wikiPageUrl;

        public override void ShowHelp()
        {
            if (wikiPageUrl != null)
                Console.WriteLine($"Showing ToolTip: {wikiPageUrl} from Dialog class...");
            else
                base.ShowHelp();
        }
    }
}
