using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using TPlivre.Entity;

namespace TPlivre
{
    public partial class Form_listeGenre : Form
    {
        List<Entity.Genre> auteurs = new List<Entity.Genre>();

        public Form_listeGenre()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                auteurs = GenreManager.FindAll();
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
            dgv_ListeGenre.Rows.Clear();
            RemplirListe();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Genre auteursel = new Genre();
            DataGridViewRow ligne = dgv_ListeGenre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Genre;
            if (auteursel != null)
            {
                FicheGenre frm = new FicheGenre(false, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Genre auteursel = new Genre();
            DataGridViewRow ligne = dgv_ListeGenre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Genre;
            if (auteursel != null)
            {
                FicheGenre frm = new FicheGenre(true, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) { return; }
            Genre auteursel = new Genre();
            DataGridViewRow ligne = dgv_ListeGenre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Genre;
            GenreManager.SupprimeGenre(auteursel);
            Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Genre auteur = new Genre();
            FicheGenre frm = new FicheGenre(true);
            frm.ShowDialog();
            Refresh();
        }
    }
}