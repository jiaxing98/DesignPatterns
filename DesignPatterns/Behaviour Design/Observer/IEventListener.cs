using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Here's the subscriber interface. If your programming language
    // supports functional types, you can replace the whole
    // subscriber hierarchy with a set of functions.
    public interface IEventListener
    {
        void Update(string filename);
    }

    // Concrete subscribers react to updates issued by the publisher
    // they are attached to.
    public class LoggingListener : IEventListener
    {
        private string _message;

        public LoggingListener(string message)
        {
            _message = message;
        }

        public void Update(string filename)
        {
            Console.WriteLine($"Updating the message: {_message} in file {filename}");
        }
    }

    public class EmailAlertsListener : IEventListener
    {
        private string _email;
        private string _message;

        public EmailAlertsListener(string email, string message)
        {
            _email = email;
            _message = message;
        }

        public void Update(string filename)
        {
            Console.WriteLine($"Updating the message: {_message} to email: {_email} in file {filename}");
        }
    }
}
