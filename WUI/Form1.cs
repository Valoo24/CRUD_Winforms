using Models;
using System.Text;

namespace WUI
{
    public partial class Main_Form : Form
    {
        public IList<Fournisseur> FourniseurList = new List<Fournisseur>();
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
                FilePath = OFD.FileName;
                string[] Content = File.ReadAllLines(FilePath, Encoding.UTF7);
                for(int i = 1; i < Content.GetLength(0); i++)
                {
                    FourniseurList.Add(new Fournisseur(Content[i]));
                    lst_Fournisseurs.Items.Add(FourniseurList[i - 1].ToString());
                }
            }
        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            lst_Fournisseurs.Items.Clear();
        }
    }
}