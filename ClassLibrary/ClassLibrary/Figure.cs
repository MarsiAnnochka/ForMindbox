using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Figure
    {
        public static double Round(double radius)
        {
            if (radius < 0)
                throw new Exception("Radius is less than zero");
            return Math.PI * Math.Pow(radius, 2.0) / 2;
        }

        public static double Triangle(double a, double b, double c)
        {
            try
            {
                Triangle triangle = new Triangle(a, b, c);
            }
            catch (Exception e)
            {
                throw e;
            }
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    
    public class Triangle
    {
        readonly double a = 0, b = 0, c = 0;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (!IsActual()) {
                throw new Exception("Triangle does not exist!");
            }
        }

        public bool IsRight()
        {
            return (Math.Pow(a, 2.0) + Math.Pow(b, 2.0) - Math.Pow(c, 2.0) == 0) ? true : false;
        }

        public bool IsActual()
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
                return true;
            else
                return false;
        }
    }
}
