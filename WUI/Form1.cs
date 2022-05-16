using Models;
using BLL;
using System;
using System.Text;
using System.IO;

namespace WUI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        #region Méthodes du menu "Fichier"
        private void chargerUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FilePath;
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Ficher csv (*.csv)|*.csv";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                LoadData(OFD.FileName);
            }
            ReloadListDisplay();
        }

        private void sauvegarderLaListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.SaveFile(TypeOfData.Fournisseur);
            MessageBox.Show("Fichier Enregistré avec succès !");
        }
        #endregion
        #region Méthodes des boutons du Main_Form
        private void btn_Creer_Click(object sender, EventArgs e)
        {
            using CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
            ReloadListDisplay();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            LoadData(DataAccess.GetSavePath(TypeOfData.Fournisseur));
            ReloadListDisplay();
            MailExtension.AddToMailExtensonList("com");
            MailExtension.AddToMailExtensonList("fr");
            MailExtension.AddToMailExtensonList("be");
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (lst_Fournisseurs.SelectedItem != null)
            {
                SpecificData.SetSelectedFournisseur((Fournisseur)lst_Fournisseurs.SelectedItem);
                using ModifyForm modifyForm = new ModifyForm();
                modifyForm.ShowDialog();
                ReloadListDisplay();
            }
            else
            {
                MessageBox.Show("Vous n'avez sélectionné aucun fournisseur à modifier. Veuillez sélectionner un fournisseur dans la liste" +
                    " pour le modifier.");
            }
        }

        private void btn_reloadList_Click(object sender, EventArgs e)
        {
            ReloadListDisplay();
        }

        private void btn_Chercher_Click(object sender, EventArgs e)
        {
            using SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
            if(!SpecificData.SearchListIsNull())
            {
                lst_Fournisseurs.Items.Clear();
                foreach (Fournisseur fournisseur in SpecificData.GetSearchedList())
                {
                    lst_Fournisseurs.Items.Add(fournisseur);
                }
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
                SpecificData.DeleteInFurnisherList((Fournisseur)lst_Fournisseurs.SelectedItem);
                ReloadListDisplay();
        }
        #endregion
        #region Méthodes Custom
        private void ReloadListDisplay()
        {
            lst_Fournisseurs.Items.Clear();
            foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
            {
                lst_Fournisseurs.Items.Add(fournisseur);
            }
        }
        private void LoadData(string FilePath)
        {
            SpecificData.SetFurnisherList(DataAccess.GetListfromFile(FilePath));
            SpecificData.SetLastID(SpecificData.GetIDFromFile(FilePath));
        }
        #endregion
    }
}