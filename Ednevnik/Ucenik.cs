using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ednevnik
{
    class Ucenik
    {
        private int id;
        private string imePrezime;
        private string lozinka;
        private string razred;

        private string ocjeneHRV;
        private string ocjeneENG;
        private string ocjeneMAT;

        private int br_opravdanih;
        private int br_neopravdanih;
        private int br_novi_izostanci;

        private string biljeskeHRV;
        private string biljeskeENG;
        private string biljeskeMAT;

        private string novi_izostanci;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string ImePrezime
        {
            get => imePrezime;
            set => imePrezime = value;
        }
        public string Lozinka
        {
            get => lozinka;
            set => lozinka = value;
        }
        public string Razred
        {
            get => razred;
            set => razred = value;
        }
        public string OcjeneHRV
        {
            get => ocjeneHRV;
            set => ocjeneHRV = value;
        }
        public string OcjeneENG
        {
            get => ocjeneENG;
            set => ocjeneENG = value;
        }
        public string OcjeneMAT
        {
            get => ocjeneMAT;
            set => ocjeneMAT = value;
        }
        public string BiljeskeHRV
        {
            get => biljeskeHRV;
            set => biljeskeHRV = value;
        }
        public string BiljeskeENG
        {
            get => biljeskeENG;
            set => biljeskeENG = value;
        }
        public string BiljeskeMAT
        {
            get => biljeskeMAT;
            set => biljeskeMAT = value;
        }
        public int Br_opravdanih
        {
            get => br_opravdanih;
            set => br_opravdanih = value;
        }
        public int Br_neopravdanih
        {
            get => br_neopravdanih;
            set => br_neopravdanih = value;
        }
        public string Novi_izostanci
        {
            get => novi_izostanci;
            set => novi_izostanci = value;
        }
        public int Br_novi_izostanci
        {
            get => br_novi_izostanci;
            set => br_novi_izostanci = value;
        }

        public Ucenik(int id, string ip, string loz, string raz,
                      string o_hrv, string o_eng, string o_mat,
                      int br_op, int br_neop,
                      int br_n_izo, string n_izo,
                      string bilj_hrv, string bilj_eng, string bilj_mat)
        {

            this.Id = id;
            this.ImePrezime = ip;
            this.Lozinka = loz;
            this.Razred = raz;

            this.OcjeneHRV = o_hrv;
            this.OcjeneENG = o_eng;
            this.OcjeneMAT = o_mat;

            this.Br_opravdanih = br_op;
            this.Br_neopravdanih = br_neop;

            this.Br_novi_izostanci = br_n_izo;
            this.Novi_izostanci = n_izo;

            this.BiljeskeHRV = bilj_hrv;
            this.BiljeskeENG = bilj_eng;
            this.BiljeskeMAT = bilj_mat;
        }
    }
}
