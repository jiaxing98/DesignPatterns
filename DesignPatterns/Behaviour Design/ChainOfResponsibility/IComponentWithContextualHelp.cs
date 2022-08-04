using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // The handler interface declares a method for building a chain
    // of handlers. It also declares a method for executing a
    // request.
    public interface IComponentWithContextualHelp
    {
        void ShowHelp();
    }

    public abstract class Component : IComponentWithContextualHelp
    {
        public string toolTipText;
        // The component's container acts as the next link in the
        // chain of handlers.
        public Container? container;

        // The component shows a tooltip if there's help text
        // assigned to it. Otherwise it forwards the call to the
        // container, if it exists.
        public virtual void ShowHelp()
        {
            if (toolTipText != null)
                //Show toolTip
                Console.WriteLine($"Showing ToolTip from Component abstract base class...");
            else
            {
                container?.ShowHelp();
            }
        }
    }

    // Containers can contain both simple components and other
    // containers as children. The chain relationships are
    // established here. The class inherits showHelp behavior from
    // its parent.
    public abstract class Container : Component
    {
        protected List<Component> children = new List<Component>();

        public void Add(Component component)
        {
            children.Add(component);
            component.container = this;
        }
    }
}
