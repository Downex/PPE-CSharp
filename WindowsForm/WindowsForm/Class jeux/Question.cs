using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Question
    {
        public String id { get; set; }
        public String libelle { get; set; }
        public String type { get; set; }

        public Question(String id, String libelle, String type)
        {
            this.id = id;
            this.libelle = libelle;
            this.type = type;
        }

        public Question()
        {

        }

        public String GetId()
        {
            return id;
        }

        public String GetLibelle()
        {
            return libelle;
        }

        public String GetTypeQuestion()
        {
            return type;
        }
    }
}