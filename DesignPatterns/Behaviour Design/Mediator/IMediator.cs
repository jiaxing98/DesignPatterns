using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // The mediator interface declares a method used by components
    // to notify the mediator about various events. The mediator may
    // react to these events and pass the execution to other
    // components.
    public interface IMediator
    {
        void Notify(Component sender, string message);
    }

    // The concrete mediator class. The intertwined web of
    // connections between individual components has been untangled
    // and moved into the mediator.
    public class AuthenticationDialog : IMediator
    {
        private string _title;
        private Checkbox _loginOrRegisterCheckbox;
        private Textbox _loginUsername, _loginPassword;
        private Textbox _registerUsername, _registerPassword, _registerEmail;
        private Button _okButton, _cancelButton;

        public AuthenticationDialog(Checkbox checkbox, Button okButton)
        {
            _loginOrRegisterCheckbox = checkbox;
            _loginOrRegisterCheckbox.SetMediator(this);

            _okButton = okButton;
            _okButton.SetMediator(this);
        }

        // When something happens with a component, it notifies the
        // mediator. Upon receiving a notification, the mediator may
        // do something on its own or pass the request to another
        // component.
        public void Notify(Component sender, string message)
        {
            if(sender == _loginOrRegisterCheckbox && message == "Check")
            {
                if (_loginOrRegisterCheckbox.hasChecked)
                {
                    _title = "Login";
                    //1. Show login form components.
                    //2. Hide registration form components
                    Console.WriteLine("Show Login Form.");
                }
                else
                {
                    _title = "Register";
                    //1. Show register form components.
                    //2. Hide login form components
                    Console.WriteLine("Show Register Form.");
                }
            }
            
            if(sender == _okButton && message == "Click")
            {
                if (_loginOrRegisterCheckbox.hasChecked)
                {
                    // Try to find a user using login credentials.
                    Console.WriteLine("Logging in the user...");
                }
                else
                {
                    // 1. Create a user account using data from the
                    // registration fields.
                    // 2. Log that user in.
                    Console.WriteLine("Registering in the user...");
                }
            }
        }
    }

}
