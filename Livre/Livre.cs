using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class Livre
    {
        private int num;
        private string isbn = "";
        private string titre = "";
        private decimal prix = 0;
        private string editeur = "";
        private int annee;
        private string langue = "";

        public int Num { get => num; set => num = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titre { get => titre; set => titre = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public int Annee { get => annee; set => annee = value; }
        public string Langue { get => langue; set => langue = value; }

        public Livre() { }
        public Livre(string i, string t, decimal p, string e, int a, string l) 
        {
            Isbn = i;
            Titre = t;
            Editeur = e;
            Annee = a;
            Langue = l;
            Prix = p;
        }
    }
}
