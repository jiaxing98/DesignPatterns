using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg _squarePeg;
        public override int Radius { get { return (int)(_squarePeg.Width * Math.Sqrt(2) / 2); } }

        public SquarePegAdapter(SquarePeg squarePeg) : base()
        {
            _squarePeg = squarePeg;
            _radius = Radius;
        }
    }
}
