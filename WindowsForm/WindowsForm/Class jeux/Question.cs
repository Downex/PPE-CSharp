using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Question
    {
        public string Id { get; set; }
        public string Libelle { get; set; }
        public string Type { get; set; }

        public Question(string Id, string Libelle, string Type)
        {
            this.Id = Id;
            this.Libelle = Libelle;
            this.Type = Type;
        }

        public Question()
        {

        }
    }
}
