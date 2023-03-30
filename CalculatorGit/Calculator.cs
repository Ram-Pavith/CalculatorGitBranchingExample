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

        public int Sub(int x, int y)
        {
            return Subtract.subtract(x, y);
        }
    }
}
