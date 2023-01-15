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
    public partial class Form3 : Form
    {
        Dictionary<int, Ucenik> d_ucenici = new Dictionary<int, Ucenik>();
        Ucenik t;
        Profesor p;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText("login.txt"))
            {
                string linija = sr.ReadLine();
                string[] n = linija.Split(';');

                int q1 = int.Parse(n[0]);
                int q2 = int.Parse(n[3]);
                int q3 = int.Parse(n[4]);
                int q4 = int.Parse(n[5]);
                p = new Profesor(q1, n[1], n[2], q2, q3, q4);
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
        }

        private void btnUcitajUcenike_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;

            if (i < 0)
            {
                MessageBox.Show("Niste odabrali!");
                return;
            }
            else
            {
                listBox1.Items.Clear();

                foreach (int u in d_ucenici.Keys)
                {
                    t = (Ucenik)d_ucenici[u];

                    if (t.Razred == comboBox1.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(t.ImePrezime);
                    }
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

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali!");
                return;
            }
            else
            {

                foreach (int j in d_ucenici.Keys)
                {
                    Ucenik a = (Ucenik)d_ucenici[j];
                    if (listBox1.SelectedItem.ToString() == a.ImePrezime)
                        t = a;
                }
                int uocjena;

                if (textBox1.Text != "")
                {
                    try
                    {
                        uocjena = int.Parse(textBox1.Text);
                    }
                    catch
                    {

                        MessageBox.Show("Krivi unos ocjene!");
                        return;
                    }
                    if (uocjena <= 0 || uocjena >= 6)
                    {
                        MessageBox.Show("Krivi unos ocjene!");
                        return;
                    }
                    if (p.PredHRV == 1)
                        t.OcjeneHRV += uocjena + ",";
                    else if (p.PredENG == 1)
                        t.OcjeneENG += uocjena + ",";
                    else if (p.PredMAT == 1)
                        t.OcjeneMAT += uocjena + ",";

                }

                if (textBox2.Text != "")
                {
                    if (p.PredHRV == 1)
                        t.BiljeskeHRV += textBox2.Text + ",";
                    else if (p.PredENG == 1)
                        t.BiljeskeENG += textBox2.Text + ",";
                    else if (p.PredMAT == 1)
                        t.BiljeskeMAT += textBox2.Text + ",";
                }

                if (checkBox1.Checked)
                {
                    t.Br_novi_izostanci += 1;

                    if (p.PredHRV == 1)
                        t.Novi_izostanci += "HRV " + DateTime.Now + ", ";
                    else if (p.PredENG == 1)
                        t.Novi_izostanci += "ENG " + DateTime.Now + ", ";
                    else if (p.PredMAT == 1)
                        t.Novi_izostanci += "MAT " + DateTime.Now + ", ";
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
                        $"{uup.BiljeskeHRV};{uup.BiljeskeENG};{uup.BiljeskeMAT};");
                        sw.WriteLine(linija);
                    }
                }

                MessageBox.Show("Uneseno!");

            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
