using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Use the Adapter class when you want to use some existing
    //class, but its interface isn’t compatible with the rest of
    //your code.

    //Use the pattern when you want to reuse several existing subclasses
    //that lack some common functionality that can’t be
    //added to the superclass.

    public static class Main_Adapter
    {
        public static void Init()
        {
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            var isPegFits = hole.Fits(rpeg);
            Console.WriteLine("RoundHole with radius {0} fits RoundPeg with radius {1}: {2}", 
                hole.Radius, rpeg.Radius, isPegFits);

            var small_sqpeg = new SquarePeg(5);
            var large_sqpeg = new SquarePeg(10);
            //hole.Fits(small_sqpeg); // this won't compile (incompatible types)

            var small_sqpeg_adapter = new SquarePegAdapter(small_sqpeg);
            var large_sqpeg_adapter = new SquarePegAdapter(large_sqpeg);
            var isSmallFits = hole.Fits(small_sqpeg_adapter); // true
            var isLargeFits = hole.Fits(large_sqpeg_adapter); // false

            Console.WriteLine("RoundHole with radius {0} fits RoundPeg with radius {1}: {2}",
                hole.Radius, small_sqpeg_adapter.Radius, isSmallFits);

            Console.WriteLine("RoundHole with radius {0} fits RoundPeg with radius {1}: {2}",
                hole.Radius, large_sqpeg_adapter.Radius, isLargeFits);
        }
    }
}
