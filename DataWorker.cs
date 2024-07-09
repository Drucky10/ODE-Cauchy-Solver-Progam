using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CauchyProblemSolve
{
    public class DataWorker
    {
        public DataWorker() { }

        public (double?, double?, double?, int?) getData(string textBoxA, string textBoxB, string textBoxY0, string textBoxN) 
        {
            try
            {
                double a = double.Parse(textBoxA, System.Globalization.NumberFormatInfo.InvariantInfo);
                double b = double.Parse(textBoxB, System.Globalization.NumberFormatInfo.InvariantInfo);
                double y0 = double.Parse(textBoxY0, System.Globalization.NumberFormatInfo.InvariantInfo);
                int n = int.Parse(textBoxN);

                if (n < 0)
                {
                    n *= -1; 
                }
                else if (n == 0)
                {
                    throw (new Exception());
                }
                return (a, b, y0, n);
            }
            catch (Exception ex)
            {
                double? a = null; double? b = null; double? y0 = null; int? n = null;
                return (a, b, y0, n);
            }

        }



        public void SaveResults(string function, double a, double b, double y0, int n, double[] xEuler, double[] yEuler, double[] xEulerCauchy, double[] yEulerCauchy, double[] xRK4, double[] yRK4)
        {
            // Enregistrement des résultats dans des fichiers pour chaque méthode

            if (!Directory.Exists(Environment.CurrentDirectory + $"\\Results_text_files"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Results_text_files");
                Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Results_text_files\\Euler");
                Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Results_text_files\\Euler Cauchy");
                Directory.CreateDirectory(Environment.CurrentDirectory + $"\\Results_text_files\\RK4");

            }

            // Méthode d'Euler
            using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + $"\\Results_text_files\\Euler\\EulerResults{n}.txt"))
            {
                file.WriteLine($"Méthode d'Euler :Function {function};a = {a};b = {b};y0 = {y0};n = {n}");
                for (int i = 0; i < xEuler.Length; i++)
                {
                    file.WriteLine($"x[{i}] = {xEuler[i]}; y[{i}] = {yEuler[i]}");
                }
            }

            // Méthode d'Euler-Cauchy
            using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + $"\\Results_text_files\\Euler Cauchy\\EulerCauchyResults{n}.txt"))
            {
                file.WriteLine($"Méthode d'Euler-Cauchy:Function {function};a = {a};b = {b};y0 = {y0};n = {n}");
                for (int i = 0; i < xEulerCauchy.Length; i++)
                {
                    file.WriteLine($"x[{i}] = {xEulerCauchy[i]}; y[{i}] = {yEulerCauchy[i]}");
                }
            }

            // Méthode de Runge-Kutta d'ordre 4
            using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + $"\\Results_text_files\\RK4\\RK4Results{n}.txt"))
            {
                file.WriteLine($"Méthode de Runge-Kutta d'ordre 4:Function {function};a = {a};b = {b};y0 = {y0};n = {n}");
                for (int i = 0; i < xRK4.Length; i++)
                {
                    file.WriteLine($"x[{i}] = {xRK4[i]}; y[{i}] = {yRK4[i]}");
                }
            }
        }


        public void PrintPrecisionChart(Chart chart, double yEuler, double yEulerCauchy, double yRK4, int n)
        {

            // title
            chart.Titles.Add($"Comparaison de la précision (%) des méthodes pour des partitions n = {n}:");
            chart.Titles[0].ForeColor = Color.Red;
            chart.Titles[0].BackColor = Color.Yellow;
            chart.Titles[0].Font = new Font("Time new Roman", 12, FontStyle.Bold);

            //series

            Series precisions = new Series("Precisions");
            precisions.Points.AddXY("Euler", yEuler * 100);
            precisions.Points.AddXY("Euler-Cauchy", yEulerCauchy * 100);
            precisions.Points.AddXY("Runge-Kutta 4", yRK4 * 100);

            chart.Series.Add(precisions);
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].LegendText = "Precisions (%)";

            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart.Series[0].Label = "#PERCENT";

        }


        public void printOnTheListBox(ListBox listBox, string filePath)
        {
            string[] source = File.ReadAllLines(filePath);
            listBox.DataSource = source;

        }

    }
}
