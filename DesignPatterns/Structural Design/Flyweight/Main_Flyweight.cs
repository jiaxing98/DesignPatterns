using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    //Use the Flyweight pattern only when your program must support
    //a huge number of objects which barely fit into available
    //RAM.
    public static class Main_Flyweight
    {
        public static void Init()
        {
            var forest = new Forest();
            forest.plantTree(0, 0, "Tree0", "Green", "GreenTexture");
            forest.plantTree(1, 1, "Tree1", "Red", "RedTexture");
            forest.Draw();
        }
    }
}
