using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RoundHole
    {
        private int _radius;
        public int Radius { get { return _radius; } }

        public RoundHole(int radius)
        {
            _radius = radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return _radius >= peg.Radius;
        }

    }

    public class RoundPeg
    {
        protected int _radius;
        public virtual int Radius { get { return _radius; } }
        public RoundPeg() { }
        public RoundPeg(int radius)
        {
            _radius = radius;
        }
    }
}
