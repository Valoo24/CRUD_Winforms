namespace WUI
{
    partial class AjoutMailExtension
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
            this.txt_Mail_Extension = new System.Windows.Forms.TextBox();
            this.btn_ajouter_mail = new System.Windows.Forms.Button();
            this.lbl_point = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Mail_Extension
            // 
            this.txt_Mail_Extension.Location = new System.Drawing.Point(22, 12);
            this.txt_Mail_Extension.Name = "txt_Mail_Extension";
            this.txt_Mail_Extension.Size = new System.Drawing.Size(126, 23);
            this.txt_Mail_Extension.TabIndex = 0;
            // 
            // btn_ajouter_mail
            // 
            this.btn_ajouter_mail.Location = new System.Drawing.Point(12, 41);
            this.btn_ajouter_mail.Name = "btn_ajouter_mail";
            this.btn_ajouter_mail.Size = new System.Drawing.Size(136, 23);
            this.btn_ajouter_mail.TabIndex = 1;
            this.btn_ajouter_mail.Text = "Ajouter";
            this.btn_ajouter_mail.UseVisualStyleBackColor = true;
            this.btn_ajouter_mail.Click += new System.EventHandler(this.btn_ajouter_mail_Click);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Location = new System.Drawing.Point(12, 20);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(10, 15);
            this.lbl_point.TabIndex = 2;
            this.lbl_point.Text = ".";
            // 
            // AjoutMailExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 76);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.btn_ajouter_mail);
            this.Controls.Add(this.txt_Mail_Extension);
            this.Name = "AjoutMailExtension";
            this.Text = "Ajout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Mail_Extension;
        private Button btn_ajouter_mail;
        private Label lbl_point;
    }
}