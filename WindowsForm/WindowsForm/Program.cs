﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_jeux;

namespace WindowsForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Utilisateur> lesUtilisateurs;
            lesUtilisateurs = new List<Utilisateur>();

            List<Mot> lesMots;
            lesMots = new List<Mot>();

            List<Conjugaison> lesConjugaisons;
            lesConjugaisons = new List<Conjugaison>();

            List<Phrase> lesPhrases;
            lesPhrases = new List<Phrase>();

            Authentification authentification = new Authentification(lesUtilisateurs);


            Application.Run(authentification);

            if(authentification.Utilisateur != null)
            {
                Application.Run(new Accueil(authentification.Utilisateur));
            }
        }
    }
}
