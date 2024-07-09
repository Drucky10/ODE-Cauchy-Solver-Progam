using System;


namespace CauchyProblemSolve
{
    public class DifferentialsMethods
    {

        public DifferentialsMethods() { }

        public (double[], double[]) SolveEuler( double a, double b, double y0, int n, Func<double, double, double > f )
        {
            double[] x = new double[n + 1];
            double[] y = new double[n + 1];
            double h = (b - a) / n;
            y[0] = y0;
            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h;
                y[i + 1] = y[i] + h * f(x[i], y[i]);
            }
            x[n] = b;

            return (x, y);
        }

        public (double[], double[]) SolveRK4(double a, double b, double y0, int n, Func<double, double, double> f)
        {
            double[] x = new double[n + 1];
            double[] y = new double[n + 1];
            double h = (b - a) / n;

            y[0] = y0;
            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h;
                double k1 = h * f(x[i], y[i]);
                double k2 = h * f(x[i] + h / 2, y[i] + k1 / 2);
                double k3 = h * f(x[i] + h / 2, y[i] + k2 / 2);
                double k4 = h * f(x[i] + h, y[i] + k3);
                y[i + 1] = y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            }
            x[n] = b;

            return (x, y);
        }

        public (double[], double[]) SolveEulerCauchy(double a, double b, double y0, int n, Func<double, double, double> f)
        {
            double[] x = new double[n + 1];
            double[] y = new double[n + 1];
            double h = (b - a) / n;

            y[0] = y0;
            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h;
                double k1 = h * f(x[i], y[i]);
                double k2 = h * f(x[i] + h / 2, y[i] + k1 / 2);
                y[i + 1] = y[i] + k2;
            }
            x[n] = b;

            return (x, y);
        }



    }
}
