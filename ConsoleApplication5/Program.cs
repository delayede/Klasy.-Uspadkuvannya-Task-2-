using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLineKubeHyperbola
{


    abstract class Function
    {
        public abstract double Count(double x);
    }




    // КЛАС ЛІНІЯ 
    class Line : Function
    {
        public readonly double A;
        public readonly double B;

        public Line(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Count(double x)
        {
            return A * x + B;
        }
    }

    // Клас КУБ
    class Kub : Function
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;

        public Kub(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Count(double x)
        {
            return A * x * x + B * x + C;
        }
    }


    // Класс ГІПЕРБОЛА
    class Hyperbola : Function
    {
        public readonly double A;

        public Hyperbola(double a)
        {
            A = a;
        }

        public override double Count(double x)
        {
            return A / x;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Function[] func = new Function[3];
            func[0] = new Line(2, 3);
            func[1] = new Kub(2, 3, 4);
            func[2] = new Hyperbola(3);
            double x = 3.6;
            foreach (Function f in func)
                Console.WriteLine("значення функції {0} для x = {1} дорівнює {2}", f.GetType(), x, f.Count(x));
            Console.ReadLine();
        }
    }
}