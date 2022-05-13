namespace WUI
{
    partial class SearchForm
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
            this.cmb_searchChoice = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_recherche = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_searchChoice
            // 
            this.cmb_searchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_searchChoice.FormattingEnabled = true;
            this.cmb_searchChoice.Items.AddRange(new object[] {
            "ID",
            "Nom",
            "Code Postal",
            "Pays"});
            this.cmb_searchChoice.Location = new System.Drawing.Point(12, 28);
            this.cmb_searchChoice.Name = "cmb_searchChoice";
            this.cmb_searchChoice.Size = new System.Drawing.Size(121, 23);
            this.cmb_searchChoice.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(139, 28);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(247, 23);
            this.txt_search.TabIndex = 1;
            // 
            // lbl_recherche
            // 
            this.lbl_recherche.AutoSize = true;
            this.lbl_recherche.Location = new System.Drawing.Point(12, 9);
            this.lbl_recherche.Name = "lbl_recherche";
            this.lbl_recherche.Size = new System.Drawing.Size(85, 15);
            this.lbl_recherche.TabIndex = 2;
            this.lbl_recherche.Text = "Recherche par:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 57);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(374, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Chercher le fournisseur";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 93);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_recherche);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cmb_searchChoice);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_searchChoice;
        private TextBox txt_search;
        private Label lbl_recherche;
        private Button btn_search;
    }
}