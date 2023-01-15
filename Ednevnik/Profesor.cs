using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ednevnik
{
    class Profesor
    {
        private int id;
        private string imePrezime;
        private string lozinka;

        private int predHRV;
        private int predENG;
        private int predMAT;

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
        public int PredHRV
        {
            get => predHRV;
            set => predHRV = value;
        }
        public int PredENG
        {
            get => predENG;
            set => predENG = value;
        }
        public int PredMAT
        {
            get => predMAT;
            set => predMAT = value;
        }

        public Profesor(int id, string ip, string loz,
                        int pre_hrv, int pre_eng, int pre_mat)
        {
            this.Id = id;
            this.ImePrezime = ip;
            this.Lozinka = loz;

            this.PredHRV = pre_hrv;
            this.PredENG = pre_eng;
            this.PredMAT = pre_mat;
        }
    }
}
