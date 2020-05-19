using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace Ristinolla
{
    public partial class Aloitus : Form
    {
        public int valinta;

        public Aloitus()
        {
            InitializeComponent();
        }

        private void BtnUusi_Click(object sender, EventArgs e)
        {
            valinta = 0;
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var tiedot = new Tiedot(valinta);
            tiedot.Closed += (s, args) => this.Close();
            tiedot.Show();
            Console.WriteLine("Testing");
        }

        

        private void BtnLataa_Click(object sender, EventArgs e)
        {
            valinta = 1;
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var ladatut = new Ladatutpelaajat(valinta);
            ladatut.Closed += (s, args) => this.Close();
            ladatut.Show();
        }
    }
}
