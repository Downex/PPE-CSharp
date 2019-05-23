using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Class_jeux
{
    public class Conjugaison
    {
        public String id { get; set; }
        public String temps { get; set; }
        public String premierSing { get; set; }
        public String deuxiemeSing { get; set; }
        public String troisiemeSing { get; set; }
        public String premierPlur { get; set; }
        public String deuxiemePlur { get; set; }
        public String troisiemePlur { get; set; }
        public String idVerbe { get; set; }

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

        public String GetId()
        {
            return id;
        }

        public String GetTemps()
        {
            return temps;
        }

        public String GetPremierSing()
        {
            return premierSing;
        }

        public String GetDeuxiemeSing()
        {
            return deuxiemeSing;
        }

        public String GetTroisiemeSing()
        {
            return troisiemeSing;
        }

        public String GetPremierPlur()
        {
            return premierPlur;
        }

        public String GetDeuxiemePlur()
        {
            return deuxiemePlur;
        }

        public String GetTroisiemePlur()
        {
            return troisiemePlur;
        }

        public String GetIdverbe()
        {
            return idVerbe;
        }
    }
}
