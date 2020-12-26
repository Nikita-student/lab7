using System;
using System.Collections.Generic;

namespace TRPO
{
    class B : A
    {
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
                return base.Solve(b, c);
           float D = (float) Math.Sqrt (discriminant(a, b, c));
            if (D == 0)
            {
                return X = new List<float>() { (-b + D) / (2 * a) };
            }
            if (D > 0)
            {
                return X = new List<float>()
                {
                    (-b + D) / (2 * a),
                    (-b - D) / (2 * a)
                };
            }
            if (D < 0)
            {
                throw new Exception("Уравнение не имеет решения, D < 0");
            }
            return X;
        }
        protected float discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * a * c;
        }
    }
}