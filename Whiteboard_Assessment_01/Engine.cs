using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Assessment_01
{
    public class Engine
    {
        public Engine() { }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public string Combine(string a, string b)
        {
            return $"{a} {b}";
        }
    }
}
