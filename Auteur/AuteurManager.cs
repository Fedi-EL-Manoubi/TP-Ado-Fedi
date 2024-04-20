using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre.Entity
{
    public class AuteurManager
    {
        //private MySqlCommand _command;
        //private MySqlDataReader _reader;

        static public Auteur FindOnReader(MySqlDataReader _reader)
        {
            Auteur auteur = new Auteur();
            auteur.Num = Convert.ToInt16(_reader["num"]);
            auteur.Nom = _reader["nom"] == DBNull.Value ? "" : _reader["nom"] as string;
            auteur.Prenom = _reader["prenom"] == DBNull.Value ? "" : _reader["prenom"] as string;
            auteur.Nationalite = _reader["nationalite"] == DBNull.Value ? "" : _reader["nationalite"] as string;
            return auteur;
        }

        static public List<Auteur> FindAll()
        {
            MySqlCommand _command;
            MySqlDataReader _reader;
            List<Auteur> list = new List<Auteur>();

            Connection.Co.Open();
            _command = Connection.Co.CreateCommand();
            _command.CommandText = "SELECT * FROM auteur ORDER BY nom";
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Auteur auteur = AuteurManager.FindOnReader( _reader );
                list.Add( auteur );
            }

            _reader.Close();
            Connection.Co.Close();
            return list;
        }

        static public Auteur FindById(int id)
        {
            return null;
        }

        static public bool AjouteAuteur(Auteur a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "INSERT INTO auteur (nom, prenom, nationalite) VALUES " +
                "(" +
                "@paramNom," +
                "@paramPrenom," +
                "@paramNationalite" +
                ")";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNom", a.Nom);
            _command.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            _command.Parameters.AddWithValue("@paramNationalite", a.Nationalite);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'auteur n'a pas été ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool ModifAuteur(Auteur a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "UPDATE auteur SET " +
                "nom=@paramNom, " +
                "prenom=@paramPrenom, " +
                "nationalite=@paramNationalite " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNom", a.Nom);
            _command.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            _command.Parameters.AddWithValue("@paramNationalite", a.Nationalite);
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'auteur n'a pas été mis à jour");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        static public bool SupprimeAuteur(Auteur a)
        {
            MySqlCommand _command = Connection.Co.CreateCommand();
            _command.CommandText = "DELETE FROM auteur " +
                "WHERE num=@paramNum";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.Co.Open();
                int res = _command.ExecuteNonQuery();
                Connection.Co.Close();

                if (res > 0) return true;
                else throw new Exception("Erreur: l'auteur n'a pas été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
