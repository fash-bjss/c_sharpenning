using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academy_demo_fa.calc
{
    public class Calculator
    {
        public Double Divide(int a, int b)
        {
            // Handling the error from within the method
            if (b == 0)
            {
                throw new DivideByZeroException("You are attempting to divide by Zero");
            }
            return a / b;
        }
    }
}
