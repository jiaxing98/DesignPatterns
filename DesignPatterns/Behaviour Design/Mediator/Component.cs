using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // Components communicate with a mediator using the mediator
    // interface. Thanks to that, you can use the same components in
    // other contexts by linking them with different mediator
    // objects.
    public class Component
    {
        public IMediator? mediator;

        public Component(IMediator? mediator = null)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Click()
        {
            mediator?.Notify(this, "Click");
        }

        public void Keypress()
        {
            mediator?.Notify(this, "Keypress");
        }
    }

    // Concrete components don't talk to each other. They have only
    // one communication channel, which is sending notifications to
    // the mediator.
    public class Button : Component
    {
        public Button(IMediator? dialog = null) : base(dialog) { }
    }

    public class Textbox : Component
    {
        public Textbox(IMediator? dialog = null) : base(dialog) { }
    }

    public class Checkbox : Component
    {
        public bool hasChecked;

        public Checkbox(IMediator? dialog = null) : base(dialog) { }

        public void Check()
        {
            hasChecked = !hasChecked;
            mediator?.Notify(this, "Check");
        }
    }
}
