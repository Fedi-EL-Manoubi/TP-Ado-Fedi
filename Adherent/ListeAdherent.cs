using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using TPlivre.Entity;

namespace TPlivre
{
    public partial class Form_listeAdherent : Form
    {
        List<Entity.Adherent> auteurs = new List<Entity.Adherent>();

        public Form_listeAdherent()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                auteurs = AdherentManager.FindAll();
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
            dgv_ListeAdherent.Rows.Clear();
            RemplirListe();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            Adherent auteursel = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherent.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Adherent;
            if (auteursel != null)
            {
                FicheAdherent frm = new FicheAdherent(false, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Adherent auteursel = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherent.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Adherent;
            if (auteursel != null)
            {
                FicheAdherent frm = new FicheAdherent(true, auteursel);
                frm.ShowDialog();
            }
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ces données ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) { return; }
            Adherent auteursel = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherent.SelectedRows[0];
            auteursel = ligne.DataBoundItem as Adherent;
            AdherentManager.SupprimeAdherent(auteursel);
            Refresh();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Adherent auteur = new Adherent();
            FicheAdherent frm = new FicheAdherent(true);
            frm.ShowDialog();
            Refresh();
        }
    }
}