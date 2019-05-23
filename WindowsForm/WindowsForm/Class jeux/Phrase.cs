using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Phrase
    {
        public String id;
        public String idAdjectifPossessif;
        public String adjectifPossessif;
        public String idArticle;
        public String article;
        public String idPronom;
        public String idNom;
        public String nom;
        public String idVerbe;
        public String conjugaison;
        public String idAdverbe;
        public String idAdjectif;
        public String adjectif;

        public Phrase(String id, String idAdjectifPossessif, String adjectifPossessif, String idArticle, String article, String idPronom, String idNom, String nom, String idVerbe, String conjugaison, String idAdverbe, String idAdjectif, String adjectif)
        {
            this.id = id;
            this.idAdjectifPossessif = idAdjectifPossessif;
            this.adjectifPossessif = adjectifPossessif;
            this.idArticle = idArticle;
            this.article = article;
            this.idPronom = idPronom;
            this.idNom = idNom;
            this.nom = nom;
            this.idVerbe = idVerbe;
            this.conjugaison = conjugaison;
            this.idAdverbe = idAdverbe;
            this.idAdjectif = idAdjectif;
            this.adjectif = adjectif;
        }

        public Phrase()
        {

        }

        public String GetId()
        {
            return id;
        }

        public String GetIdAdjectifPossessif()
        {
            return idAdjectifPossessif;
        }

        public String GetAdjectifPossessif()
        {
            return adjectifPossessif;
        }

        public String GetIdArticle()
        {
            return idArticle;
        }

        public String GetArticle()
        {
            return article;
        }

        public String GetIdPronom()
        {
            return idPronom;
        }

        public String GetIdNom()
        {
            return idNom;
        }

        public String GetNom()
        {
            return nom;
        }

        public String GetIdVerbe()
        {
            return idVerbe;
        }

        public String GetConjugaison()
        {
            return conjugaison;
        }

        public String GetIdAdverbe()
        {
            return idAdverbe;
        }

        public String GetIdAdjectif()
        {
            return idAdjectif;
        }

        public String GetAdjectif()
        {
            return adjectif;
        }
    }
}
