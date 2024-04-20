using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using TPlivre.Entity;

namespace TPlivre
{
    public partial class Form_listeAuteur : Form
    {
        List<Entity.Auteur> auteurs = new List<Entity.Auteur>();

        public Form_listeAuteur()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                auteurs = AuteurManager.FindAll();
                bs_table.DataSource = auteurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }
            finally
            {
            }
        }

        private void Refresh()
        {
            dgv_ListeAuteur.Rows.Clear();
            RemplirListe();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Auteur auteursel = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteur.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Auteur;
            if (auteursel != null)
            {
                FicheAuteur frm = new FicheAuteur(false, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Auteur auteursel = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteur.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Auteur;
            if (auteursel != null)
            {
                FicheAuteur frm = new FicheAuteur(true, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) { return; }
            Auteur auteursel = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteur.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Auteur;
            AuteurManager.SupprimeAuteur(auteursel);
            Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Auteur auteur = new Auteur();
            FicheAuteur frm = new FicheAuteur(true);
            frm.ShowDialog();
            Refresh();
        }
    }
}