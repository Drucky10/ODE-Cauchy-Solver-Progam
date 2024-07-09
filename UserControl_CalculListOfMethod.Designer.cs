namespace CauchyProblemSolve
{
    partial class UserControl_CalculListOfMethod
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
            this.listBox_MethodsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_MethodsList
            // 
            this.listBox_MethodsList.FormattingEnabled = true;
            this.listBox_MethodsList.Location = new System.Drawing.Point(3, 1);
            this.listBox_MethodsList.Name = "listBox_MethodsList";
            this.listBox_MethodsList.Size = new System.Drawing.Size(266, 199);
            this.listBox_MethodsList.TabIndex = 3;
            // 
            // UserControl_CalculListOfMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.listBox_MethodsList);
            this.Name = "UserControl_CalculListOfMethod";
            this.Size = new System.Drawing.Size(283, 206);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_MethodsList;
    }
}
