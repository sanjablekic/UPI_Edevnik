using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Ucenik u;
            using (StreamReader sr = File.OpenText("login.txt"))
            {
                string linija = sr.ReadLine();

                string[] n = linija.Split(';');
                int q = int.Parse(n[0]);
                int q1 = int.Parse(n[7]);
                int q2 = int.Parse(n[8]);
                int q3 = int.Parse(n[9]);

                u = new Ucenik(q, n[1], n[2], n[3], n[4], n[5], n[6],
                            q1, q2, q3, n[10], n[11], n[12], n[13]);
            }

            lblIspis.Text = ($"{u.ImePrezime}  {u.Razred};\n" +
                $"\n{u.OcjeneHRV}\n" +
                $"{u.BiljeskeHRV}\n" +
                $"\n{u.OcjeneENG}\n" +
                $"{u.BiljeskeENG}\n" +
                $"\n{u.OcjeneMAT}\n" +
                $"{u.BiljeskeMAT}\n" +
                $"\nBroj opravdanih: {u.Br_opravdanih}\n" +
                $"Broj neopravdanih: {u.Br_neopravdanih}\n" +
                $"Broj novih izostanaka: {u.Br_novi_izostanci}\n" +
                $"\n{u.Novi_izostanci}\n");
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
