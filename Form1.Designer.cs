namespace CauchyProblemSolve
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_RK4 = new System.Windows.Forms.ListBox();
            this.listBox_Euler_Cauchy = new System.Windows.Forms.ListBox();
            this.listBox_Euler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Select_Function = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartResults
            // 
            this.chartResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartResults.Location = new System.Drawing.Point(606, 24);
            this.chartResults.Name = "chartResults";
            this.chartResults.Size = new System.Drawing.Size(534, 243);
            this.chartResults.TabIndex = 19;
            this.chartResults.Text = "chart1";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(34, 220);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(88, 23);
            this.buttonSolve.TabIndex = 18;
            this.buttonSolve.Text = "Résoudre";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(34, 195);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(88, 20);
            this.textBoxN.TabIndex = 17;
            this.textBoxN.Text = "10";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(34, 169);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(88, 20);
            this.textBoxY0.TabIndex = 16;
            this.textBoxY0.Text = "1";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(34, 143);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(88, 20);
            this.textBoxB.TabIndex = 15;
            this.textBoxB.Text = "1";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(34, 117);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(88, 20);
            this.textBoxA.TabIndex = 14;
            this.textBoxA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "y0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "a";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_RK4);
            this.panel1.Controls.Add(this.listBox_Euler_Cauchy);
            this.panel1.Controls.Add(this.listBox_Euler);
            this.panel1.Location = new System.Drawing.Point(12, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 241);
            this.panel1.TabIndex = 20;
            // 
            // listBox_RK4
            // 
            this.listBox_RK4.FormattingEnabled = true;
            this.listBox_RK4.Location = new System.Drawing.Point(641, 3);
            this.listBox_RK4.Name = "listBox_RK4";
            this.listBox_RK4.Size = new System.Drawing.Size(290, 212);
            this.listBox_RK4.TabIndex = 2;
            // 
            // listBox_Euler_Cauchy
            // 
            this.listBox_Euler_Cauchy.FormattingEnabled = true;
            this.listBox_Euler_Cauchy.Location = new System.Drawing.Point(312, 3);
            this.listBox_Euler_Cauchy.Name = "listBox_Euler_Cauchy";
            this.listBox_Euler_Cauchy.Size = new System.Drawing.Size(305, 212);
            this.listBox_Euler_Cauchy.TabIndex = 1;
            this.listBox_Euler_Cauchy.SelectedIndexChanged += new System.EventHandler(this.listBox_Euler_Cauchy_SelectedIndexChanged);
            // 
            // listBox_Euler
            // 
            this.listBox_Euler.FormattingEnabled = true;
            this.listBox_Euler.Location = new System.Drawing.Point(3, 3);
            this.listBox_Euler.Name = "listBox_Euler";
            this.listBox_Euler.Size = new System.Drawing.Size(270, 212);
            this.listBox_Euler.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Select_Function);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.buttonSolve);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.textBoxY0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 249);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select function";
            // 
            // comboBox_Select_Function
            // 
            this.comboBox_Select_Function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Select_Function.FormattingEnabled = true;
            this.comboBox_Select_Function.Location = new System.Drawing.Point(7, 19);
            this.comboBox_Select_Function.Name = "comboBox_Select_Function";
            this.comboBox_Select_Function.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Select_Function.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 249);
            this.dataGridView1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Diagramme interface results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Results interface view";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 556);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartResults);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Comparaison des méthodes de résolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Euler_Cauchy;
        private System.Windows.Forms.ListBox listBox_Euler;
        private System.Windows.Forms.ListBox listBox_RK4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Select_Function;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

