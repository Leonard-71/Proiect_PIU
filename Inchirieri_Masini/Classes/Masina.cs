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
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';
        private const char SEPARATOR_SECUNDAR_FISIER =' ';
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
        private string linieFisier;

        public string Marca { get; set; }
        public string Model { get; set; }
        public string Data_fabricatie { get; set; }
        public String Culoare { get; set; }
        public string Nr_inmatriculare { get; set; }
        public string Cutie_viteza { get; set; }
        public int Nr_portiere { get; set; }
        public int Nr_locuri { get; set; }
        public float Capacitate_cilindrica { get; set; }
        public string Tip_Carburant { get; set; }

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

        public enum CuloareMasina
        {
            Negru = 1,
            Alb = 2,
            Albastru = 3,
            Gri = 4,
            Rosu = 5,
            Maro = 6,
            Verde = 7
        }

        public enum Optiuni
        {
            Aer_conditionat = 1,
            Navigatie = 2,
            IncalzireScaune = 3,
            OglinziRabatabile =4
           
        }



        public Masina(string linieFisier)
        {
            this.linieFisier = linieFisier;
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
                    using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\Masina.txt"))
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
                    using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\Masina.txt"))
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
                

        
        public string ConversieLaSir_PentruFisier()
        {
          
           
            string obiectMasisinaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (Marca ?? " NECUNOSCUT "),
                (Model ?? " NECUNOSCUT "),
                (Culoare ?? " NECUNOSCUT "),
                (Nr_inmatriculare ?? " NECUNOSCUT "),
                (Data_fabricatie ?? " NECUNOSCUT "),
                (Cutie_viteza ?? " NECUNOSCUT "),
                Nr_portiere.ToString(),
                Nr_locuri.ToString(),
                Capacitate_cilindrica.ToString(),
                Tip_Carburant ?? " NECUNOSCUT ");

            return obiectMasisinaPentruFisier;
        }
    }
}
