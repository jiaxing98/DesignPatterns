using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //Use the Visitor when you need to perform an operation on
    //all elements of a complex object structure(for example, an
    //object tree).

    //Use the Visitor to clean up the business logic of auxiliary
    //behaviors.

    //Use the pattern when a behavior makes sense only in some
    //classes of a class hierarchy, but not in others.

    public static class Main_Visitor
    {
        public static void Init()
        {
            List<IShape> shapes = new List<IShape>();
            XMLExportVisitor visitor = new XMLExportVisitor();

            shapes.ForEach(x => x.Accept(visitor));
        }
    }
}
