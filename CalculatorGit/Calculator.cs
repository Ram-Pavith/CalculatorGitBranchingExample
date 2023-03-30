using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGit
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return Addition.Add(x, y);
        }


        public int FindSquare(int x)
        {
            return Square.squareFn(x);
}
        public float div(float x, float y)
        {
            return division.div(x, y);
        }


        public int Sub(int x, int y)
        {
            return Subtract.subtract(x, y);
        }

        public float mult(int x,int y)
        {
            return multiply.mult(x,y);


        }
    }
}
