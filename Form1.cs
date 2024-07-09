using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauchyProblemSolve
{
    public partial class Form1 : Form
    {


        private DataTable table;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {



            comboBox_Select_Function.Items.Add("(x+y) / pi*exp(y)") ;
            comboBox_Select_Function.SelectedIndex = 0;


            table = new DataTable();

            // Add columns to the DataTable
            table.Columns.Add("Partitions (n)", typeof(int));
            table.Columns.Add("Euler", typeof(double));
            table.Columns.Add("Euler-Cauchy", typeof(double));
            table.Columns.Add("Runge-Kutta 4", typeof(double));
            // Rebind the filtered and transformed DataTable to the DataGridView
            dataGridView1.DataSource = table.DefaultView;

        }

        private void InitializeDataTable(int n, double yEuler, double yEulerCauchy, double yRK4)
        {
            string yEuler1 = String.Format("{0:0.000000}", yEuler);
            string yEulerCauchy1 = String.Format("{0:0.000000}", yEulerCauchy);
            string yRK41 = String.Format("{0:0.000000}", yRK4);

            string line = $"{n}|{yEuler1}|{yEulerCauchy1}|{yRK41}";
            string[] values = line.Split('|');
            table.Rows.Add(values);
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            DataWorker data = new DataWorker();
            DifferentialsMethods methodsResolutions = new DifferentialsMethods();
            ListOfFunctions myFunction = new ListOfFunctions();

            (double? a, double? b, double? y0, int? n) = data.getData(textBoxA.Text, textBoxB.Text, textBoxY0.Text, textBoxN.Text);

            if (a != null && b != null && y0 != null && n != null)
            {
                (double[] xEuler, double[] yEuler) = methodsResolutions.SolveEuler((double)a, (double)b, (double)y0, (int)n, myFunction.f);
                (double[] xEulerCauchy, double[] yEulerCauchy) = methodsResolutions.SolveEulerCauchy((double)a, (double)b, (double)y0, (int)n, myFunction.f);
                (double[] xRK4, double[] yRK4) = methodsResolutions.SolveRK4((double)a, (double)b, (double)y0, (int)n, myFunction.f);



                // Enregistrement des résultats dans des fichiers
               // data.SaveResults((double)a, (double)b, (double)y0, (int)n, xEuler, yEuler, xEulerCauchy, yEulerCauchy, xRK4, yRK4);

                // Comparaison de la précision des méthodes
                data.PrintPrecisionChart(chartResults, yEuler[(int)n], yEulerCauchy[(int)n], yRK4[(int)n], (int)n);



                // Affichage des resultats sur les listBox
                data.printOnTheListBox(listBox_Euler, Environment.CurrentDirectory + $"\\Results_text_files\\EulerResults{n}.txt");
                data.printOnTheListBox(listBox_Euler_Cauchy, Environment.CurrentDirectory + $"\\Results_text_files\\EulerCauchyResults{n}.txt");
                data.printOnTheListBox(listBox_RK4, Environment.CurrentDirectory + $"\\Results_text_files\\RK4Results{n}.txt");



                // Évaluation de l'influence de la taille du pas
                Console.WriteLine("\nÉvaluation de l'influence de la taille du pas:");
                for (int i = (int)n ; i <= n*10; i += 10)
                {
                    (xEuler, yEuler) = methodsResolutions.SolveEuler((double)a, (double)b, (double)y0, i, myFunction.f);
                    (xEulerCauchy, yEulerCauchy) = methodsResolutions.SolveEulerCauchy((double)a, (double)b, (double)y0, i, myFunction.f);
                    (xRK4, yRK4) = methodsResolutions.SolveRK4((double)a, (double)b, (double)y0,i, myFunction.f);
                    Console.WriteLine($"n = {i}: Euler = {yEuler[i]}, Euler-Cauchy = {yEulerCauchy[i]}, Runge-Kutta 4 = {yRK4[i]}");
                    InitializeDataTable(i, yEuler[i], yEulerCauchy[i], yRK4[i]);
                }

                // Rebind the filtered and transformed DataTable to the DataGridView
                dataGridView1.DataSource = table.DefaultView;

                // Display filtered and transformed matrix
                dataGridView1.Refresh();




            }
            else
            {
                MessageBox.Show("You entered the incorrect value");
            }
        }

        private void listBox_Euler_Cauchy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
