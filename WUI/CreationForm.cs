using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;

namespace WUI
{
    public partial class CreationForm : Form
    {
        /// <summary>
        /// Liste des TextBoxs au sein de cette form. Est initialisé lors du chargement de cette form.
        /// </summary>
        IList<TextBox> TextBoxList = new List<TextBox>();
        public CreationForm()
        {
            InitializeComponent();
        }

        private void btn_fin_crer_Click(object sender, EventArgs e)
        {
            bool CanCreate = true;
            bool CanClose = true;
            bool Command = true;
            if(rdb_oui.Checked)
            {
                Command = true;
            }
            else if(rdb_non.Checked)
            {
                Command = false;
            }

            foreach(TextBox Box in TextBoxList)
            {
                if(!DataCheck.TextBoxHasText(Box.Text))
                {
                    CanCreate = false;
                }
            }

            if(!int.TryParse(txt_codePostal_du_fournisseur.Text, out int Result))
            {
                CanCreate = false;
            }

            if (CanCreate)
            {
                Fournisseur NewFurnisher = new Fournisseur(0, txt_nom_du_fournisseur.Text, txt_Email_du_fournisseur.Text,
                    txt_adresse_du_fournisseur.Text, txt_ville_du_fournisseur.Text, int.Parse(txt_codePostal_du_fournisseur.Text), txt_pays_du_fournisseur.Text,
                    Command, DateTime.Now);

                if(!NewFurnisher.HasANameMinOfThreeChar())
                {
                    CanClose = false;
                    MessageBox.Show("Le nom du fournisseur doit contenir au moins 3 lettres. Veuillez modifier le nom du fournisseur.");
                }

                if(!NewFurnisher.HasAValidEMail())
                {
                    CanClose = false;
                    MessageBox.Show("L'adresse e-amil du fournisseur n'a pas un format valide. Veuillez corrigier l'adresse e-amil du fournisseur.");
                }

                if (CanClose)
                {
                    SpecificData.SetLastID(SpecificData.GetLastID() + 1);
                    NewFurnisher.SetNewID(SpecificData.GetLastID());
                    SpecificData.AddFurnisher(NewFurnisher);
                    this.Close();
                }
            }
            else
            {
                    MessageBox.Show("Au moins un champ est manquant. Veuillez vérifier les informations saisies et remplir tous les champs.");
                if (!int.TryParse(txt_codePostal_du_fournisseur.Text, out int result))
                {
                    MessageBox.Show("Le champ du code postal ne peut contenir que des nombres. Veuillez modifier correctement le champ du code postal.");
                }
            }
        }

        private void CreationForm_Load(object sender, EventArgs e)
        {
            TextBoxList.Add(txt_adresse_du_fournisseur);
            TextBoxList.Add(txt_codePostal_du_fournisseur);
            TextBoxList.Add(txt_Email_du_fournisseur);
            TextBoxList.Add(txt_nom_du_fournisseur);
            TextBoxList.Add(txt_pays_du_fournisseur);
            TextBoxList.Add(txt_ville_du_fournisseur);
            rdb_oui.Checked = true;
        }
    }
}
