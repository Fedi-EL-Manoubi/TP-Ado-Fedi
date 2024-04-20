using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using TPlivre.Entity;

namespace TPlivre
{
    public partial class Form_listeLivre : Form
    {
        List<Entity.Livre> auteurs = new List<Entity.Livre>();

        public Form_listeLivre()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                auteurs = LivreManager.FindAll();
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
            dgv_ListeLivre.Rows.Clear();
            RemplirListe();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Livre auteursel = new Livre();
            DataGridViewRow ligne = dgv_ListeLivre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Livre;
            if (auteursel != null)
            {
                FicheLivre frm = new FicheLivre(false, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Livre auteursel = new Livre();
            DataGridViewRow ligne = dgv_ListeLivre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Livre;
            if (auteursel != null)
            {
                FicheLivre frm = new FicheLivre(true, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) { return; }
            Livre auteursel = new Livre();
            DataGridViewRow ligne = dgv_ListeLivre.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Livre;
            LivreManager.SupprimeLivre(auteursel);
            Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Livre auteur = new Livre();
            FicheLivre frm = new FicheLivre(true);
            frm.ShowDialog();
            Refresh();
        }
    }
}