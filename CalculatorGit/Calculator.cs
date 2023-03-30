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
    }
}
