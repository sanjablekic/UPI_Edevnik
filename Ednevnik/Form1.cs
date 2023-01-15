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
    public partial class Form1 : Form
    {
        Dictionary<int, Ucenik> d_ucenici = new Dictionary<int, Ucenik>();
        Dictionary<int, Profesor> d_profesori = new Dictionary<int, Profesor>();
        Dictionary<int, Razrednik> d_razrednici = new Dictionary<int, Razrednik>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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


            d_profesori.Clear();

            using (StreamReader sr = File.OpenText("profesori.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] n = linija.Split(';');
                    int q = int.Parse(n[0]);
                    int q1 = int.Parse(n[3]);
                    int q2 = int.Parse(n[4]);
                    int q3 = int.Parse(n[5]);

                    Profesor novi = new Profesor(q, n[1], n[2], q1, q2, q3);
                    d_profesori.Add(q, novi);
                }
            }


            d_razrednici.Clear();

            using (StreamReader sr = File.OpenText("razrednici.txt"))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] n = linija.Split(';');
                    int q = int.Parse(n[0]);

                    Razrednik novi = new Razrednik(q, n[1], n[2], n[3]);
                    d_razrednici.Add(q, novi);
                }
            }
        }

        private void btnUcenik_Click(object sender, EventArgs e)
        {
            int ucenik_id;
            string ucenik_lozinka;

            try
            {
                ucenik_id = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Pogrešan ID!");
                textBox1.Text = "";
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Unesite lozinku!");
                return;
            }
            else
            {
                ucenik_lozinka = textBox2.Text;
            }

            int zastavica = 0;

            foreach (int u in d_ucenici.Keys)
            {
                Ucenik t = (Ucenik)d_ucenici[u];
                if (t.Id == ucenik_id && t.Lozinka == ucenik_lozinka)
                {
                    zastavica = 1;
                    using (StreamWriter sw = File.CreateText("login.txt"))
                    {
                        string linija = ($"{t.Id};{t.ImePrezime};{t.Lozinka};{t.Razred};" +
                            $"{t.OcjeneHRV};{t.OcjeneENG};{t.OcjeneMAT};" +
                            $"{t.Br_opravdanih};{t.Br_neopravdanih};" +
                            $"{t.Br_novi_izostanci};{t.Novi_izostanci};" +
                            $"{t.BiljeskeHRV};{t.BiljeskeENG};{t.BiljeskeMAT};");
                        sw.WriteLine(linija);
                    }

                }
            }
            if (zastavica == 0)
            {
                MessageBox.Show("Ponovite unos!");
                return;
            }
            else
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            int ucenik_id;
            string ucenik_lozinka;
            try
            {
                ucenik_id = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Pogrešan ID!");
                textBox1.Text = "";
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Unesite lozinku!");
                return;
            }
            else
            {
                ucenik_lozinka = textBox2.Text;
            }

            int zastavica = 0;

            foreach (int u in d_profesori.Keys)
            {
                Profesor t = (Profesor)d_profesori[u];
                if (t.Id == ucenik_id && t.Lozinka == ucenik_lozinka)
                {
                    zastavica = 1;
                    using (StreamWriter sw = File.CreateText("login.txt"))
                    {
                        string linija = ($"{t.Id};{t.ImePrezime};{t.Lozinka};" +
                                $"{t.PredHRV};{t.PredENG};{t.PredMAT}");
                        sw.WriteLine(linija);
                    }

                }
            }
            if (zastavica == 0)
            {
                MessageBox.Show("Ponovite unos!");
                return;
            }
            else
            {

                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnRazrednik_Click(object sender, EventArgs e)
        {
            int ucenik_id;
            string ucenik_lozinka;
            try
            {
                ucenik_id = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Pogrešan ID!");
                textBox1.Text = "";
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Unesite lozinku!");
                return;
            }
            else
            {
                ucenik_lozinka = textBox2.Text;
            }

            int zastavica = 0;

            foreach (int u in d_razrednici.Keys)
            {
                Razrednik t = (Razrednik)d_razrednici[u];
                if (t.Id == ucenik_id && t.Lozinka == ucenik_lozinka)
                {
                    zastavica = 1;
                    using (StreamWriter sw = File.CreateText("login.txt"))
                    {
                        string linija = ($"{t.Id};{t.ImePrezime};{t.Lozinka};{t.Razred}");
                        sw.WriteLine(linija);
                    }

                }
            }
            if (zastavica == 0)
            {
                MessageBox.Show("Ponovite unos!");
                return;
            }
            else
            {
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
