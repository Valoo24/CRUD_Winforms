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
        public CreationForm()
        {
            InitializeComponent();
        }

        private void btn_fin_crer_Click(object sender, EventArgs e)
        {
            bool Command = true;
            int NewID = SpecificData.GetLastID();
            NewID++;
            SpecificData.SetLastID(NewID);
            if(rdb_oui.Checked)
            {
                Command = true;
            }
            else if(rdb_non.Checked)
            {
                Command = false;
            }
            Fournisseur NewFurnisher = new Fournisseur(NewID, txt_nom_du_fournisseur.Text, txt_Email_du_fournisseur.Text,
                txt_adresse_du_fournisseur.Text, txt_ville_du_fournisseur.Text, int.Parse(txt_codePostal_du_fournisseur.Text), txt_pays_du_fournisseur.Text, 
                Command);
            SpecificData.AddFurnisher(NewFurnisher);
            this.Close();
        }
    }
}
