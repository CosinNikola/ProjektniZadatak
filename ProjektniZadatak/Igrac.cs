using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak
{
    class Igrac : Osoba
    {
        private double visina;
        private double tezina;
        private string pozicija;
        private string kategorija;
        private Klub klub;


        public double Tezina
        {
            get { return tezina; }
            set { tezina = value; }
        }

        public string Pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }

        public int Godine
        {
            get { return godine; }
            set { godine = value; }
        }

        public Klub Klub
        {
            get { return klub; }
            set { Klub = value; }
        }

        public double Visina
        {
            get { return visina; }
            set { 
                    visina = value;
            }
        }

        public string Kategorija
        {
            get { return kategorija; }
            set
            {
                kategorija = value;
            }
        }

        public Igrac(string ime, string prezime,int godine, double visina, string pozicija, double tezina, string kategorija, string naziv, string grad,bool filijala):base(ime, prezime, godine)
        {
            this.visina = visina;
            this.tezina = tezina;
            this.pozicija = pozicija;
            klub = new Klub(naziv, grad,filijala);
        }


        public static void potvrda()
        {
            MessageBox.Show("Igrac je registrovan.");
        }

        public override void punoletan()
        {
            if (godine >= 18)
                MessageBox.Show("Igrac je punoletan i moze samostalno potpisati ugovor.","Punoletstvo");
            else
                MessageBox.Show("Igrac nije punoletan i ne moze samostalno potpisati ugovor.","Punoletstvo");
        }

        public void dodatno()
        {
            if (pozicija == "Plejmejker" && visina >= 185 && visina <= 195)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je prosecne visine za svoju poziciju.");
            else if (pozicija == "Plejmejker" && visina < 185)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je ispodprosecne visine za svoju poziciju.");
            else if (pozicija == "Plejmejker" && visina > 195)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je nadprosecne visine za svoju poziciju.");
            else if (pozicija == "Bek" && visina >= 195 && visina <= 200)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je prosecne visine za svoju poziciju.");
            else if (pozicija == "Bek" && visina < 195)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je ispodprosecne visine za svoju poziciju.");
            else if (pozicija == "Bek" && visina > 200)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je nadprosecne visine za svoju poziciju.");
            else if (pozicija == "Krilo" && visina >= 200 && visina <= 205)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je prosecne visine za svoju poziciju.");
            else if (pozicija == "Krilo" && visina < 200)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je ispodprosecne visine za svoju poziciju.");
            else if (pozicija == "Krilo" && visina > 205)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je nadprosecne visine za svoju poziciju.");
            else if (pozicija == "Krilni centar" && visina >= 205 && visina <= 208)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je prosecne visine za svoju poziciju.");
            else if (pozicija == "Krilni centar" && visina < 205)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je ispodprosecne visine za svoju poziciju.");
            else if (pozicija == "Krilni centar" && visina > 208)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je nadprosecne visine za svoju poziciju.");
            else if (pozicija == "Centar" && visina >= 208 && visina <= 212)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je prosecne visine za svoju poziciju.");
            else if (pozicija == "Centar" && visina < 208)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je ispodprosecne visine za svoju poziciju.");
            else if (pozicija == "Centar" && visina > 212)
                MessageBox.Show("Visina: " + visina + "\n\nPozicija: " + pozicija + "\n\nIgrac je nadprosecne visine za svoju poziciju.");
            else
                MessageBox.Show("GRESKA!");
            punoletan();
        }
    }
}
