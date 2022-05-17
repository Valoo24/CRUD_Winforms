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
            this.sauvegarderLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_Fournisseurs = new System.Windows.Forms.ListBox();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Chercher = new System.Windows.Forms.Button();
            this.btn_reloadList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.éditionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(122, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUnFichierToolStripMenuItem,
            this.sauvegarderLaListeToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerUnFichierToolStripMenuItem
            // 
            this.chargerUnFichierToolStripMenuItem.Name = "chargerUnFichierToolStripMenuItem";
            this.chargerUnFichierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.chargerUnFichierToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.chargerUnFichierToolStripMenuItem.Text = "Charger un fichier fournisseur (.csv)";
            this.chargerUnFichierToolStripMenuItem.Click += new System.EventHandler(this.chargerUnFichierToolStripMenuItem_Click);
            // 
            // sauvegarderLaListeToolStripMenuItem
            // 
            this.sauvegarderLaListeToolStripMenuItem.Name = "sauvegarderLaListeToolStripMenuItem";
            this.sauvegarderLaListeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderLaListeToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.sauvegarderLaListeToolStripMenuItem.Text = "Sauvegarder la liste de fournisseurs";
            this.sauvegarderLaListeToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLaListeToolStripMenuItem_Click);
            // 
            // éditionToolStripMenuItem
            // 
            this.éditionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem,
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem});
            this.éditionToolStripMenuItem.Name = "éditionToolStripMenuItem";
            this.éditionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.éditionToolStripMenuItem.Text = "Édition";
            // 
            // modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem
            // 
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem.Name = "modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem";
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem.Size = new System.Drawing.Size(349, 22);
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem.Text = "Ajouter une extension d\'adresse e-mail";
            this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem.Click += new System.EventHandler(this.modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem_Click);
            // 
            // sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem
            // 
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem.Name = "sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem";
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem.Size = new System.Drawing.Size(389, 22);
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem.Text = "Sauvegarder la liste des Extensions d\'adresses e-mail";
            this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem_Click);
            // 
            // lst_Fournisseurs
            // 
            this.lst_Fournisseurs.FormattingEnabled = true;
            this.lst_Fournisseurs.ItemHeight = 15;
            this.lst_Fournisseurs.Location = new System.Drawing.Point(12, 24);
            this.lst_Fournisseurs.Name = "lst_Fournisseurs";
            this.lst_Fournisseurs.Size = new System.Drawing.Size(1184, 394);
            this.lst_Fournisseurs.TabIndex = 1;
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(12, 426);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(232, 23);
            this.btn_Creer.TabIndex = 2;
            this.btn_Creer.Text = "Ajouter un fournisseur";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(726, 426);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(232, 23);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier un fournisseur";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(964, 426);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(232, 23);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer un fournisseur";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Chercher
            // 
            this.btn_Chercher.Location = new System.Drawing.Point(250, 426);
            this.btn_Chercher.Name = "btn_Chercher";
            this.btn_Chercher.Size = new System.Drawing.Size(232, 23);
            this.btn_Chercher.TabIndex = 5;
            this.btn_Chercher.Text = "Chercher un fournisseur";
            this.btn_Chercher.UseVisualStyleBackColor = true;
            this.btn_Chercher.Click += new System.EventHandler(this.btn_Chercher_Click);
            // 
            // btn_reloadList
            // 
            this.btn_reloadList.Location = new System.Drawing.Point(488, 426);
            this.btn_reloadList.Name = "btn_reloadList";
            this.btn_reloadList.Size = new System.Drawing.Size(232, 23);
            this.btn_reloadList.TabIndex = 6;
            this.btn_reloadList.Text = "Recharger la liste";
            this.btn_reloadList.UseVisualStyleBackColor = true;
            this.btn_reloadList.Click += new System.EventHandler(this.btn_reloadList_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 461);
            this.Controls.Add(this.btn_reloadList);
            this.Controls.Add(this.btn_Chercher);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.lst_Fournisseurs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Liste de fournisseurs";
            this.Load += new System.EventHandler(this.Main_Form_Load);
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
        private ToolStripMenuItem sauvegarderLaListeToolStripMenuItem;
        private Button btn_reloadList;
        private ToolStripMenuItem éditionToolStripMenuItem;
        private ToolStripMenuItem modifierLaListeDesExtensionsDadressesEmailToolStripMenuItem;
        private ToolStripMenuItem sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem;
    }
}