using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opterecenje_nastavnika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Nastavnik> listaNastavnika = new List<Nastavnik>();
        private List<Predmet> listaPredmeta = new List<Predmet>();

        private void btnNastavnik_Click(object sender, EventArgs e)
        {
            Nastavnik n = new Nastavnik(txtNastavnik.Text, 0);
            listaNastavnika.Add(n);
            lstNastavnici.Items.Add(n.ImePrezime);
            Osvjezi();
            txtNastavnik.Clear();
        }

        private void Osvjezi()
        {
            BindingSource bs = new BindingSource(listaNastavnika, null);
            dataGridView1.DataSource = bs;
        }

        private void btnPredmet_Click(object sender, EventArgs e)
        {
            if(lstNastavnici.SelectedItem != null)
            {
               string odabraniNastavnik = lstNastavnici.SelectedItem.ToString();
                Predmet p = new Predmet(txtPredmet.Text, 0, odabraniNastavnik);
                listaPredmeta.Add(p);
                lstPredmeti.Items.Add(p.Naziv);
                txtPredmet.Clear();
            }

        }

        private void btnSati_Click(object sender, EventArgs e)
        {
            if (lstPredmeti.SelectedItem != null)
            {
                string odabraniPredmet = lstPredmeti.SelectedItem.ToString();
                var nadi = listaPredmeta.Where(x => x.Naziv == odabraniPredmet).FirstOrDefault();
                if(nadi != null)
                {
                    nadi.BrojSati = int.Parse(txtSati.Text);
                }

                string odabraniNastavnik = lstNastavnici.SelectedItem.ToString();
                var nadi2 = listaNastavnika.Where(x => x.ImePrezime == odabraniNastavnik).FirstOrDefault();
                if (nadi2 != null)
                {
                    nadi2.Opterecenje += int.Parse(txtSati.Text);
                }

                txtSati.Clear();
                Osvjezi();
            }
        }

        private void lstNastavnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPredmeti.Items.Clear();
            if (lstNastavnici.SelectedItem != null)
            {
                string odabraniNastavnik = lstNastavnici.SelectedItem.ToString();
                foreach (Predmet p in listaPredmeta)
                {
                    if(p.Nastavnik == odabraniNastavnik)
                    {
                        lstPredmeti.Items.Add(p.Naziv);
                    }
                }
            }
        }

        private void lstPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSati.Clear();
            if (lstPredmeti.SelectedItem != null)
            {
                string odabraniPredmet = lstPredmeti.SelectedItem.ToString();
                foreach (Predmet p in listaPredmeta)
                {
                    if (p.Naziv == odabraniPredmet)
                    {
                        txtSati.Text = p.BrojSati.ToString();
                    } 
                }
            }
        }
    }
}
