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
        #region M�thodes du menu "Fichier"
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
            MessageBox.Show("Fichier Enregistr� avec succ�s !");
        }
        #endregion
        #region M�thodes des boutons du Main_Form
        private void btn_Creer_Click(object sender, EventArgs e)
        {
            using CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
            ReloadListDisplay();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            LoadData();
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
                MessageBox.Show("Vous n'avez s�lectionn� aucun fournisseur � modifier. Veuillez s�lectionner un fournisseur dans la liste" +
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
            if (lst_Fournisseurs.SelectedItem != null)
            {
                using ConfirmForm confirmForm = new ConfirmForm();
                confirmForm.ShowDialog();
                if (DataCheck.GetConfirmation())
                {
                    SpecificData.DeleteInFurnisherList(lst_Fournisseurs.SelectedIndex);
                    ReloadListDisplay();
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner un fournisseur dans la liste pour pouvoir r�aliser la suppression.");
            }
            DataCheck.SetConfirmTo(false);
        }
        private void sauvegarderLaListeDesExtensionsDadressesEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.SaveFile(TypeOfData.MailExtension);
            MessageBox.Show("Fichier enregistr� avec succ�s !");
        }
        #endregion
        #region M�thodes Custom
        /// <summary>
        /// Recharge la liste compl�te des fournisseurs.
        /// </summary>
        private void ReloadListDisplay()
        {
            lst_Fournisseurs.Items.Clear();
            foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
            {
                lst_Fournisseurs.Items.Add(fournisseur);
            }
        }
        /// <summary>
        /// Charge des donn�es selon leurs types.
        /// </summary>
        /// <param name="DataToLoad">Type de donn�es � charger.</param>
        private void LoadData(TypeOfData DataToLoad)
        {
            if (DataToLoad == TypeOfData.Fournisseur)
            {
                SpecificData.SetFurnisherList(DataAccess.GetFurnisherListfromFile(DataAccess.GetSavePath(DataToLoad)));
                SpecificData.SetLastID(SpecificData.GetIDFromFile(DataAccess.GetSavePath(DataToLoad)));
            }
        }
        /// <summary>
        /// Charge des donn�es selon le chemin d'acc�s � un fichier.
        /// </summary>
        /// <param name="FilePath">Chemin d'acc�s au fichier � charger.</param>
        private void LoadData(string FilePath)
        {
            SpecificData.SetFurnisherList(DataAccess.GetFurnisherListfromFile(FilePath));
            SpecificData.SetLastID(SpecificData.GetIDFromFile(FilePath));
        }
        /// <summary>
        /// Charge les donn�es depuis les fichiers de sauvegardes standards.
        /// </summary>
        private void LoadData()
        {
            SpecificData.SetFurnisherList(DataAccess.GetFurnisherListFromFile());
            SpecificData.SetLastID(SpecificData.GetLastID());
        }
        #endregion
    }
}