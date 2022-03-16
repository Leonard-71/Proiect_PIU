using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Persoana
    {
        private string nume;
        private string prenume;
        private string cnp;
        Adresa adresa;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        private string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public Persoana()
        {
            nume = "NULL";
            prenume = "NULL";
            cnp = "NULL";
        }

        public Persoana(string _nume, string _prenume, string _cnp)
        {
            nume = _nume;
            prenume = _prenume;
            cnp = _cnp;
        }

        void get_Persoana()
        {
            Console.WriteLine("Nume:\t\n", nume);
            Console.WriteLine("Prenume:\t\n", prenume);
            Console.WriteLine("Cnp:\t\t\n", cnp);
        }
       
    }
}
