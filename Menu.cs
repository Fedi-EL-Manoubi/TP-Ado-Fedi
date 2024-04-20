using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPlivre
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeAuteur frm = new Form_listeAuteur();
            frm.ShowDialog();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeGenre frm = new Form_listeGenre();
            frm.ShowDialog();
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeLivre frm = new Form_listeLivre();
            frm.ShowDialog();
        }

        private void adhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeAdherent frm = new Form_listeAdherent();
            frm.ShowDialog();
        }
    }
}
