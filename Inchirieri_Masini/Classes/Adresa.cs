using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Adresa
    {
        private string strada;
        private string localitate;
        private string tara;
        private string judet;
        private string cod_postal;
        private string numar;

        public string Strada
        {
            get { return strada; }
            set { strada = value; }
        }
        public string Localitate
        {
            get { return localitate; }
            set { localitate = value; }
        }
        public string Tara
        {
            get { return tara; }
            set { tara = value; }
        }
        public string Judet
        {
            get { return judet; }
            set { judet = value; }
        }
        public string Cod_postal
        {
            get { return cod_postal; }
            set { cod_postal = value; }
        }
        public string Numar
        {
            get { return numar; }
            set { numar = value; }
        }
        public Adresa()
        {
            strada = "NULL";
            localitate = "NULL";
            tara = "NULL";
            judet = "NULL";
            cod_postal = "NULL";
            numar = "NULL";
        }

       public Adresa(string _localitate, string _judet, string _tara, string _strada, string _numar, string _cod_postal)
        {
            localitate = _localitate;
            judet = _judet;
            tara = _tara;
            strada = _strada;
            numar = _numar;
            cod_postal = _cod_postal;

        }

    }
}
