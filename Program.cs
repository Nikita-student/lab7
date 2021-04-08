using System;
using Oborotov;

namespace TRPO
{ 
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation myb = new QuadraticEquation();

            float a, b, c;
            Console.WriteLine("Введите 3 параметра a, b и с");
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToSingle(Console.ReadLine());

            try
            {
                MyLog.Log("Корни: " + String.Join(" ", myb.Solve(a, b, c)));
            }
            catch (OborotovException e)
            {
                MyLog.Log(e.Message);
            }

            MyLog.Write();
            Console.ReadKey();
        }
    }
}