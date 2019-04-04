using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class Utilisateur
    {
        private string Login;
        private string Password;

        private string Nom;
        private string Prenom;

        private int Score;
        private bool IsAdmin;

        public Utilisateur(string Login, string Password, string Nom, string Prenom, int Score, bool IsAdmin)
        {
            this.Login = Login;
            this.Password = Password;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Score = Score;
            this.IsAdmin = IsAdmin;
        }

        public string getLogin()
        {
            return Login;
        }

        public string getPassword()
        {
            return Password;
        }

        public string getNom()
        {
            return Nom;
        }

        public string getPrenom()
        {
            return Prenom;
        }

        public int getScore()
        {
            return Score;
        }

        public bool getAdmin()
        {
            return IsAdmin;
        }
    }
}
