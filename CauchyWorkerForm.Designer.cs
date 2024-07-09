namespace CauchyProblemSolve
{
    partial class CauchyWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_CauchyWorker = new System.Windows.Forms.TabControl();
            this.tabPage_Parametes = new System.Windows.Forms.TabPage();
            this.userControl_PageCalcul2 = new CauchyProblemSolve.UserControl_PageCalcul();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.tabPage_ResultInterfaceView = new System.Windows.Forms.TabPage();
            this.userControl_InterfaceResultView2 = new CauchyProblemSolve.UserControl_InterfaceResultView();
            this.tabPage_DiagramInterfaceView = new System.Windows.Forms.TabPage();
            this.userControl_DiagramView2 = new CauchyProblemSolve.UserControl_DiagramView();
            this.tabControl_CauchyWorker.SuspendLayout();
            this.tabPage_Parametes.SuspendLayout();
            this.tabPage_ResultInterfaceView.SuspendLayout();
            this.tabPage_DiagramInterfaceView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_CauchyWorker
            // 
            this.tabControl_CauchyWorker.Controls.Add(this.tabPage_Parametes);
            this.tabControl_CauchyWorker.Controls.Add(this.tabPage_ResultInterfaceView);
            this.tabControl_CauchyWorker.Controls.Add(this.tabPage_DiagramInterfaceView);
            this.tabControl_CauchyWorker.Location = new System.Drawing.Point(27, 12);
            this.tabControl_CauchyWorker.Name = "tabControl_CauchyWorker";
            this.tabControl_CauchyWorker.SelectedIndex = 0;
            this.tabControl_CauchyWorker.Size = new System.Drawing.Size(550, 354);
            this.tabControl_CauchyWorker.TabIndex = 0;
            // 
            // tabPage_Parametes
            // 
            this.tabPage_Parametes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage_Parametes.Controls.Add(this.userControl_PageCalcul2);
            this.tabPage_Parametes.Controls.Add(this.buttonSolve);
            this.tabPage_Parametes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Parametes.Name = "tabPage_Parametes";
            this.tabPage_Parametes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Parametes.Size = new System.Drawing.Size(542, 328);
            this.tabPage_Parametes.TabIndex = 0;
            this.tabPage_Parametes.Text = "Calcul  Page";
            // 
            // userControl_PageCalcul2
            // 
            this.userControl_PageCalcul2.Location = new System.Drawing.Point(7, 7);
            this.userControl_PageCalcul2.Name = "userControl_PageCalcul2";
            this.userControl_PageCalcul2.Size = new System.Drawing.Size(435, 277);
            this.userControl_PageCalcul2.TabIndex = 20;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(6, 290);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(88, 23);
            this.buttonSolve.TabIndex = 19;
            this.buttonSolve.Text = "Résoudre";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // tabPage_ResultInterfaceView
            // 
            this.tabPage_ResultInterfaceView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage_ResultInterfaceView.Controls.Add(this.userControl_InterfaceResultView2);
            this.tabPage_ResultInterfaceView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ResultInterfaceView.Name = "tabPage_ResultInterfaceView";
            this.tabPage_ResultInterfaceView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ResultInterfaceView.Size = new System.Drawing.Size(542, 328);
            this.tabPage_ResultInterfaceView.TabIndex = 1;
            this.tabPage_ResultInterfaceView.Text = "Interface view Result";
            // 
            // userControl_InterfaceResultView2
            // 
            this.userControl_InterfaceResultView2.Location = new System.Drawing.Point(36, 6);
            this.userControl_InterfaceResultView2.Name = "userControl_InterfaceResultView2";
            this.userControl_InterfaceResultView2.Size = new System.Drawing.Size(470, 296);
            this.userControl_InterfaceResultView2.TabIndex = 0;
            // 
            // tabPage_DiagramInterfaceView
            // 
            this.tabPage_DiagramInterfaceView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage_DiagramInterfaceView.Controls.Add(this.userControl_DiagramView2);
            this.tabPage_DiagramInterfaceView.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DiagramInterfaceView.Name = "tabPage_DiagramInterfaceView";
            this.tabPage_DiagramInterfaceView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DiagramInterfaceView.Size = new System.Drawing.Size(542, 328);
            this.tabPage_DiagramInterfaceView.TabIndex = 2;
            this.tabPage_DiagramInterfaceView.Text = "Diagramm Result View";
            // 
            // userControl_DiagramView2
            // 
            this.userControl_DiagramView2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControl_DiagramView2.Location = new System.Drawing.Point(14, 5);
            this.userControl_DiagramView2.Name = "userControl_DiagramView2";
            this.userControl_DiagramView2.Size = new System.Drawing.Size(512, 317);
            this.userControl_DiagramView2.TabIndex = 0;
            // 
            // CauchyWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.tabControl_CauchyWorker);
            this.Name = "CauchyWorkerForm";
            this.Text = "Cauchy Solver";
            this.Load += new System.EventHandler(this.CauchyWorkerForm_Load);
            this.tabControl_CauchyWorker.ResumeLayout(false);
            this.tabPage_Parametes.ResumeLayout(false);
            this.tabPage_ResultInterfaceView.ResumeLayout(false);
            this.tabPage_DiagramInterfaceView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_CauchyWorker;
        private System.Windows.Forms.TabPage tabPage_Parametes;
        private System.Windows.Forms.TabPage tabPage_ResultInterfaceView;
        private System.Windows.Forms.TabPage tabPage_DiagramInterfaceView;
        private UserControl_InterfaceResultView userControl_InterfaceResultView1;
        private UserControl_DiagramView userControl_DiagramView1;
        private UserControl_PageCalcul userControl_PageCalcul1;
        public System.Windows.Forms.Button buttonSolve;
        private UserControl_PageCalcul userControl_PageCalcul2;
        private UserControl_InterfaceResultView userControl_InterfaceResultView2;
        private UserControl_DiagramView userControl_DiagramView2;
    }
}