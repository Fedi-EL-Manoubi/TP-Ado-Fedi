using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class GenreManager
    {
        //private MySqlCommand _command;
        //private MySqlDataReader _reader;

        static public Genre FindOnReader(MySqlDataReader _reader)
        {
            Genre genre = new Genre();
            genre.Num = Convert.ToInt16(_reader["num"]);
            genre.Libelle = _reader["libelle"] == DBNull.Value ? "" : _reader["libelle"] as string;
            return genre;
        }

        static public List<Genre> FindAll()
        {
            MySqlCommand _command;
            MySqlDataReader _reader;
            List<Genre> list = new List<Genre>();

            Connection.Co.Open();
            _command = Connection.Co.CreateCommand();
            _command.CommandText = "SELECT * FROM genre ORDER BY libelle";
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Genre genre = GenreManager.FindOnReader( _reader );
                list.Add( genre );
            }

            _reader.Close();
            Connection.Co.Close();
            return list;
        }

        static public Genre FindById(int id)
        {
            return null;
        }

        static public bool AjouteGenre(Genre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "INSERT INTO genre (libelle) VALUES " +
                "(" +
                "@paramLib" +
                ")";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramLib", a.Libelle);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le genre n'a pas été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool ModifGenre(Genre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "UPDATE genre SET " +
                "libelle=@paramLib " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramLib", a.Libelle);
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le genre n'a pas été mis à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool SupprimeGenre(Genre a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "DELETE FROM genre " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: le genre n'a pas été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
