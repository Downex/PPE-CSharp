using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace WindowsForm
{
    public class Utilisateur
    {
        public string Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Rang { get; set; }

        public string Score { get; set; }
        public string IsAdmin { get; set; }

        public Utilisateur(string Login, string Password, string Nom, string Prenom, string Rang, string Score, string IsAdmin)
        {
            this.Login = Login;
            this.Password = Password;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Rang = Rang;
            this.Score = Score;
            this.IsAdmin = IsAdmin;
        }

        public Utilisateur()
        {

        }

        /// <summary>
        /// Permet le Hash d'une chaine de caractère
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static string Hash256(string rawData)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
