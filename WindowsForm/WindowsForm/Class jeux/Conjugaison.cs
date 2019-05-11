using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Conjugaison
    {
        public string id { get; set; }
        public string temps { get; set; }
        public string premierSing { get; set; }
        public string deuxiemeSing { get; set; }
        public string troisiemeSing { get; set; }
        public string premierPlur { get; set; }
        public string deuxiemePlur { get; set; }
        public string troisiemePlur { get; set; }
        public string idVerbe { get; set; }

        public Conjugaison(String id, String temps, String premierSing, String deuxiemeSing, String troisiemeSing, String premierPlur, String deuxiemePlur, String troisiemePlur, String idVerbe)
        {
            this.temps = temps;
            this.premierSing = premierSing;
            this.deuxiemeSing = deuxiemeSing;
            this.troisiemeSing = troisiemeSing;
            this.premierPlur = premierPlur;
            this.deuxiemePlur = deuxiemePlur;
            this.troisiemePlur = troisiemePlur;
            this.idVerbe = idVerbe;
        }
        
        public Conjugaison()
        {

        }

        public string GetTemps()
        {
            return temps;
        }

        public string GetPremierSing()
        {
            return premierSing;
        }

        public string GetDeuxiemeSing()
        {
            return deuxiemeSing;
        }

        public string GetTroisiemeSing()
        {
            return troisiemeSing;
        }

        public string GetPremierPlur()
        {
            return premierPlur;
        }

        public string GetDeuxiemePlur()
        {
            return deuxiemePlur;
        }

        public string GetTroisiemePlur()
        {
            return troisiemePlur;
        }
    }
}
