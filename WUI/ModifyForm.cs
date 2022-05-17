using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUI
{
    public partial class ModifyForm : Form
    {
        /// <summary>
        /// ID du fournisseur sélectionné. Initialisé à 0 par défaut.
        /// </summary>
        int SelectedID = 0;
        /// <summary>
        /// Liste de toutes les TextBoxs au sein de cette form. Est initialisé lors du chargement de cette form.
        /// </summary>
        IList<TextBox> TextBoxList = new List<TextBox>();
        Fournisseur SelectedFurnisher = SpecificData.GetSelectedFournisseur();
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            TextBoxList.Add(txt_nom_du_fournisseur);
            TextBoxList.Add(txt_email_du_fournisseur);
            TextBoxList.Add(txt_adresse_du_fournisseur);
            TextBoxList.Add(txt_ville_du_fournisseur);
            TextBoxList.Add(txt_Code_Postal_du_fournisseur);
            TextBoxList.Add(txt_pays_du_fournisseur);
            SelectedID = SelectedFurnisher.Id;
            txt_nom_du_fournisseur.Text = SelectedFurnisher.Name;
            txt_adresse_du_fournisseur.Text = SelectedFurnisher.Street;
            txt_Code_Postal_du_fournisseur.Text = $"{SelectedFurnisher.PostCode}";
            txt_email_du_fournisseur.Text = SelectedFurnisher.Email;
            txt_pays_du_fournisseur.Text = SelectedFurnisher.Country;
            txt_ville_du_fournisseur.Text = SelectedFurnisher.City;
            if(SelectedFurnisher.IsWaitingForCommand)
            {
                rdb_oui.Checked = true;
            }
            else if(!SelectedFurnisher.IsWaitingForCommand)
            {
                rdb_non.Checked = true;
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            bool CanModify = true;
            bool CanClose = true;
            bool ModifiedFurnisherIsWaiting = true;
            if(rdb_oui.Checked)
            {
                ModifiedFurnisherIsWaiting = true;
            }
            else if(rdb_non.Checked)
            {
                ModifiedFurnisherIsWaiting = false;
            }

            foreach(TextBox Box in TextBoxList)
            {
                if (!DataCheck.TextBoxHasText(Box.Text))
                {
                    CanModify = false;
                }
            }

            if(!int.TryParse(txt_Code_Postal_du_fournisseur.Text, out int Result))
            {
                CanModify = false;
            }

            if (CanModify)
            {
                Fournisseur ModifiedFurnisher = new Fournisseur(SelectedID, txt_nom_du_fournisseur.Text, txt_email_du_fournisseur.Text,
                    txt_adresse_du_fournisseur.Text, txt_ville_du_fournisseur.Text, int.Parse(txt_Code_Postal_du_fournisseur.Text),
                    txt_pays_du_fournisseur.Text, ModifiedFurnisherIsWaiting, (DateTime)SelectedFurnisher.CreationDate);

                if (!ModifiedFurnisher.HasANameMinOfThreeChar())
                {
                    CanClose = false;
                    MessageBox.Show("Le nom du fournisseur doit contenir au moins 3 lettres. Veuillez modifier le nom du fournisseur.");
                }

                if(!ModifiedFurnisher.HasAValidEMail())
                {
                    CanClose = false;
                    MessageBox.Show("L'adresse e-amil du fournisseur n'a pas un format valide. Veuillez corrigier l'adresse e-amil du fournisseur.");
                }

                if (CanClose)
                {
                    SpecificData.ModifyFurnisherList(ModifiedFurnisher);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Au moins un champ est manquant. Veuillez vérifier les informations saisies et remplir tous les champs.");
                if (!int.TryParse(txt_Code_Postal_du_fournisseur.Text, out int result))
                {
                    MessageBox.Show("Le champ du code postal ne peut contenir que des nombres. Veuillez modifier correctement le champ du code postal.");
                }
            }
        }
    }
}
