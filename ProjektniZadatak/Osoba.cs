using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak
{
    abstract class Osoba
    {
        public string ime;
        public string prezime;
        public int godine;


        public Osoba(string ime, string prezime, int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine= godine;
        }

        public virtual void punoletan()
        {
        }
    }
}
