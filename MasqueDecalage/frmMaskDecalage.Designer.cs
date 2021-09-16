namespace MasqueDecalage
{
    partial class frmMaskDecalage
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
            this.btnDate = new System.Windows.Forms.Button();
            this.btnHeurre = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.textHeure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(58, 127);
            this.btnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(210, 44);
            this.btnDate.TabIndex = 0;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnHeurre
            // 
            this.btnHeurre.Location = new System.Drawing.Point(322, 127);
            this.btnHeurre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHeurre.Name = "btnHeurre";
            this.btnHeurre.Size = new System.Drawing.Size(210, 44);
            this.btnHeurre.TabIndex = 1;
            this.btnHeurre.Text = "Heurre";
            this.btnHeurre.UseVisualStyleBackColor = true;
            this.btnHeurre.Click += new System.EventHandler(this.btnHeurre_Click);
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(387, 252);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(210, 44);
            this.btnSortie.TabIndex = 2;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(58, 80);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(210, 26);
            this.txtDate.TabIndex = 3;
            // 
            // textHeure
            // 
            this.textHeure.Location = new System.Drawing.Point(322, 80);
            this.textHeure.Name = "textHeure";
            this.textHeure.Size = new System.Drawing.Size(210, 26);
            this.textHeure.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "HEURE";
            // 
            // frmMaskDecalage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.btnHeurre);
            this.Controls.Add(this.btnDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaskDecalage";
            this.Text = "Masque et Décalage, Yvan Morrissey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnHeurre;
        private System.Windows.Forms.Button btnSortie;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox textHeure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

