using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak
{
    class Klub
    {
        private string naziv;
        private string grad;
        private bool filijala;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public Klub(string naziv, string grad, bool filijala)
        {
            this.naziv = naziv;
            this.grad = grad;
            this.filijala = filijala;
        }
        public void Filijala()
        {
            if (filijala == false)
                MessageBox.Show("Klub nije filijala, vec radi samostalno.");
            else
                MessageBox.Show("Klub je filijala.");            
        }

        public static void stat()
        {
            MessageBox.Show("Klub se sastoji od 12 igraca, strucnog staba i rukovodstva, ali postoje klubovi kojima su navijaci bitinji od svega navedenog.");
        }
    }
}
