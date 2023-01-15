using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ednevnik
{
    class Razrednik
    {
        private int id;
        private string imePrezime;
        private string lozinka;
        private string razred;

        public string ImePrezime
        {
            get => imePrezime;
            set => imePrezime = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
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


        public Razrednik(int id, string ip, string loz, string raz)
        {
            this.Id = id;
            this.ImePrezime = ip;
            this.Lozinka = loz;
            this.Razred = raz;
        }
    }
}
