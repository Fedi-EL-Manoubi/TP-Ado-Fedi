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
    public partial class FicheAuteur : Form
    {
        Auteur AuteurCourant = new Auteur();
        public FicheAuteur(bool modif, Auteur a = null)
        {
            InitializeComponent();
            try
            {
                if (a != null)
                {
                    AuteurCourant = a;
                }
                else AuteurCourant.Num = 0;
                bs_fiche.DataSource = AuteurCourant;
                if (!modif)
                {
                    txb_nom.Enabled = false;
                    txb_prenom.Enabled = false;
                    txb_natio.Enabled = false;
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

            if (AuteurCourant.Num == 0)
            {
                AuteurCourant = bs_fiche.Current as Auteur;
                bool res = AuteurManager.AjouteAuteur(AuteurCourant);
            }
            else
            {
                AuteurCourant = bs_fiche.Current as Auteur;
                bool res = AuteurManager.ModifAuteur(AuteurCourant);
            }
            this.Close();
        }

        private bool ControleSaisie()
        {
            return (string.IsNullOrWhiteSpace(txb_nom.Text));
        }
    }
}
