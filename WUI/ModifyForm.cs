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
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            Fournisseur SelectedFurnisher = SpecificData.GetSelectedFournisseur();
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

        }
    }
}
