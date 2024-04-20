using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPlivre.Entity;

namespace TPlivre
{
    public partial class FicheLivre : Form
    {
        Livre LivreCourant = new Livre();
        public FicheLivre(bool modif, Livre a = null)
        {
            InitializeComponent();
            try
            {
                if (a != null)
                {
                    LivreCourant = a;
                }
                else LivreCourant.Num = 0;
                bs_fiche.DataSource = LivreCourant;
                if (!modif)
                {
                    txb_isbn.Enabled = false;
                    txb_titre.Enabled = false;
                    txb_prix.Enabled = false;
                    txb_editeur.Enabled = false;
                    txb_annee.Enabled = false;
                    txb_langue.Enabled = false;
                    btn_submit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ControleSaisie())
            {
                MessageBox.Show("Veuillez saisir les données dans les champs indiqué d'un *");
                return;
            }

            if (LivreCourant.Num == 0)
            {
                LivreCourant = bs_fiche.Current as Livre;
                bool res = LivreManager.AjouteLivre(LivreCourant);
            }
            else
            {
                LivreCourant = bs_fiche.Current as Livre;
                bool res = LivreManager.ModifLivre(LivreCourant);
            }
            this.Close();
        }

        private bool ControleSaisie()
        {
            return (
                    string.IsNullOrWhiteSpace(txb_isbn.Text)
                    ||
                    string.IsNullOrWhiteSpace(txb_titre.Text)
                    );
        }
    }
}
