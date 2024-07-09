using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauchyProblemSolve
{
    public class ListOfFunctions
    {

        public ListOfFunctions() { }



        public double f(double x, double y) { return (x + y) / Math.PI * Math.Exp(x); }

        public double f1(double x , double y) { return (x - y) / Math.PI * x; }

        public double f2(double x, double y) { return x - y + x * x; }

        public double f3(double x, double y) { return -x * x - y * y; }


        public Dictionary<int, string> readFunctions(Dictionary<int, string> dictFunctions) 
        {
            dictFunctions.Add(0, "(x + y) / PI * Exp(x)");
            dictFunctions.Add(1, "(x - y) / PI * x");
            dictFunctions.Add(2, "x - y + x * x");
            dictFunctions.Add(3, "-x * x - y * y");

            return dictFunctions;


        }

        public Dictionary<int, Func<double, double, double> > getFunctions(Dictionary<int, Func<double, double, double> > dictFunctions) 
        {

            dictFunctions.Add(0, f);
            dictFunctions.Add(1, f1);
            dictFunctions.Add(2, f2);
            dictFunctions.Add(3, f3);

            return dictFunctions;
        
        }

    }
}
