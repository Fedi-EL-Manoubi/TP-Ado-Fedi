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
    public partial class FicheAdherent : Form
    {
        Adherent AdherentCourant = new Adherent();
        public FicheAdherent(bool modif, Adherent a = null)
        {
            InitializeComponent();
            try
            {
                if (a != null)
                {
                    AdherentCourant = a;
                }
                else AdherentCourant.Num = 0;
                bs_fiche.DataSource = AdherentCourant;
                if (!modif)
                {
                    txb_nom.Enabled = false;
                    txb_prenom.Enabled = false;
                    txb_rue.Enabled = false;
                    txb_cp.Enabled = false;
                    txb_ville.Enabled = false;
                    txb_tel.Enabled = false;
                    txb_mel.Enabled = false;
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

            if (AdherentCourant.Num == 0)
            {
                AdherentCourant = bs_fiche.Current as Adherent;
                bool res = AdherentManager.AjouteAdherent(AdherentCourant);
            }
            else
            {
                AdherentCourant = bs_fiche.Current as Adherent;
                bool res = AdherentManager.ModifAdherent(AdherentCourant);
            }
            this.Close();
        }

        private bool ControleSaisie()
        {
            return (
                    string.IsNullOrWhiteSpace(txb_nom.Text)
                    ||
                    string.IsNullOrWhiteSpace(txb_prenom.Text)
                    );
        }
    }
}
