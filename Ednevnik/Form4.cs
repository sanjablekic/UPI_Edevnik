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
    public partial class Form4 : Form
    {
        Razrednik r;
        Dictionary<int, Ucenik> d_ucenici = new Dictionary<int, Ucenik>();
        Ucenik t;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText("login.txt"))
            {
                string linija = sr.ReadLine();
                string[] n = linija.Split(';');

                int q1 = int.Parse(n[0]);

                r = new Razrednik(q1, n[1], n[2], n[3]);

            }
            d_ucenici.Clear();

            using (StreamReader sr = File.OpenText("ucenici.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] n = linija.Split(';');
                    int q = int.Parse(n[0]);
                    int q1 = int.Parse(n[7]);
                    int q2 = int.Parse(n[8]);
                    int q3 = int.Parse(n[9]);

                    Ucenik novi = new Ucenik(q, n[1], n[2], n[3], n[4], n[5], n[6], 
                                        q1, q2, q3, n[10], n[11], n[12], n[13]);
                    d_ucenici.Add(q, novi);
                }
            }
            if (r.Razred == "5A")
            {
                listBox1.Items.Clear();
                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];
                    if (t.Razred == "5A")
                        listBox1.Items.Add(t.ImePrezime);
                }
            }
            else if (r.Razred == "6A")
            {
                listBox1.Items.Clear();
                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];
                    if (t.Razred == "6A")
                        listBox1.Items.Add(t.ImePrezime);
                }
            }
            else if (r.Razred == "7A")
            {
                listBox1.Items.Clear();
                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];
                    if (t.Razred == "7A")
                        listBox1.Items.Add(t.ImePrezime);
                }
            }
            else if (r.Razred == "8A")
            {
                listBox1.Items.Clear();
                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];
                    if (t.Razred == "8A")
                        listBox1.Items.Add(t.ImePrezime);
                }
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali!");
                return;
            }
            else
            {
                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];
                    if (t.ImePrezime == listBox1.SelectedItem.ToString())
                    {
                        lblIspis.Text = ($"{t.ImePrezime}  {t.Razred}\n" +
                                $"\n{t.OcjeneHRV}\n" +
                                $"{t.BiljeskeHRV}\n" +
                                $"\n{t.OcjeneENG}\n" +
                                $"{t.BiljeskeENG}\n" +
                                $"\n{t.OcjeneMAT}\n" +
                                $"{t.BiljeskeMAT}\n" +
                                $"\nBroj opravdanih: {t.Br_opravdanih}\n" +
                                $"Broj neopravdanih: {t.Br_neopravdanih}\n" +
                                $"\nBroj novih izostanaka: {t.Br_novi_izostanci}\n" +
                                $"{t.Novi_izostanci}\n");
                    }
                }
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Označite opciju!");
                return;
            }
            foreach (int j in d_ucenici.Keys)
            {
                Ucenik a = (Ucenik)d_ucenici[j];
                if (listBox1.SelectedItem.ToString() == a.ImePrezime)
                    t = a;
            }
            if (radioButton1.Checked)
            {
                t.Br_opravdanih += t.Br_novi_izostanci;
                t.Br_novi_izostanci = 0;
                t.Novi_izostanci = "Novi izostanci:";
            }
            else if (radioButton2.Checked)
            {
                t.Br_neopravdanih += t.Br_novi_izostanci;
                t.Br_novi_izostanci = 0;
                t.Novi_izostanci = "Novi izostanci:";
            }


            using (StreamWriter sw = File.CreateText("ucenici.txt"))
            {
                string linija = "";
                foreach (int uu in d_ucenici.Keys)
                {
                    Ucenik uup = (Ucenik)d_ucenici[uu];
                    linija = ($"{uup.Id};{uup.ImePrezime};{uup.Lozinka};{uup.Razred};" +
                        $"{uup.OcjeneHRV};{uup.OcjeneENG};{uup.OcjeneMAT};" +
                        $"{uup.Br_opravdanih};{uup.Br_neopravdanih};" +
                        $"{uup.Br_novi_izostanci};{uup.Novi_izostanci};" +
                        $"{uup.BiljeskeHRV};{uup.BiljeskeENG};{uup.BiljeskeMAT}");
                    sw.WriteLine(linija);
                }
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
