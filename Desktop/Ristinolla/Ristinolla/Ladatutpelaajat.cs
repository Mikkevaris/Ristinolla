using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Ristinolla
{
    public partial class Ladatutpelaajat : Form
    {
        int kokeilu;
        public int valinta;
        public string pelaajatfile = "pelaajat.json";
        public List<Pelaaja> pelaajat;

        public struct Pelaaja
        {
            public string etunimi;

            public string Etunimi
            {
                get { return etunimi; }
            }

        }
        //Luetaan listaan henkilöt tiedostosta
        public List<Pelaaja> DeserializehenkilosJson()
        {
            if (File.Exists(pelaajatfile))
            {
                using (StreamReader r = new StreamReader(pelaajatfile))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Pelaaja>>(json);
                }
            }
            else
            {
                return null;
            }

        }
        public Ladatutpelaajat(int valinta)
        {
            InitializeComponent();
            kokeilu = valinta;
        }

        private void BtnPeruuta_Click(object sender, EventArgs e)
        {
            //Näin saadaan peruutus nappulasta viemään oikeaan lomakkeeseen takaisin
            //nyt kun käytetään yhtä samaa lomaketta ladatuissa pelaajissa.
            if (kokeilu == 1)
            {
                this.Hide();
                var aloitus = new Aloitus();
                aloitus.Closed += (s, args) => this.Close();
                aloitus.Show();
            }
            else if (kokeilu == 0)
            {
                this.Hide();
                var vastustaja = new Vastustaja();
                vastustaja.Closed += (s, args) => this.Close();
                vastustaja.Show();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (kokeilu == 1)
            {
                this.Hide();
                var vastustaja = new Vastustaja();
                vastustaja.Closed += (s, args) => this.Close();
                vastustaja.Show();
            }
            else if (kokeilu == 0)
            {
                valinta = 0;
                this.Hide();
                var peli = new Peli(valinta);
                peli.Closed += (s, args) => this.Close();
                peli.Show();
            }
        }

        private void Ladatutpelaajat_Load(object sender, EventArgs e)
        {
            pelaajat = DeserializehenkilosJson();
            foreach (Pelaaja p in pelaajat)
            {
                checkedListBox1.Items.Add(p.etunimi);
            }
        }
    }
}
