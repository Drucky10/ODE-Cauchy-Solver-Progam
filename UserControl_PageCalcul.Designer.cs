namespace CauchyProblemSolve
{
    partial class UserControl_PageCalcul
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_EulerView = new System.Windows.Forms.TabPage();
            this.tabPage_EulerCauchy = new System.Windows.Forms.TabPage();
            this.tabPage_RK4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Select_Function = new System.Windows.Forms.ComboBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userControl_CalculListOfMethod4 = new CauchyProblemSolve.UserControl_CalculListOfMethod();
            this.userControl_CalculListOfMethod5 = new CauchyProblemSolve.UserControl_CalculListOfMethod();
            this.userControl_CalculListOfMethod6 = new CauchyProblemSolve.UserControl_CalculListOfMethod();
            this.tabControl2.SuspendLayout();
            this.tabPage_EulerView.SuspendLayout();
            this.tabPage_EulerCauchy.SuspendLayout();
            this.tabPage_RK4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_EulerView);
            this.tabControl2.Controls.Add(this.tabPage_EulerCauchy);
            this.tabControl2.Controls.Add(this.tabPage_RK4);
            this.tabControl2.Location = new System.Drawing.Point(139, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(314, 249);
            this.tabControl2.TabIndex = 41;
            // 
            // tabPage_EulerView
            // 
            this.tabPage_EulerView.Controls.Add(this.userControl_CalculListOfMethod4);
            this.tabPage_EulerView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EulerView.Name = "tabPage_EulerView";
            this.tabPage_EulerView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EulerView.Size = new System.Drawing.Size(283, 223);
            this.tabPage_EulerView.TabIndex = 0;
            this.tabPage_EulerView.Text = "Euler  Result";
            this.tabPage_EulerView.UseVisualStyleBackColor = true;
            // 
            // tabPage_EulerCauchy
            // 
            this.tabPage_EulerCauchy.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_EulerCauchy.Controls.Add(this.userControl_CalculListOfMethod5);
            this.tabPage_EulerCauchy.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EulerCauchy.Name = "tabPage_EulerCauchy";
            this.tabPage_EulerCauchy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EulerCauchy.Size = new System.Drawing.Size(283, 223);
            this.tabPage_EulerCauchy.TabIndex = 1;
            this.tabPage_EulerCauchy.Text = "Euler Cauchy Result";
            // 
            // tabPage_RK4
            // 
            this.tabPage_RK4.Controls.Add(this.userControl_CalculListOfMethod6);
            this.tabPage_RK4.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RK4.Name = "tabPage_RK4";
            this.tabPage_RK4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RK4.Size = new System.Drawing.Size(306, 223);
            this.tabPage_RK4.TabIndex = 2;
            this.tabPage_RK4.Text = "RK4";
            this.tabPage_RK4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Select_Function);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.textBoxY0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 249);
            this.groupBox1.TabIndex = 40;
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
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(34, 117);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(88, 20);
            this.textBoxA.TabIndex = 14;
            this.textBoxA.Text = "0";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(34, 143);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(88, 20);
            this.textBoxB.TabIndex = 15;
            this.textBoxB.Text = "1";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(34, 169);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(88, 20);
            this.textBoxY0.TabIndex = 16;
            this.textBoxY0.Text = "1";
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
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(34, 195);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(88, 20);
            this.textBoxN.TabIndex = 17;
            this.textBoxN.Text = "10";
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
            // userControl_CalculListOfMethod4
            // 
            this.userControl_CalculListOfMethod4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl_CalculListOfMethod4.Location = new System.Drawing.Point(6, 6);
            this.userControl_CalculListOfMethod4.Name = "userControl_CalculListOfMethod4";
            this.userControl_CalculListOfMethod4.Size = new System.Drawing.Size(271, 206);
            this.userControl_CalculListOfMethod4.TabIndex = 0;
            // 
            // userControl_CalculListOfMethod5
            // 
            this.userControl_CalculListOfMethod5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl_CalculListOfMethod5.Location = new System.Drawing.Point(7, 7);
            this.userControl_CalculListOfMethod5.Name = "userControl_CalculListOfMethod5";
            this.userControl_CalculListOfMethod5.Size = new System.Drawing.Size(270, 206);
            this.userControl_CalculListOfMethod5.TabIndex = 0;
            // 
            // userControl_CalculListOfMethod6
            // 
            this.userControl_CalculListOfMethod6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl_CalculListOfMethod6.Location = new System.Drawing.Point(7, 4);
            this.userControl_CalculListOfMethod6.Name = "userControl_CalculListOfMethod6";
            this.userControl_CalculListOfMethod6.Size = new System.Drawing.Size(270, 206);
            this.userControl_CalculListOfMethod6.TabIndex = 0;
            // 
            // UserControl_PageCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_PageCalcul";
            this.Size = new System.Drawing.Size(485, 281);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_EulerView.ResumeLayout(false);
            this.tabPage_EulerCauchy.ResumeLayout(false);
            this.tabPage_RK4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage_EulerView;
        public System.Windows.Forms.TabPage tabPage_EulerCauchy;
        public System.Windows.Forms.TabPage tabPage_RK4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBox_Select_Function;
        public System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxB;
        public System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label4;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod1;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod2;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod3;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod4;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod5;
        public UserControl_CalculListOfMethod userControl_CalculListOfMethod6;
    }
}
