using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        /* --  Utilisateur  -- */
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
        /* FRANCOIS */
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
        //Modification utilisateur
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

        public static void UpdateScore(string idUtilisateur, string score)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Utilisateur SET score = @Score WHERE id = @IdUtilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Score", score));
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
        /* EndFrançois */
        /* --  Nom  -- */
        public static List<Mot> SelectAllNoms()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Nom ORDER BY singulier";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Nom nom = new Nom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                                lesMots.Add(nom);
                            }
                        }
                    }
                }
            }
            
            return lesMots;
        }

        public static List<Mot> SelectNomsByGenre(string genre)
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Nom WHERE genre=@genre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("genre", SqlDbType.VarChar).Value = genre;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Nom nom = new Nom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                                lesMots.Add(nom);
                            }
                        }
                    }
                }
            }
            return lesMots;
        }
        public static Nom SelectNomById(string id)
        {
            Nom nom = new Nom();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Nom WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nom = new Nom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return nom;
        }

        public static void InsertNom(string singulier, string pluriel, string genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Nom (singulier, pluriel, genre) VALUES (@singulier, @pluriel, @genre)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@singulier", singulier));
                        command.Parameters.Add(new SqlParameter("@pluriel", pluriel));
                        command.Parameters.Add(new SqlParameter("@genre", genre));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de ce nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Nom créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de ce nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        /* --  Adjectif  -- */
        public static List<Mot> SelectAllAdjectifs()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adjectif ORDER BY singMasculin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Adjectif adjectif = new Adjectif(
                                    reader["id"].ToString(),
                                    reader["singMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["plurMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["fonction"].ToString()
                                );
                                Console.WriteLine("ffff" + adjectif.singMasculin);
                                lesMots.Add(adjectif);
                            }
                        }
                    }
                }
            }

            return lesMots;
        }
        public static List<Mot> SelectAllAdjectifsByFonction(string fonction)
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adjectif WHERE fonction=@fonction";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("fonction", SqlDbType.VarChar).Value = fonction;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Adjectif adjectif = new Adjectif(
                                    reader["id"].ToString(),
                                    reader["singMasculin"].ToString(),
                                    reader["singFeminin"].ToString(),
                                    reader["plurMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["fonction"].ToString()
                                );
                                Console.WriteLine("ffff" + adjectif.singMasculin);
                                lesMots.Add(adjectif);
                            }
                        }
                    }
                }
            }

            return lesMots;
        }

        
        public static Adjectif SelectAdjectifById(string id)
        {
            Adjectif adj = new Adjectif();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adjectif WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                adj = new Adjectif(
                                    reader["id"].ToString(),
                                    reader["singMasculin"].ToString(),
                                    reader["singFeminin"].ToString(),
                                    reader["plurMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["fonction"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return adj;
        }

        public static Adjectif SelectAdjectifPossessif(string singMasculin)
        {
            Adjectif adj = new Adjectif();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adjectif WHERE fonction='possessif' AND singMasculin=@singMasculin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("singMasculin", SqlDbType.VarChar).Value = singMasculin;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                adj = new Adjectif(
                                    reader["id"].ToString(),
                                    reader["singMasculin"].ToString(),
                                    reader["singFeminin"].ToString(),
                                    reader["plurMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["fonction"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return adj;
        }

        public static Adjectif SelectAdjectifBySingMasculin(string singMasculin)
        {
            Adjectif adj = new Adjectif();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adjectif WHERE singMasculin=@singMasculin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("singMasculin", SqlDbType.VarChar).Value = singMasculin;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                adj = new Adjectif(
                                    reader["id"].ToString(),
                                    reader["singMasculin"].ToString(),
                                    reader["singFeminin"].ToString(),
                                    reader["plurMasculin"].ToString(),
                                    reader["plurFeminin"].ToString(),
                                    reader["fonction"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return adj;
        }

        public static void InsertAdjectif(string singMasculin, string singFeminin, string plurMasculin, string plurFeminin, string fonction)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Adjectif (singMasculin, singFeminin, plurMasculin, plurFeminin, fonction) VALUES (@singMasculin, @singFeminin, @plurMasculin, @plurFeminin, @fonction)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@singMasculin", singMasculin));
                        command.Parameters.Add(new SqlParameter("@singFeminin", singFeminin));
                        command.Parameters.Add(new SqlParameter("@plurMasculin", plurMasculin));
                        command.Parameters.Add(new SqlParameter("@plurFeminin", plurFeminin));
                        command.Parameters.Add(new SqlParameter("@fonction", fonction));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de cet adjectif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Adjectif créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de cet adjectif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        /* --  Pronom  -- */
        public static List<Mot> SelectAllPronoms()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Pronom ORDER BY singulier";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Pronom pronom = new Pronom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                                lesMots.Add(pronom);
                            }
                        }
                    }
                }
            }

            return lesMots;
        }

        public static Pronom SelectPronomBySingulier(string singulier)
        {
            Pronom pronom = new Pronom();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Pronom WHERE singulier=@singulier";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("singulier", SqlDbType.VarChar).Value = singulier;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pronom = new Pronom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return pronom;
        }

        public static Pronom SelectPronomById(string id)
        {
            Pronom pronom = new Pronom();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Pronom WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pronom = new Pronom(
                                    reader["id"].ToString(),
                                    reader["singulier"].ToString(),
                                    reader["pluriel"].ToString(),
                                    reader["genre"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return pronom;
        }

        public static void InsertPronom(string singulier, string pluriel, string genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Pronom (singulier, pluriel, genre) VALUES (@singulier, @pluriel, @genre)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@singulier", singulier));
                        command.Parameters.Add(new SqlParameter("@pluriel", Convert.ToInt32(pluriel)));
                        command.Parameters.Add(new SqlParameter("@genre", genre));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de ce pronom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Pronom créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de ce pronom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        /* --  Verbe  -- */
        public static List<Mot> SelectAllVerbes()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Verbe ORDER BY infinitif";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Verbe verbe = new Verbe(
                                    reader["id"].ToString(),
                                    reader["infinitif"].ToString(),
                                    reader["genre"].ToString()
                                );
                                lesMots.Add(verbe);
                            }
                        }
                    }
                }
            }

            return lesMots;
        }

        public static Verbe SelectVerbeById(string id)
        {
            Verbe verbe = new Verbe();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Verbe WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                verbe = new Verbe(
                                    reader["id"].ToString(),
                                    reader["infinitif"].ToString(),
                                    reader["genre"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return verbe;
        }

        public static void InsertVerbe(string infinitif, string genre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Verbe (infinitif, genre) VALUES (@infinitif, @genre)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@infinitif", infinitif));
                        command.Parameters.Add(new SqlParameter("@genre", genre));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de ce verbe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Verbe créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de ce verbe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static int GetLastIdVerbe()
        {

            string query;
            int resultat = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                query= @"SELECT IDENT_CURRENT('verbe')";
                SqlCommand command = new SqlCommand(query, connection);
                resultat = Convert.ToInt32(command.ExecuteScalar());
            }

            return resultat;
        }


        /* --  Conjugaison  -- */
        public static List<Conjugaison> SelectAllConjugaisons()
        {
            List<Conjugaison> lesConjugaisons = new List<Conjugaison>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Verbe ORDER BY infinitif";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Conjugaison conjugaison = new Conjugaison
                                {
                                    id = reader["id"].ToString(),
                                    temps = reader["temps"].ToString(),
                                    premierSing = reader["premierSing"].ToString(),
                                    deuxiemeSing = reader["deuxiemeSing"].ToString(),
                                    troisiemeSing = reader["troisiemeSing"].ToString(),
                                    premierPlur = reader["premierPlur"].ToString(),
                                    deuxiemePlur = reader["deuxiemePlur"].ToString(),
                                    troisiemePlur = reader["troisiemePlur"].ToString(),
                                    idVerbe = reader["idVerbe"].ToString()

                                };
                                lesConjugaisons.Add(conjugaison);
                            }
                        }
                    }
                }
            }
            return lesConjugaisons;
        }

        public static Conjugaison SelectConjugaisonById(string idVerbe)
        {
            Conjugaison conjugaison = new Conjugaison();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Conjugaison WHERE idVerbe=@idVerbe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("idVerbe", SqlDbType.VarChar).Value = idVerbe;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                conjugaison = new Conjugaison(
                                    reader["id"].ToString(),
                                    reader["temps"].ToString(),
                                    reader["premierSing"].ToString(),
                                    reader["deuxiemeSing"].ToString(),
                                    reader["troisiemeSing"].ToString(),
                                    reader["premierPlur"].ToString(),
                                    reader["deuxiemePlur"].ToString(),
                                    reader["troisiemePlur"].ToString(),
                                    reader["idVerbe"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return conjugaison;
        }

        public static Conjugaison SelectConjugaisonByVerbe(string idVerbe)
        {
            Conjugaison conjugaison = new Conjugaison();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Conjugaison WHERE idVerbe=@idVerbe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("idVerbe", SqlDbType.VarChar).Value = idVerbe;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                conjugaison = new Conjugaison
                                (
                                    reader["id"].ToString(),
                                    reader["temps"].ToString(),
                                    reader["premierSing"].ToString(),
                                    reader["deuxiemeSing"].ToString(),
                                    reader["troisiemeSing"].ToString(),
                                    reader["premierPlur"].ToString(),
                                    reader["deuxiemePlur"].ToString(),
                                    reader["troisiemePlur"].ToString(),
                                    reader["idVerbe"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return conjugaison;
        }

        public static void InsertConjugaison(string temps, string premierSing, string deuxiemeSing, string troisiemeSing, string premierPlur, string deuxiemePlur, string troisiemePlur, int idVerbe)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Conjugaison (temps, premierSing, deuxiemeSing, troisiemeSing, premierPlur, deuxiemePlur, troisiemePlur, idVerbe) VALUES (@temps, @premierSing, @deuxiemeSing, @troisiemeSing, @premierPlur, @deuxiemePlur, @troisiemePlur, @idVerbe)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@temps", temps));
                        command.Parameters.Add(new SqlParameter("@premierSing", premierSing));
                        command.Parameters.Add(new SqlParameter("@deuxiemeSing", deuxiemeSing));
                        command.Parameters.Add(new SqlParameter("@troisiemeSing", troisiemeSing));
                        command.Parameters.Add(new SqlParameter("@premierPlur", premierPlur));
                        command.Parameters.Add(new SqlParameter("@deuxiemePlur", deuxiemePlur));
                        command.Parameters.Add(new SqlParameter("@troisiemePlur", troisiemePlur));
                        command.Parameters.Add(new SqlParameter("@idVerbe", idVerbe));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de cette conjugaison.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Conjugaison créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de ce conjugaison.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /* -- Article -- */
        public static List<Mot> SelectAllArticles()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Article ORDER BY masculin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Article article = new Article
                                (
                                    reader["id"].ToString(),
                                    reader["masculin"].ToString(),
                                    reader["feminin"].ToString(),
                                    reader["pluriel"].ToString()

                                );
                                lesMots.Add(article);
                            }
                        }
                    }
                }
            }
            return lesMots;
        }
        
        public static Article SelectArticleById(string id)
        {
            Article article = new Article();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Article WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                article = new Article(
                                    reader["id"].ToString(),
                                    reader["masculin"].ToString(),
                                    reader["feminin"].ToString(),
                                    reader["pluriel"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return article;
        }

        public static void InsertArticle(string masculin, string feminin, string pluriel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Article (masculin, feminin, pluriel) VALUES (@masculin, @feminin, @pluriel)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@masculin", masculin));
                        command.Parameters.Add(new SqlParameter("@feminin", feminin));
                        command.Parameters.Add(new SqlParameter("@pluriel", pluriel));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de cette article.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Article créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de l'article.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        /* -- Adverbe -- */
        public static List<Mot> SelectAllAdverbes()
        {
            List<Mot> lesMots = new List<Mot>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adverbe ORDER BY adverbe";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Adverbe adverbe = new Adverbe
                                (
                                    reader["id"].ToString(),
                                    reader["adverbe"].ToString()
                                );
                                lesMots.Add(adverbe);
                            }
                        }
                    }
                }
            }
            return lesMots;
        }
        public static Adverbe SelectAdverbeById(string id)
        {
            Adverbe adverbe = new Adverbe();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Adverbe WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                adverbe = new Adverbe(
                                    reader["id"].ToString(),
                                    reader["adverbe"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return adverbe;
        }

        public static void InsertAdverbe(string adverbe)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Adverbe (adverbe) VALUES (@adverbe)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@adverbe", adverbe));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de cette Adverbe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Adverbe créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de l'adverbe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /* -- Phrase -- */
        public static List<Phrase> SelectAllPhrases()
        {
            List<Phrase> lesPhrases = new List<Phrase>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Phrase ORDER BY id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Phrase phrase = new Phrase(
                                    reader["id"].ToString(),
                                    reader["idAdjectifPossessif"].ToString(),
                                    reader["adjectifPossessif"].ToString(),
                                    reader["idArticle"].ToString(),
                                    reader["article"].ToString(),
                                    reader["idPronom"].ToString(),
                                    reader["idNom"].ToString(),
                                    reader["nom"].ToString(),
                                    reader["idVerbe"].ToString(),
                                    reader["conjugaison"].ToString(),
                                    reader["idAdverbe"].ToString(),
                                    reader["idAdjectif"].ToString(),
                                    reader["adjectif"].ToString()
                                );
                                lesPhrases.Add(phrase);
                            }
                        }
                    }
                }
            }

            return lesPhrases;
        }

        public static Phrase SelectPhraseById(string id)
        {
            Phrase phrase = new Phrase();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Phrase WHERE id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                phrase = new Phrase(
                                    reader["id"].ToString(),
                                    reader["idAdjectifPossessif"].ToString(),
                                    reader["adjectifPossessif"].ToString(),
                                    reader["idArticle"].ToString(),
                                    reader["article"].ToString(),
                                    reader["idPronom"].ToString(),
                                    reader["idNom"].ToString(),
                                    reader["nom"].ToString(),
                                    reader["idVerbe"].ToString(),
                                    reader["conjugaison"].ToString(),
                                    reader["idAdverbe"].ToString(),
                                    reader["idAdjectif"].ToString(),
                                    reader["adjectif"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            return phrase;
        }

        public static void InsertPhrase(string idAdjP, string adjP, string idArticle, string article, string idPronom, string idNom, string nom, string idVerbe, string conjugaison, string idAdv, string idAdj, string adj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Phrase (idAdjectifPossessif, adjectifPossessif, idArticle, article, idPronom, idNom, nom, idVerbe, conjugaison, idAdverbe, idAdjectif, adjectif) VALUES (@idAdjectifPossessif, @adjectifPossessif, @idArticle, @article, @idPronom, @idNom, @nom, @idVerbe, @conjugaison, @idAdverbe, @idAdjectif, @adjectif)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@idAdjectifPossessif", String.IsNullOrEmpty(idAdjP) ? (object)DBNull.Value : (string)idAdjP));
                        command.Parameters.Add(new SqlParameter("@adjectifPossessif", String.IsNullOrEmpty(adjP) ? (object)DBNull.Value : (string)adjP));
                        command.Parameters.Add(new SqlParameter("@idArticle", String.IsNullOrEmpty(idArticle) ? (object)DBNull.Value : (string)idArticle));
                        command.Parameters.Add(new SqlParameter("@article", String.IsNullOrEmpty(article) ? (object)DBNull.Value : (string)article));
                        command.Parameters.Add(new SqlParameter("@idPronom", String.IsNullOrEmpty(idPronom) ? (object)DBNull.Value : (string)idPronom));
                        command.Parameters.Add(new SqlParameter("@idNom", String.IsNullOrEmpty(idNom) ? (object)DBNull.Value : (string)idNom));
                        command.Parameters.Add(new SqlParameter("@nom", String.IsNullOrEmpty(nom) ? (object)DBNull.Value : (string)nom));
                        command.Parameters.Add(new SqlParameter("@idVerbe", idVerbe));
                        command.Parameters.Add(new SqlParameter("@conjugaison", conjugaison));
                        command.Parameters.Add(new SqlParameter("@idAdverbe", String.IsNullOrEmpty(idAdv) ? (object)DBNull.Value : (string)idAdv));
                        command.Parameters.Add(new SqlParameter("@idAdjectif", String.IsNullOrEmpty(idAdj) ? (object)DBNull.Value : (string)idAdj));
                        command.Parameters.Add(new SqlParameter("@adjectif", String.IsNullOrEmpty(adj) ? (object)DBNull.Value : (string)adj));

                        int result = command.ExecuteNonQuery();

                        if (result <= 0)
                            MessageBox.Show("Erreur lors de l'insertion de cette phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Phrase créée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'insertion de la phrase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /* -- Question -- */
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
                                    id = reader["id"].ToString(),
                                    libelle = reader["libelle"].ToString(),
                                    type = reader["type"].ToString()
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
