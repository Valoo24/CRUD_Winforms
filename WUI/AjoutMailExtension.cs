using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WUI
{
    public partial class AjoutMailExtension : Form
    {
        public AjoutMailExtension()
        {
            InitializeComponent();
        }

        private void btn_ajouter_mail_Click(object sender, EventArgs e)
        {
            if(DataCheck.TextBoxHasText(txt_Mail_Extension.Text))
            {
                MailExtension.AddToMailExtensonList(txt_Mail_Extension.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez rajouter une extension d'adresse e-mail à rajouter.");
            }
        }
    }
}
