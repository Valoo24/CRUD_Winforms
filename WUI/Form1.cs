using Models;
using BLL;
using System.Text;

namespace WUI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void chargerUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FilePath;
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Ficher csv (*.csv)|*.csv";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
               SpecificData.SetFurnisherList(DataAccess.GetListfromFile(OFD.FileName));
               SpecificData.SetLastID(SpecificData.GetID(OFD.FileName));
            }
            foreach(Fournisseur fournisseur in SpecificData.GetFurnisherList())
            {
                lst_Fournisseurs.Items.Add(fournisseur);
            }
        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            using CreationForm creationForm = new CreationForm();
            creationForm.ShowDialog();
            lst_Fournisseurs.Items.Clear();
            foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
            {
                lst_Fournisseurs.Items.Add(fournisseur);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            lst_Fournisseurs.Items.Clear();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            SpecificData.SetSelectedFournisseur((Fournisseur)lst_Fournisseurs.SelectedItem);
            using ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
        }

        private void btn_reloadList_Click(object sender, EventArgs e)
        {
            lst_Fournisseurs.Items.Clear();
            foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
            {
                lst_Fournisseurs.Items.Add(fournisseur);
            }
        }

        private void btn_Chercher_Click(object sender, EventArgs e)
        {
            using SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
            lst_Fournisseurs.Items.Clear();
            if(!SpecificData.SearchListIsNull())
            {
                foreach (Fournisseur fournisseur in SpecificData.GetSearchedList())
                {
                    lst_Fournisseurs.Items.Add(fournisseur);
                }
            }
        }
    }
}