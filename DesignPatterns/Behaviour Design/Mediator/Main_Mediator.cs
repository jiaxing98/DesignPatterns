using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
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
