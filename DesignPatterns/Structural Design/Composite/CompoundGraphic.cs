using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // The composite class represents complex components that may
    // have children. Composite objects usually delegate the actual
    // work to their children and then "sum up" the result.
    public class CompoundGraphic : IGraphic
    {
        private List<IGraphic> children = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            children.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            children.Remove(graphic);
        }

        // A composite executes its primary logic in a particular
        // way. It traverses recursively through all its children,
        // collecting and summing up their results. Since the
        // composite's children pass these calls to their own
        // children and so forth, the whole object tree is traversed
        // as a result.
        public void Draw()
        {
            // 1. For each child component:
            // - Draw the component.

            // - Update the bounding rectangle.
            // 2. Draw a dashed rectangle using the bounding coordinates.
        }

        public void Move(int x, int y)
        {
            foreach(var item in children)
                item.Move(x, y);
        }
    }
}
