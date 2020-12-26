using System;
using Oborotov;

namespace TRPO
{ 
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation b = new QuadraticEquation();
            try
            {
                MyLog.Log("Корни: " + String.Join(" ", b.Solve(4, -5, -9)));
            }
            catch (Exception e)
            {
                MyLog.Log(e.Message);
            }

            MyLog.Write();
            Console.ReadKey();
        }
    }
}