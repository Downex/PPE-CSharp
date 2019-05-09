using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_jeux;

namespace WindowsForm.Class_gestion
{
    public static class Bdd
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        //Selection allUtilisateur
        public static List<Utilisateur> SelectAllUser()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Utilisateur ORDER BY score";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Utilisateur utilisateur = new Utilisateur
                                {
                                    Id = reader["id"].ToString(),
                                    Login = reader["login"].ToString(),
                                    Password = reader["password"].ToString(),
                                    Prenom = reader["prenom"].ToString(),
                                    Nom = reader["nom"].ToString(),
                                    Score = reader["score"].ToString(),
                                    Rang = reader["rang"].ToString(),
                                    IsAdmin = reader["isAdmin"].ToString()
                                };
                                utilisateurs.Add(utilisateur);
                            }
                        }
                    }
                }
            }
            return utilisateurs;
        }

        //Insertion utilisateur
        public static void InsertUtilisateur(string login, string password, string prenom, string nom, string isAdmin)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Utilisateur (login, password, prenom, nom, score, rang, isAdmin) VALUES (@Login, @Password, @Prenom, @Nom, @Score, @Rang, @IsAdmin)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Login", login));
                        command.Parameters.Add(new SqlParameter("@Password", Utilisateur.Hash256(password)));
                        command.Parameters.Add(new SqlParameter("@Prenom", prenom));
                        command.Parameters.Add(new SqlParameter("@Nom", nom));
                        command.Parameters.Add(new SqlParameter("@Score", "0"));
                        command.Parameters.Add(new SqlParameter("@Rang", "Novice"));
                        command.Parameters.Add(new SqlParameter("@IsAdmin", isAdmin));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Supprime un utilisateur
        public static void DeleteUtilisateur(string idUtilisateur)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Utilisateur WHERE id = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public static void UpdateUtilisateur(string idUtilisateur, string prenom, string nom, string score, string isAdmin)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur SET prenom = @Prenom, nom = @Nom, score = @Score, isAdmin = @IsAdmin WHERE id = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Prenom", prenom));
                        command.Parameters.Add(new SqlParameter("@Nom", nom));
                        command.Parameters.Add(new SqlParameter("@Score", Convert.ToInt32(score)));
                        command.Parameters.Add(new SqlParameter("@IsAdmin", Convert.ToInt32(isAdmin)));
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Utilisateur mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static void UpdateMotdePasse(string idUtilisateur, string motDePasse)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur SET password = @MotDePasse WHERE id = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MotDePasse", motDePasse));
                        command.Parameters.Add(new SqlParameter("@IdUtilisateur", Convert.ToInt32(idUtilisateur)));
                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static List<Question> SelectAllQuestion()
        {
            List<Question> questions = new List<Question>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Question";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Question question = new Question
                                {
                                    Id = reader["id"].ToString(),
                                    Libelle = reader["libelle"].ToString(),
                                    Type = reader["type"].ToString()
                                };
                                questions.Add(question);
                            }
                        }
                    }
                }
            }
            return questions;
        }
    }


}
