using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_120;

namespace Exercise_120
{
    class Cube
    {
        int edgeLength;
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;

        }

        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;

        }

        public override string ToString()
        {
            return "The length of the edge is " + edgeLength + " and the volume " + this.Volume();
        }
        
    }
}
