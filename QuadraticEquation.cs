using System;
using System.Collections.Generic;
using System.Text;

namespace KvadratnaJedndzba
{
    public class QuadraticEquation
    {
        public QuadraticEquation()
        {

        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        public double Discriminant
        {
            get { return b * b - 4 * a * c; }
        }

        public Complex.Complex[] Roots
        {
            get
            {
                
                Complex.Complex[] sqrtDisc = Complex.Complex.Sqrt(this.Discriminant);
                Complex.Complex realPart = (new Complex.Complex(-this.b, 0)) / (new Complex.Complex(2 * this.a, 0));
                sqrtDisc[0] /= (new Complex.Complex(2 * this.a, 0));
                sqrtDisc[1] = sqrtDisc[1] / (new Complex.Complex(2 * this.a, 0));

                return new[] { realPart + sqrtDisc[0], realPart + sqrtDisc[1] };
            }
        }

        private double a;
        private double b;
        private double c;
    }
}
