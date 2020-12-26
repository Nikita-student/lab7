using System;
using System.Collections.Generic;
using core;

namespace Oborotov
{
    public class LinearEquation : IEquationInterface
    {
        protected List<float> X;
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение не имеет решения, a = 0");
            }
            return X = new List<float> { -b / a };
        }
    }
}