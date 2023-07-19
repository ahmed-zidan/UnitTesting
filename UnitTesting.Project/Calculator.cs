using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Project
{
    public class Calculator
    {
        public int Add(int x , int y)
        {
            return x + y;
        }
        public int divide_int(int x, int y)
        {
            return x/y;
        }
        public double divide_double(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            
            return x / y;
        }
    }
}
