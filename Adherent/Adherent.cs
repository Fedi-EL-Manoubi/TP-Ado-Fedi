using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class Adherent
    {
        private int num;
        private string nom = "";
        private string prenom = "";
        private string adrRue = "";
        private int adrCP;
        private string adrVille = "";
        private string tel = "";
        private string mel = "";

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string AdrRue { get => adrRue; set => adrRue = value; }
        public int AdrCP { get => adrCP; set => adrCP = value; }
        public string AdrVille { get => adrVille; set => adrVille = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mel { get => mel; set => mel = value; }

        public Adherent() { }
        public Adherent(string no, string p, string ar, int cp, string av, string t, string m) 
        {
            Nom = no;
            Prenom = p;
            AdrRue = ar;
            Tel = t;
            Mel = m;
            AdrVille = av;
            AdrCP = cp;
        }
    }
}
