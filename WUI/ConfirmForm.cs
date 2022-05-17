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

namespace WUI
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataCheck.SetConfirmTo(true);
            this.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            DataCheck.SetConfirmTo(false);
            this.Close();
        }
    }
}
