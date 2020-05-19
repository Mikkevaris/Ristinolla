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
    public partial class Peli : Form
    {
        public int vuoronumero = 0; //muuttuja, jonka avulla valitaan risti tai nolla.
        public char[] testi = new char[9]; //Testataan tämän taulukon avulla voittaja.
        int kokeilu;
        public int counter = 0;
        public bool voitto = false;
        public Peli(int valinta)
        {
            InitializeComponent();
            kokeilu = valinta; //Tällä muuttujalla tutkitaan onko valittu käyttäjä vai tietokone vastustajaksi.
            
        }

        public void Tietokone() //EI TOIMI!
        {
            Graphics g = this.CreateGraphics();
            Pen punainen = new Pen(Color.Red, 3);
            Random rnd = new Random();
            
            int x;
            do
            {
                x = rnd.Next(0, 9);

            } while (x == testi[x]);
            //Arvotaan luku ja piirretään nolla sitä vastaavalle paneelille.
            switch (x)
            {
                case 0:
                    Ruutu1.Visible = false;
                    g.DrawEllipse(punainen, Ruutu1.Location.X + 5, Ruutu1.Location.Y + 5, 120, 120);
                    testi[0] = 'O';
                    break;
                case 1:
                    Ruutu2.Visible = false;
                    g.DrawEllipse(punainen, Ruutu2.Location.X + 5, Ruutu2.Location.Y + 5, 120, 120);
                    testi[1] = 'O';
                    break;
                case 2:
                    Ruutu3.Visible = false;
                    g.DrawEllipse(punainen, Ruutu3.Location.X + 5, Ruutu3.Location.Y + 5, 120, 120);
                    testi[2] = 'O';
                    break;
                case 3:
                    Ruutu4.Visible = false;
                    g.DrawEllipse(punainen, Ruutu4.Location.X + 5, Ruutu4.Location.Y + 5, 120, 120);
                    testi[3] = 'O';
                    break;
                case 4:
                    Ruutu5.Visible = false;
                    g.DrawEllipse(punainen, Ruutu5.Location.X + 5, Ruutu5.Location.Y + 5, 120, 120);
                    testi[4] = 'O';
                    break;
                case 5:
                    Ruutu6.Visible = false;
                    g.DrawEllipse(punainen, Ruutu6.Location.X + 5, Ruutu6.Location.Y + 5, 120, 120);
                    testi[5] = 'O';
                    break;
                case 6:
                    Ruutu7.Visible = false;
                    g.DrawEllipse(punainen, Ruutu7.Location.X + 5, Ruutu7.Location.Y + 5, 120, 120);
                    testi[6] = 'O';
                    break;
                case 7:
                    Ruutu8.Visible = false;
                    g.DrawEllipse(punainen, Ruutu8.Location.X + 5, Ruutu8.Location.Y + 5, 120, 120);
                    testi[7] = 'O';
                    break;
                case 8:
                    Ruutu9.Visible = false;
                    g.DrawEllipse(punainen, Ruutu9.Location.X + 5, Ruutu9.Location.Y + 5, 120, 120);
                    testi[8] = 'O';
                    break;


            }
            vuoronumero++;
              
        }
        //Tehdään funktio, joka piirtää ruudulle ristin tai nollan riippuen mikä vuoro
        //on kyseessä.
        public void RistiVaiYmpyra(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen sininen = new Pen(Color.Blue, 3);
            Pen punainen = new Pen(Color.Red, 3);
            if (vuoronumero % 2 != 0 && kokeilu == 0)
            {
                LbPelaaja.Text = "Risti";
                LbPelaaja.ForeColor = Color.Blue;
                g.DrawEllipse(punainen, x + 5, y + 5, 120, 120);
                vuoronumero++;
            }
            else if (vuoronumero % 2 == 0 && kokeilu == 0)
            {
                LbPelaaja.Text = " Nolla";
                LbPelaaja.ForeColor = Color.Red;
                g.DrawLine(sininen, x + 5, y + 5, x + 125, y + 125);
                g.DrawLine(sininen, x + 5, y + 125, x + 125, y + 5);
                vuoronumero++;
            }
            else if (vuoronumero % 2 == 0 && kokeilu == 1)
            {
                LbPelaaja.Text = "Risti";
                LbPelaaja.ForeColor = Color.Blue;
                g.DrawLine(sininen, x + 5, y + 5, x + 125, y + 125);
                g.DrawLine(sininen, x + 5, y + 125, x + 125, y + 5);
                vuoronumero++;
                Tietokone();
            }
            else if (vuoronumero % 2 != 0 && kokeilu == 1)
            {
                LbPelaaja.Text = "Risti";
                LbPelaaja.ForeColor = Color.Blue;
                g.DrawLine(sininen, x + 5, y + 5, x + 125, y + 125);
                g.DrawLine(sininen, x + 5, y + 125, x + 125, y + 5);
                vuoronumero++;
                Tietokone();
            }

        }
        public void TaulukonAlustus()
        {
            testi[0] = '0';
            testi[1] = '1';
            testi[2] = '2';  //Alustetaan taulukko nyt näin,jotta
            testi[3] = '3';  //voittajan tarkistaminen on helpompaa.
            testi[4] = '4';
            testi[5] = '5';
            testi[6] = '6';
            testi[7] = '7';
            testi[8] = '8';
        }
        public void VoittoVaiTasapeli()
        {

            //Tarkastetaan onko vaakasuunnassa voitettu.
            if ((testi[0] == testi[1]) && (testi[1] == testi[2]))
                voitto = true;
            else if ((testi[3] == testi[4]) && (testi[4] == testi[5]))
                voitto = true;
            else if ((testi[6] == testi[7]) && (testi[7] == testi[8]))
                voitto = true;
            //Tarkastetaan onko pystysuunnassa voitettu.
            if ((testi[0] == testi[3]) && (testi[3] == testi[6]))
                voitto = true;
            else if ((testi[1] == testi[4]) && (testi[4] == testi[7]))
                voitto = true;
            else if ((testi[2] == testi[5]) && (testi[5] == testi[8]))
                voitto = true;
            //Tarkastetaan onko vinosuunnassa voitettu
            if ((testi[0] == testi[4]) && (testi[4] == testi[8]))
                voitto = true;
            else if ((testi[2] == testi[4]) && (testi[4] == testi[6]))
                voitto = true;

            if (voitto && (vuoronumero % 2 == 0))
            {
                MessageBox.Show("Nolla Voitit!");
                this.Controls.Clear();
                this.InitializeComponent();
                TaulukonAlustus(); //Taulukon uudelleen alustus.
                vuoronumero = 0;
                voitto = false;
            }
            else if (voitto && (vuoronumero % 2 != 0))
            {
                MessageBox.Show("Risti Voitit!");
                this.Controls.Clear();
                this.InitializeComponent();
                TaulukonAlustus();
                vuoronumero = 0;
                voitto = false;
            }
            else if (vuoronumero == 9 && !voitto)
            {
                MessageBox.Show("Tasapeli!");
                this.Controls.Clear();
                this.InitializeComponent();
                TaulukonAlustus();
                vuoronumero = 0;
                voitto = false;
            }

        }


        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Avataan toinen lomake ja suljetaan aikaisempi.
            this.Hide();
            var aloitus = new Aloitus();
            aloitus.Closed += (s, args) => this.Close();
            aloitus.Show();
        }

        private void Peli_Paint(object sender, PaintEventArgs e)
        {
            //Piirretään Ruudukko.

            Graphics g = e.Graphics;
            Color c = Color.Black;
            Size kehä = new Size(414, 402);
            Pen kyna = new Pen(c, 3);

            Point lokaatio = new Point(5, 86);
            Rectangle ruudukko = new Rectangle(lokaatio, kehä);
            g.DrawRectangle(kyna, ruudukko);

            g.DrawLine(new Pen(c, 3), 142, 86, 142, 487);
            g.DrawLine(new Pen(c, 3), 281, 86, 281, 487);
            g.DrawLine(new Pen(c, 3), 7, 219, 420, 219);
            g.DrawLine(new Pen(c, 3), 7, 354, 420, 354);

        }
        private void Peli_Load(object sender, EventArgs e)
        {
            TaulukonAlustus(); //Alustetaan taulukko aina uudelleen lomakkeen ladatessa.
            vuoronumero = 0;
        }
        private void TsmiUusipeli_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent(); //Lataa lomakkeen uudelleen.
            TaulukonAlustus();
            vuoronumero = 0;
            voitto = false;
        }
        //Ohjelmoidaan,että ruutua klikatessa ruudulle ilmestyy joko rasti tai nolla.
        private void Ruutu1_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            

            //Tallennetaan arvo X tai O taulukkoon, joiden avulla tarkistetaan voittiko.
            if (vuoronumero % 2 != 0)
            {
                testi[0] = 'O';
            }
            else if (vuoronumero % 2 == 0)
            {
                testi[0] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);

            VoittoVaiTasapeli();

        }


        private void Ruutu2_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[1] = 'O';
            }
            else
            {
                testi[1] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
           
            VoittoVaiTasapeli();
            
        }

        private void Ruutu3_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            

            if (vuoronumero % 2 != 0)
            {
                testi[2] = 'O';
            }
            else
            {
                testi[2] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
            
            VoittoVaiTasapeli();

        }

        private void Ruutu4_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[3] = 'O';
            }
            else
            {
                testi[3] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);          
           
            VoittoVaiTasapeli();

        }

        private void Ruutu5_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[4] = 'O';
            }
            else
            {
                testi[4] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
            
            VoittoVaiTasapeli();

        }

        private void Ruutu6_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[5] = 'O';
            }
            else
            {
                testi[5] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
            
            VoittoVaiTasapeli();

        }

        private void Ruutu7_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
           
            if (vuoronumero % 2 != 0)
            {
                testi[6] = 'O';
            }
            else
            {
                testi[6] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
           
            VoittoVaiTasapeli();

        }

        private void Ruutu8_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[7] = 'O';
            }
            else
            {
                testi[7] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
           
            VoittoVaiTasapeli();

        }

        private void Ruutu9_Click(object sender, EventArgs e)
        {
            Panel ruutu = (Panel)sender;
            ruutu.Visible = false;
            
            if (vuoronumero % 2 != 0)
            {
                testi[8] = 'O';
            }
            else
            {
                testi[8] = 'X';
            }
            RistiVaiYmpyra(ruutu.Location.X, ruutu.Location.Y);
           
            VoittoVaiTasapeli();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
        }

        private void learderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var leaderboard = new Leaderboard();
            leaderboard.ShowDialog();
        }
    }
}
