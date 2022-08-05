using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // The Visitor interface declares a set of visiting methods that
    // correspond to element classes. The signature of a visiting
    // method lets the visitor identify the exact class of the
    // element that it's dealing with.
    public interface IVisitor
    {
        void VisitDot(Dot d);
        void VisitCircle(Circle circle);
        void VisitRectangle(Rectangle rectangle);
        void VisitCompoundShape(CompoundShape cs);
    }

    // Concrete visitors implement several versions of the same
    // algorithm, which can work with all concrete element classes.

    // You can experience the biggest benefit of the Visitor pattern
    // when using it with a complex object structure such as a
    // Composite tree. In this case, it might be helpful to store
    // some intermediate state of the algorithm while executing the
    // visitor's methods over various objects of the structure.

    public class XMLExportVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            circle.Draw();
            circle.Move(0, 0);
            //Export the dot's ID, center coordinates and radius.
        }

        public void VisitCompoundShape(CompoundShape cs)
        {
            cs.Draw();
            cs.Move(0, 0);
            // Export the shape's ID as well as the list of its children's IDs.
        }

        public void VisitDot(Dot dot)
        {
            dot.Draw();
            dot.Move(0, 0);
            //Export the dot's ID, center coordinates
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            rectangle.Draw();
            rectangle.Move(0, 0);
            //Export the dot's ID, center coordinates, width and height
        }
    }
}
