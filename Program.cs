using System;

namespace TRPO
{ 
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            try
            {
                b.Solve(2, 4);
                b.Solve(1, -2, -3);
                b.Solve(1, 4, 4);
                b.Solve(-2, 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}