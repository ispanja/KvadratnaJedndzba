using System;

namespace KvadratnaJedndzba
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            var roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            qe = new QuadraticEquation(-1, 2, -1);
            roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);
        }
    }
}
