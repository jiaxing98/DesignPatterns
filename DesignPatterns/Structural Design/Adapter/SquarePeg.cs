using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SquarePeg
    {
        private int _width;
        public int Width { get { return _width; } }

        public SquarePeg(int width)
        {
            _width = width;
        }
    }
}
