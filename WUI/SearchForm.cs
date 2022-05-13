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

            if(cmb_searchChoice.Text == "ID")
            {
                foreach(Fournisseur fournisseur in SpecificData.GetFurnisherList())
                {
                    if(fournisseur.Id == int.Parse(txt_search.Text))
                    {
                        FurnisherFound.Add(fournisseur);
                    }
                }
            }

            SpecificData.SetSearchedList(FurnisherFound);

            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
