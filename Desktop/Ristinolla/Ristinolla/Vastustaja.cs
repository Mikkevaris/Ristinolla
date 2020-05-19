using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Vastustaja : Form
    {
        public int valinta;

        public Vastustaja()
        {
            InitializeComponent();
            
        }

        private void BtnUusi_Click(object sender, EventArgs e)
        {
            valinta = 1;
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var vastustajantiedot = new Tiedot(valinta);
            vastustajantiedot.Closed += (s, args) => this.Close();
            vastustajantiedot.Show();
        }

        private void BtnTietokone_Click(object sender, EventArgs e)
        {
            var valinta = 1; //Tutkitaan toisessa lomakkeessa onko valittu tietokone.
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var peli = new Peli(valinta);
            peli.Closed += (s, args) => this.Close();
            peli.Show();
        }

        private void BtnLataa_Click(object sender, EventArgs e)
        {
            var valinta = 0;
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var ladatut = new Ladatutpelaajat(valinta);
            ladatut.Closed += (s, args) => this.Close();
            ladatut.Show();
        }
    }
}
