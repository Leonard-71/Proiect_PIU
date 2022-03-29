using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Inchirieri
{
    public class Masina
    {
        private string marca;
        private string model;
        private string data_fabricatie;
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
        public string Data_fabricatie
        {
            get { return data_fabricatie; }
            set { data_fabricatie = value; }
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
            data_fabricatie = "NULL";
            cutie_viteza = "NULL";
            nr_portiere = 0;
            nr_locuri = 0;
            capacitate_cilindrica = 0.0f;
            tip_carburant = "NULL";
        }

        public Masina(string _marca, string _model, string _culoare, string _nr_inmatriculare,
            string _data_fabricatie, string _cutie_viteza, int _nr_portiere, int _nr_locuri, float _capacitate_cilindrica, string _tip_carburant)
        {
            marca = _marca;
            model = _model;
            culoare = _culoare;
            nr_inmatriculare = _nr_inmatriculare;
            data_fabricatie =_data_fabricatie;
            cutie_viteza = _cutie_viteza;
            nr_portiere = _nr_portiere;
            nr_locuri = _nr_locuri;
            capacitate_cilindrica = _capacitate_cilindrica;
            tip_carburant = _tip_carburant;
        }

        public void CitireMasinaTastatura()
        {
            Console.Write("Introduceti marca masinii: ");
            marca = Console.ReadLine();     
            Console.Write("Introduceti modelul masinii:  ");
            model = Console.ReadLine();          
            Console.Write("introduceti culoarea masinii:  ");
            culoare = Console.ReadLine();           
            Console.Write("Introduceti numarul de inmatriculare:  ");
            nr_inmatriculare = Console.ReadLine();          
            Console.Write("Introduceti data fabricatiei:  ");
            Data_fabricatie = Console.ReadLine();           
            Console.Write("Introduceti cutia de viteza a masinii:  ");
            cutie_viteza = Console.ReadLine();           
            Console.Write("Introduceti numarul de portiere ale masinii:  ");
            nr_portiere =int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de locuri ale masinii:  ");
            nr_locuri = int.Parse(Console.ReadLine());           
            Console.Write("Introduceti capacitatea cilindrica a motorului:  ");
            capacitate_cilindrica = float.Parse(Console.ReadLine());          
            Console.Write("Introduceti tipul de carburant:  ");
            tip_carburant = Console.ReadLine();
        }
        public string AfisareMasina() 
        {
          return Marca + "\t" + Model + "\t"+ Culoare + "\t" + Nr_inmatriculare + "\t" + Data_fabricatie + 
                "\t" +Cutie_viteza + "\t\t" + Nr_portiere + "\t" + Nr_locuri + "\t" + Capacitate_cilindrica + "\t" + Tip_Carburant +"\n"; 
        }

        public void ScriereMasinaFisier()
        {
            StreamWriter outputFile = File.CreateText("E:\\Proiect\\Masina.txt");
            outputFile.Write(marca + " ");
            outputFile.Write(model + " ");
            outputFile.Write(culoare + " ");
            outputFile.Write(nr_inmatriculare + " ");
            outputFile.Write(data_fabricatie + " ");
            outputFile.Write(cutie_viteza + " ");
            outputFile.Write(nr_portiere +" ");
            outputFile.Write(nr_locuri +" ");
            outputFile.Write(capacitate_cilindrica+ " ");
            outputFile.WriteLine(tip_carburant);
            outputFile.Close();
        }
        public Masina CitireMasinaFisier()
        {
            Masina masina = new Masina();
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Masina.txt"))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    string[] valoare_fisier = linieFisier.Split(' ');
                    marca = valoare_fisier[0];
                    model = valoare_fisier[1];
                    culoare = valoare_fisier[2];
                    nr_inmatriculare = valoare_fisier[3];
                    data_fabricatie = valoare_fisier[4];
                    cutie_viteza = valoare_fisier[5];
                    nr_portiere = int.Parse(valoare_fisier[6]);
                    nr_locuri = int.Parse(valoare_fisier[7]);
                    capacitate_cilindrica = float.Parse(valoare_fisier[8]);
                    tip_carburant = valoare_fisier[9];
                    masina = new Masina(marca, model, culoare, nr_inmatriculare, data_fabricatie,cutie_viteza, nr_portiere, nr_locuri, capacitate_cilindrica, tip_carburant);
                        return masina;
                }
            }
            Masina masina_invalid = new Masina();
            return masina_invalid;
        }
        public Masina CautaMasini(string marcaCautata)
        {
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Masina.txt"))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                { 
                    string[] valoareLinie= linieFisier.Split(' ');
                    int comp = String.Compare(valoareLinie[0], marcaCautata);
                    if(comp == 0)
                        Console.WriteLine(linieFisier);
                }
            }
            return null;
        }
    }
}
