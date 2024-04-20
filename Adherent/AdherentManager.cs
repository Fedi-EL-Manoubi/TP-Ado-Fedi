using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class AdherentManager
    {
        //private MySqlCommand _command;
        //private MySqlDataReader _reader;

        static public Adherent FindOnReader(MySqlDataReader _reader)
        {
            Adherent adherent = new Adherent();
            adherent.Num = Convert.ToInt16(_reader["num"]);
            adherent.Nom = _reader["nom"] == DBNull.Value ? "" : _reader["nom"] as string;
            adherent.Prenom = _reader["prenom"] == DBNull.Value ? "" : _reader["prenom"] as string;
            adherent.AdrRue = _reader["adrRue"] == DBNull.Value ? "" : _reader["adrRue"] as string;
            adherent.AdrCP = _reader["adrCP"] == DBNull.Value ? 0 : Convert.ToInt32(_reader["adrCP"]);
            adherent.AdrVille = _reader["adrVille"] == DBNull.Value ? "" : _reader["adrVille"] as string;
            adherent.Tel = _reader["tel"] == DBNull.Value ? "" : _reader["tel"] as string;
            adherent.Mel = _reader["mel"] == DBNull.Value ? "" : _reader["mel"] as string;
            return adherent;
        }

        static public List<Adherent> FindAll()
        {
            MySqlCommand _command;
            MySqlDataReader _reader;
            List<Adherent> list = new List<Adherent>();

            Connection.Co.Open();
            _command = Connection.Co.CreateCommand();
            _command.CommandText = "SELECT * FROM adherent ORDER BY nom";
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Adherent adherent = AdherentManager.FindOnReader( _reader );
                list.Add( adherent );
            }

            _reader.Close();
            Connection.Co.Close();
            return list;
        }

        static public Adherent FindById(int id)
        {
            return null;
        }

        static public bool AjouteAdherent(Adherent a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "INSERT INTO adherent (nom, prenom, adrRue, adrCP, adrVille, tel, mel) VALUES " +
                "(" +
                "@paramNom," +
                "@paramPrenom," +
                "@paramAr," +
                "@paramACP," +
                "@paramAv," +
                "@paramTel," +
                "@paramMel" +
                ")";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNom", a.Nom);
            _command.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            _command.Parameters.AddWithValue("@paramAr", a.AdrRue);
            _command.Parameters.AddWithValue("@paramACP", a.AdrCP);
            _command.Parameters.AddWithValue("@paramAv", a.AdrVille);
            _command.Parameters.AddWithValue("@paramTel", a.Tel);
            _command.Parameters.AddWithValue("@paramMel", a.Mel);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'Adherent n'a pas été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool ModifAdherent(Adherent a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "UPDATE adherent SET " +
                "nom=@paramNom, " +
                "prenom=@paramPrenom, " +
                "adrRue=@paramAr, " +
                "adrCP=@paramACP, " +
                "adrVille=@paramAv, " +
                "tel=@paramTel, " +
                "mel=@paramMel " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNom", a.Nom);
            _command.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            _command.Parameters.AddWithValue("@paramAr", a.AdrRue);
            _command.Parameters.AddWithValue("@paramACP", a.AdrCP);
            _command.Parameters.AddWithValue("@paramAv", a.AdrVille);
            _command.Parameters.AddWithValue("@paramTel", a.Tel);
            _command.Parameters.AddWithValue("@paramMel", a.Mel);
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'Adherent n'a pas été mis à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool SupprimeAdherent(Adherent a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "DELETE FROM adherent " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'Adherent n'a pas été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
