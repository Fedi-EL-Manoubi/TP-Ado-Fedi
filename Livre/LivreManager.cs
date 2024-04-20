using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class LivreManager
    {
        //private MySqlCommand _command;
        //private MySqlDataReader _reader;

        static public Livre FindOnReader(MySqlDataReader _reader)
        {
            Livre livre = new Livre();
            livre.Num = Convert.ToInt16(_reader["num"]);
            livre.Isbn = _reader["ISBN"] == DBNull.Value ? "" : _reader["ISBN"] as string;
            livre.Titre = _reader["titre"] == DBNull.Value ? "" : _reader["titre"] as string;
            livre.Prix = _reader["prix"] == DBNull.Value ? 0 : Convert.ToDecimal(_reader["prix"]);
            livre.Editeur = _reader["editeur"] == DBNull.Value ? "" : _reader["editeur"] as string;
            livre.Annee = _reader["annee"] == DBNull.Value ? 0 : Convert.ToInt16(_reader["annee"]);
            livre.Langue = _reader["langue"] == DBNull.Value ? "" : _reader["langue"] as string;
            return livre;
        }

        static public List<Livre> FindAll()
        {
            MySqlCommand _command;
            MySqlDataReader _reader;
            List<Livre> list = new List<Livre>();

            Connection.Co.Open();
            _command = Connection.Co.CreateCommand();
            _command.CommandText = "SELECT * FROM livre ORDER BY titre";
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Livre livre = LivreManager.FindOnReader( _reader );
                list.Add( livre );
            }

            _reader.Close();
            Connection.Co.Close();
            return list;
        }

        static public Livre FindById(int id)
        {
            return null;
        }

        static public bool AjouteLivre(Livre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "INSERT INTO livre (ISBN, titre, prix, editeur, annee, langue) VALUES " +
                "(" +
                "@paramIsbn," +
                "@paramTitre," +
                "@paramPrix," +
                "@paramEdit," +
                "@paramAnnee," +
                "@paramLangue" +
                ")";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramIsbn", a.Isbn);
            _command.Parameters.AddWithValue("@paramTitre", a.Titre);
            _command.Parameters.AddWithValue("@paramPrix", a.Prix);
            _command.Parameters.AddWithValue("@paramEdit", a.Editeur);
            _command.Parameters.AddWithValue("@paramAnnee", a.Annee);
            _command.Parameters.AddWithValue("@paramLangue", a.Langue);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le livre n'a pas été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool ModifLivre(Livre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "UPDATE livre SET " +
                "isbn=@paramIsbn, " +
                "titre=@paramTitre, " +
                "prix=@paramPrix, " +
                "editeur=@paramEdit, " +
                "annee=@paramAnnee, " +
                "langue=@paramLangue " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramIsbn", a.Isbn);
            _command.Parameters.AddWithValue("@paramTitre", a.Titre);
            _command.Parameters.AddWithValue("@paramPrix", a.Prix);
            _command.Parameters.AddWithValue("@paramEdit", a.Editeur);
            _command.Parameters.AddWithValue("@paramAnnee", a.Annee);
            _command.Parameters.AddWithValue("@paramLangue", a.Langue);
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le livre n'a pas été mis à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool SupprimeLivre(Livre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "DELETE FROM livre " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le livre n'a pas été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
