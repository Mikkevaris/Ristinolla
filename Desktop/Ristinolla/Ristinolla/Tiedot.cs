using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;

namespace Ristinolla
{
    public partial class Tiedot : Form
    {
        public static string teksti;
        public int valinta;

        private string pelaajatfile = "pelaajat.json";

        //Tallennetaan tiedot tiedostoon
        public void SerializepelaajatJSON(List<Pelaaja> input)
        { //Eitoimi!
            string json = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(pelaajatfile, json);
            /*if (File.Exists(pelaajatfile))
            {
                System.IO.File.WriteAllText(pelaajatfile, json);
            }
            else
            {
                System.IO.File.WriteAllText(pelaajatfile, json);
            }*/

        } 
        //Pelaajan tietue
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
        int kokeilu;
        //Lista, johon tietuuen tiedot tallennetaan
        public List<Pelaaja> pelaajat2 = new List<Pelaaja>();
        
        public Tiedot(int valinta)
        {
            InitializeComponent();
            kokeilu = valinta;
            
        }

        private void BtnPeruuta_Click(object sender, EventArgs e)
        {
            //Tarkistetaan miltä lomakkeelta on tultu ja peruutus-painike vie takaisin oikealle lomakkeelle.
            if (kokeilu == 0)
            {
                this.Hide();
                var aloitus = new Aloitus();
                aloitus.Closed += (s, args) => this.Close();
                aloitus.Show();
            }
            else if (kokeilu == 1)
            {
                this.Hide();
                var vastustaja = new Vastustaja();
                vastustaja.Closed += (s, args) => this.Close();
                vastustaja.Show();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Pelaaja p;
            p.etunimi = TbEtunimi.Text;
            p.sukunimi = TbSukunimi.Text;
            p.syntymaaika = DtpSyntymä.Value.ToShortDateString();
            p.voitot = "0";
            p.tappiot = "0";         //ALUSTAVASTI!
            p.tasapelit = "0";
            p.pelattuaika = "0";
            pelaajat2.Add(p);
            SerializepelaajatJSON(pelaajat2);
            

            //Avataan toinen lomake ja suljetaan aikaisempi.
            if (kokeilu == 0)
            {
                this.Hide();
                var vastustaja = new Vastustaja();
                vastustaja.Closed += (s, args) => this.Close();
                vastustaja.Show();
            }
            else if (kokeilu == 1)
            {
                valinta =  0;
                this.Hide();
                var peli = new Peli(valinta);
                peli.Closed += (s, args) => this.Close();
                peli.Show();
            }
            Ladatutpelaajat pelaajas = new Ladatutpelaajat(kokeilu);
        }
        
        private void TbEtunimi_Validating(object sender, CancelEventArgs e)
        {

            TextBox tb = (TextBox)sender;
            //Validoitaan kenttä, ettei se jää tyhjäksi ja että
            //tekstikentänttä hyväksymään vain varsinaisia nimiä.

            string nimenvalidointi = @"[a-öA-Ö]$"; //Hyväksyy näitten merkkien yhdistelmiä.
            bool validoitu = Regex.IsMatch(tb.Text, nimenvalidointi);

            if (int.TryParse(tb.Text, out int i))
            {
                errorProvider1.SetError(tb, "Kenttä ei voi sisältää numeroita.");
                e.Cancel = true;
            }
            else if (!validoitu)
            {
                errorProvider1.SetError(tb, "Kenttä tyhjä tai nimen muoto ei oikea");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tb, null); //Hävitetään errormerkki.
            }

        }

        private void Tiedot_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mahdollistetaan lomakkeen sulkeminen, vaikkei ole validoitu.
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
        }

    }
}
