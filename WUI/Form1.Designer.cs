namespace WUI
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUnFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_Fournisseurs = new System.Windows.Forms.ListBox();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Chercher = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUnFichierToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerUnFichierToolStripMenuItem
            // 
            this.chargerUnFichierToolStripMenuItem.Name = "chargerUnFichierToolStripMenuItem";
            this.chargerUnFichierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chargerUnFichierToolStripMenuItem.Text = "Charger un fichier";
            // 
            // lst_Fournisseurs
            // 
            this.lst_Fournisseurs.FormattingEnabled = true;
            this.lst_Fournisseurs.ItemHeight = 15;
            this.lst_Fournisseurs.Location = new System.Drawing.Point(12, 27);
            this.lst_Fournisseurs.Name = "lst_Fournisseurs";
            this.lst_Fournisseurs.Size = new System.Drawing.Size(776, 379);
            this.lst_Fournisseurs.TabIndex = 1;
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(12, 415);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(161, 23);
            this.btn_Creer.TabIndex = 2;
            this.btn_Creer.Text = "Ajouter un fournisseur";
            this.btn_Creer.UseVisualStyleBackColor = true;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(428, 415);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(161, 23);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier un fournisseur";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(627, 415);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(161, 23);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer un fournisseur";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_Chercher
            // 
            this.btn_Chercher.Location = new System.Drawing.Point(224, 415);
            this.btn_Chercher.Name = "btn_Chercher";
            this.btn_Chercher.Size = new System.Drawing.Size(161, 23);
            this.btn_Chercher.TabIndex = 5;
            this.btn_Chercher.Text = "Chercher un fournisseur";
            this.btn_Chercher.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Chercher);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.lst_Fournisseurs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Liste de fournisseurs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem chargerUnFichierToolStripMenuItem;
        private ListBox lst_Fournisseurs;
        private Button btn_Creer;
        private Button btn_Modifier;
        private Button btn_Supprimer;
        private Button btn_Chercher;
    }
}