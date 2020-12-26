using System;
using System.Collections.Generic;

namespace TRPO
{
    class A
    {
        protected List<float> X;
        public List<float> Solve(float a, float b)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение не имеет решения, a = 0");
            }
            return X = new List<float> { -b / a };
        }
    }
}