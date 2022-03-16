using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Masina
    {

        private string marca;
        private string model;
        private string an_fabricatie;
        private string culoare;
        private string nr_inmatriculare;
        private string cutie_viteza;
        private int nr_portiere;
        private int nr_locuri;
        private float capacitate_cilindrica;
        private string tip_carburant;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string An_fabricatie
        {
            get { return An_fabricatie; }
            set { an_fabricatie = value; }
        }
        public String Culoare
        {
            get { return culoare; }
            set { culoare = value; }
        }
        public string Nr_inmatriculare
        {
            get { return nr_inmatriculare; }
            set { nr_inmatriculare = value; }
        }
        public string Cutie_viteza
        {
            get { return cutie_viteza; }
            set { cutie_viteza = value; }
        }
        public int Nr_portiere
        {
            get { return nr_portiere; }
            set { nr_portiere = value; }
        }
        public int Nr_locuri
        {
            get { return nr_locuri; }
            set { nr_locuri = value; }
        }
        public float Capacitate_cilindrica
        {
            get { return capacitate_cilindrica; }
            set { capacitate_cilindrica = value; }
        }
        public string Tip_Carburant
        {
            get { return tip_carburant; }
            set { tip_carburant = value; }
        }
        public Masina()
        {
            marca = "NULL";
            model = "NULL";
            culoare = "NULL";
            nr_inmatriculare = "NULL";
            an_fabricatie = "NULL";
            cutie_viteza = "NULL";
            nr_portiere = 4;
            nr_locuri = 5;
            capacitate_cilindrica = 0.0f;
            tip_carburant = "NULL";
        }

        public Masina(string _marca, string _model, string _culoare, string _nr_inmatriculare, string _an_fabricatie, string _cutie_viteza, int _nr_portiere, int _nr_locuri, float _capacitate_cilindrica, string _tip_carburant)
        {
            marca = _marca;
            model = _model;
            culoare = _culoare;
            nr_inmatriculare = _nr_inmatriculare;
            an_fabricatie = _an_fabricatie;
            cutie_viteza = _cutie_viteza;
            nr_portiere = _nr_portiere;
            nr_locuri = _nr_locuri;
            capacitate_cilindrica = _capacitate_cilindrica;
            tip_carburant = _tip_carburant;
        }


        public void get_masina()
        {
            Console.WriteLine("Marca:                   \n", marca);
            Console.WriteLine("Model:                   \n", model);
            Console.WriteLine("Culoare:                 \n", culoare);
            Console.WriteLine("Numar de inmatriculare:  \n", nr_inmatriculare);
            Console.WriteLine("Anul fabricatiei:        \n", an_fabricatie);
            Console.WriteLine("Cutia de viteze:         \n", cutie_viteza);
            Console.WriteLine("Numar de portiere:       \n", nr_portiere);
            Console.WriteLine("Numar de locuri:         \n", nr_locuri);
            Console.WriteLine("Capacitatea cilindrica:  \n", capacitate_cilindrica);
            Console.WriteLine("Tipul carburantului:     \n", tip_carburant);
        }
      

    }

}
