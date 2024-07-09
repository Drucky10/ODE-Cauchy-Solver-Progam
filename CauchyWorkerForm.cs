using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CauchyProblemSolve
{
    public partial class CauchyWorkerForm : Form
    {

        private DataTable table;


        public CauchyWorkerForm()
        {
            InitializeComponent();
        }

        private void CauchyWorkerForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> myDictFunctions = new Dictionary<int, string>();
            UserControl_PageCalcul uc_CLP = (UserControl_PageCalcul)this.tabControl_CauchyWorker.TabPages[0].Controls[0];

            ListOfFunctions myFunction = new ListOfFunctions();
            myFunction.readFunctions(myDictFunctions);


            for(int i = 0; i < myDictFunctions.Count; i++)
            {
                uc_CLP.comboBox_Select_Function.Items.Add(myDictFunctions[i]);

            }
            uc_CLP.comboBox_Select_Function.SelectedIndex = 0;


            table = new DataTable();

            // Add columns to the DataTable
            table.Columns.Add("Partitions (n)", typeof(int));
            table.Columns.Add("Euler", typeof(double));
            table.Columns.Add("Euler-Cauchy", typeof(double));
            table.Columns.Add("Runge-Kutta 4", typeof(double));



            UserControl_InterfaceResultView uc_IRV = (UserControl_InterfaceResultView)this.tabControl_CauchyWorker.TabPages[1].Controls[0];
            // Rebind the filtered and transformed DataTable to the DataGridView
            uc_IRV.dataGridView1.DataSource = table.DefaultView;
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
            Dictionary<int, Func<double, double, double> > myDictFunctions = new Dictionary<int, Func<double, double, double> >();
            DifferentialsMethods methodsResolutions = new DifferentialsMethods();
            ListOfFunctions myFunction = new ListOfFunctions();
            myFunction.getFunctions(myDictFunctions);


            UserControl_PageCalcul uc_CLM = (UserControl_PageCalcul)this.tabControl_CauchyWorker.TabPages[0].Controls[0];

            (double? a, double? b, double? y0, int? n) = data.getData(uc_CLM.textBoxA.Text, uc_CLM.textBoxB.Text, uc_CLM.textBoxY0.Text, uc_CLM.textBoxN.Text);

            if (a != null && b != null && y0 != null && n != null)
            {
                (double[] xEuler, double[] yEuler) = methodsResolutions.SolveEuler((double)a, (double)b, (double)y0, (int)n, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex ]);
                (double[] xEulerCauchy, double[] yEulerCauchy) = methodsResolutions.SolveEulerCauchy((double)a, (double)b, (double)y0, (int)n, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex ]);
                (double[] xRK4, double[] yRK4) = methodsResolutions.SolveRK4((double)a, (double)b, (double)y0, (int)n, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex ]);
                    

                // Enregistrement des résultats dans des fichiers
                data.SaveResults((string)uc_CLM.comboBox_Select_Function.Items[uc_CLM.comboBox_Select_Function.SelectedIndex], (double)a, (double)b, (double)y0, (int)n, xEuler, yEuler, xEulerCauchy, yEulerCauchy, xRK4, yRK4);

                // Comparaison de la précision des méthodes
                UserControl_DiagramView uc_DV = (UserControl_DiagramView)this.tabControl_CauchyWorker.TabPages[2].Controls[0];
                data.PrintPrecisionChart(uc_DV.chartResults, yEuler[(int)n], yEulerCauchy[(int)n], yRK4[(int)n], (int)n);



                // Affichage des resultats sur les listBox

                UserControl_PageCalcul uc_CLM2 = (UserControl_PageCalcul)this.tabControl_CauchyWorker.TabPages[0].Controls[0]; // on accede a la page "Calcul Page" sur tabControl_CauchyWorker

                UserControl_CalculListOfMethod uc_CM_ListBox_Euler = (UserControl_CalculListOfMethod)uc_CLM2.tabControl2.TabPages[0].Controls[0]; // on accede a la page "Euler Result" sur tabControl2
                UserControl_CalculListOfMethod uc_CM_ListBox_Euler_Cauchy = (UserControl_CalculListOfMethod)uc_CLM2.tabControl2.TabPages[1].Controls[0]; // on accede a la page "Euler Cauchy Result" sur tabControl2
                UserControl_CalculListOfMethod uc_CM_ListBox_RK4 = (UserControl_CalculListOfMethod)uc_CLM2.tabControl2.TabPages[2].Controls[0]; // on accede a la page "RK4 Result" sur tabControl2


                // on affiche les resultats de chaque methode sur chaque listBox correspondantes a partir des fichier de sauvegarde
                data.printOnTheListBox(uc_CM_ListBox_Euler.listBox_MethodsList, Environment.CurrentDirectory + $"\\Results_text_files\\Euler\\EulerResults{n}.txt");
                data.printOnTheListBox(uc_CM_ListBox_Euler_Cauchy.listBox_MethodsList, Environment.CurrentDirectory + $"\\Results_text_files\\Euler Cauchy\\EulerCauchyResults{n}.txt");
                data.printOnTheListBox(uc_CM_ListBox_RK4.listBox_MethodsList, Environment.CurrentDirectory + $"\\Results_text_files\\RK4\\RK4Results{n}.txt");



                // Évaluation de l'influence de la taille du pas
                Console.WriteLine("\nÉvaluation de l'influence de la taille du pas:");
                for (int i = (int)n; i <= n * 10; i += 10)
                {
                    (xEuler, yEuler) = methodsResolutions.SolveEuler((double)a, (double)b, (double)y0, i, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex]);
                    (xEulerCauchy, yEulerCauchy) = methodsResolutions.SolveEulerCauchy((double)a, (double)b, (double)y0, i, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex]);
                    (xRK4, yRK4) = methodsResolutions.SolveRK4((double)a, (double)b, (double)y0, i, myDictFunctions[uc_CLM.comboBox_Select_Function.SelectedIndex]);
                    Console.WriteLine($"n = {i}: Euler = {yEuler[i]}, Euler-Cauchy = {yEulerCauchy[i]}, Runge-Kutta 4 = {yRK4[i]}");
                    InitializeDataTable(i, yEuler[i], yEulerCauchy[i], yRK4[i]);
                }

                // Rebind the filtered and transformed DataTable to the DataGridView
                UserControl_InterfaceResultView uc_IRV2 = (UserControl_InterfaceResultView)this.tabControl_CauchyWorker.TabPages[1].Controls[0];
                uc_IRV2.dataGridView1.DataSource = table.DefaultView;

                // Display filtered and transformed matrix
                uc_IRV2.dataGridView1.Refresh();




            }
            else
            {
                MessageBox.Show("You entered the incorrect value");
            }
        }





    }
}
