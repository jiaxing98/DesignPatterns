using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //Use the Mediator pattern when it’s hard to change some of the
    //classes because they are tightly coupled to a bunch of other
    //classes.

    //Use the pattern when you can’t reuse a component in a different
    //program because it’s too dependent on other components.

    //Use the Mediator when you find yourself creating tons of component
    //subclasses just to reuse some basic behavior in various
    //contexts.

    public static class Main_Mediator
    {
        public static void Init()
        {
            Button okButton = new Button();
            Checkbox checkbox = new Checkbox();
            AuthenticationDialog dialog = new AuthenticationDialog(checkbox, okButton);

            checkbox.Check();
            okButton.Click();
        }
    }
}
