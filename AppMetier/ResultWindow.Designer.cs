namespace AppMetier
{
    partial class ResultWindow
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
            this.Ressources_ListView = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantitée = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrixTotal_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ressources_ListView
            // 
            this.Ressources_ListView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Ressources_ListView.BackColor = System.Drawing.Color.White;
            this.Ressources_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Quantitée,
            this.Prix,
            this.Total});
            this.Ressources_ListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ressources_ListView.FullRowSelect = true;
            this.Ressources_ListView.GridLines = true;
            this.Ressources_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Ressources_ListView.HideSelection = false;
            this.Ressources_ListView.Location = new System.Drawing.Point(0, 0);
            this.Ressources_ListView.Name = "Ressources_ListView";
            this.Ressources_ListView.Size = new System.Drawing.Size(462, 380);
            this.Ressources_ListView.TabIndex = 0;
            this.Ressources_ListView.UseCompatibleStateImageBehavior = false;
            this.Ressources_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 120;
            // 
            // Quantitée
            // 
            this.Quantitée.Text = "Quantitée";
            this.Quantitée.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            this.Prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prix.Width = 50;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 100;
            // 
            // PrixTotal_Label
            // 
            this.PrixTotal_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrixTotal_Label.Location = new System.Drawing.Point(0, 403);
            this.PrixTotal_Label.Name = "PrixTotal_Label";
            this.PrixTotal_Label.Size = new System.Drawing.Size(462, 30);
            this.PrixTotal_Label.TabIndex = 1;
            this.PrixTotal_Label.Text = "Prix total : 0 K";
            this.PrixTotal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.PrixTotal_Label);
            this.Controls.Add(this.Ressources_ListView);
            this.Name = "ResultWindow";
            this.Text = "Résultats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Ressources_ListView;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Quantitée;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label PrixTotal_Label;
    }
}