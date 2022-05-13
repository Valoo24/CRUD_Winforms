using System;
using Models;
using BLL;
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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            IList<Fournisseur> FurnisherFound = new List<Fournisseur>();

            if(cmb_searchChoice.Text == SearchType.ID.ToString())
            {
                foreach(Fournisseur fournisseur in SpecificData.GetFurnisherList())
                {
                    if(fournisseur.Id == int.Parse(txt_search.Text))
                    {
                        FurnisherFound.Add(fournisseur);
                    }
                }
            }
            else if(cmb_searchChoice.Text == SearchType.Nom.ToString())
            {
                foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
                {
                    if (fournisseur.Name == txt_search.Text)
                    {
                        FurnisherFound.Add(fournisseur);
                    }
                }
            }
            else if(cmb_searchChoice.Text == SearchType.Pays.ToString())
            {
                foreach (Fournisseur fournisseur in SpecificData.GetFurnisherList())
                {
                    if (fournisseur.Country == txt_search.Text)
                    {
                        FurnisherFound.Add(fournisseur);
                    }
                }
            }

            if (FurnisherFound.Count == 0)
            {
                MessageBox.Show("Aucun fournisseur correspondant à votre recherche n'a été trouvé.");
            }
            else
            {
                SpecificData.SetSearchedList(FurnisherFound);
            }

            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmb_searchChoice.Items.Clear();
            cmb_searchChoice.Items.Add(SearchType.ID);
            cmb_searchChoice.Items.Add(SearchType.Nom);
            cmb_searchChoice.Items.Add(SearchType.Pays);
        }
    }
}
