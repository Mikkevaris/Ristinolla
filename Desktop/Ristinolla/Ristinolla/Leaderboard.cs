using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Ristinolla
{
    public partial class Leaderboard : Form
    {
        public string pelaajatfile = "pelaajat.json";
        public struct Pelaaja
        {
            public string etunimi, sukunimi, syntymaaika, voitot, tappiot, tasapelit, pelattuaika;

            public string Etunimi
            {
                get { return etunimi; }
            }
            public string Sukunimi
            {
                get { return sukunimi; }
            }
            public string Syntymaaika
            {
                get { return syntymaaika; }
            }
            public string Voitot
            {
                get { return voitot; }
            }
            public string Tappiot
            {
                get { return tappiot; }
            }
            public string Tasapelit
            {
                get { return tasapelit; }
            }
            public string Pelattuaika
            {
                get { return pelattuaika; }
            }

        }
        public List<Pelaaja> pelaajat;

        public Leaderboard()
        {
            
            InitializeComponent();
            pelaajat = DeserializehenkilosJson();
            dataGridView1.DataSource = pelaajat;
            
        }
        
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

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
