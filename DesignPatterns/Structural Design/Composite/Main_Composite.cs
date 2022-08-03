using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Use the Composite pattern when you have to implement a
    //tree-like object structure.

    //Use the pattern when you want the client code to treat both
    //simple and complex elements uniformly.

    public static class Main_Composite
    {
        public static CompoundGraphic all;

        public static void Init()
        {
            Load();
            //GroupSelected();
        }

        private static void Load()
        {
            all = new CompoundGraphic();
            all.Add(new Dot(1, 2));
            all.Add(new Circle(5, 3, 10));
        }

        // Combine selected components into one complex composite component.
        private static void GroupSelected(List<IGraphic> components)
        {
            var group = new CompoundGraphic();

            foreach (var item in components)
            {
                group.Add(item);
                all.Remove(item);
            }

            all.Add(group);
            all.Draw();
        }
    }
}
