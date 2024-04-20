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
    public partial class FicheGenre : Form
    {
        Genre GenreCourant = new Genre();
        public FicheGenre(bool modif, Genre a = null)
        {
            InitializeComponent();
            try
            {
                if (a != null)
                {
                    GenreCourant = a;
                }
                else GenreCourant.Num = 0;
                bs_fiche.DataSource = GenreCourant;
                if (!modif)
                {
                    txb_lib.Enabled = false;
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

            if (GenreCourant.Num == 0)
            {
                GenreCourant = bs_fiche.Current as Genre;
                bool res = GenreManager.AjouteGenre(GenreCourant);
            }
            else
            {
                GenreCourant = bs_fiche.Current as Genre;
                bool res = GenreManager.ModifGenre(GenreCourant);
            }
            this.Close();
        }

        private bool ControleSaisie()
        {
            return (string.IsNullOrWhiteSpace(txb_lib.Text));
        }
    }
}
