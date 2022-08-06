using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double Root()
        {
            return -b / (double)k;
        }
    }
}
