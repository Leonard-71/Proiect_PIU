using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Inchirieri
{
    public class Adresa
    {
        private string strada;
        private string localitate;
        private string tara;
        private string judet;
        private string cod_postal;
        private string numar;

        public string Strada{get; set;}      
        public string Localitate { get; set;}
        public string Tara { get; set;}
        public string Judet { get; set;}
        public string Cod_postal { get; set;}
        public string Numar { get; set; }

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

        public enum Tari
        {
            Romania = 1,
            Germania = 2,
            Franta = 3,
            Italia = 4,
            Austria = 5,
            Spania = 6
        }

        public enum Judete
        {
            Suceava = 1,
            Iasi = 2,
            Botosani = 3,
            Constanta = 4,
            Bacau = 5,
            Bihor = 6,
            Brasov = 7,
            Cluj = 8,
            Neamt = 9,
            Prahova = 10,
            Sibiu = 11,
            Buzau = 12
        }





        public void CitireAdresaTastatura()
        {
            Console.Write("Localitatea:  ");
            localitate = Console.ReadLine();
            Console.Write("Judet:  ");
            judet = Console.ReadLine();
            Console.Write("Tara:  ");
            tara = Console.ReadLine();
            Console.Write("Strada:  ");
            strada = Console.ReadLine();
            Console.Write("Cod postal:  ");
            cod_postal = Console.ReadLine();
            Console.Write("Numar:  ");
            numar = Console.ReadLine();
        }
        public string AfisareAdresa()
        {
            return Localitate + "\t " + Judet + "\t " + Tara + "\t" + Strada + "\t" + Cod_postal + "\t" + Numar + "\n";
        }

        public void ScriereAdresaFisier()
        {
            StreamWriter outputFile = File.CreateText("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\adresa.txt");
            outputFile.Write(localitate + " ");
            outputFile.Write(judet + " ");
            outputFile.Write(tara + " ");
            outputFile.Write(strada + " ");
            outputFile.Write(cod_postal + " "); 
            outputFile.WriteLine(numar);
            outputFile.Close();
        }

        public Adresa CitireAdresaFisier()
        {
            Adresa adresa = new Adresa();
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\Adresa.txt"))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    var valoare_fisier = linieFisier.Split(' ');
                    localitate = valoare_fisier[0];
                    judet = valoare_fisier[1];
                    tara = valoare_fisier[2];
                    strada = valoare_fisier[3];
                    cod_postal = valoare_fisier[4];
                    numar = valoare_fisier[5];
                    adresa = new Adresa(localitate, judet, tara, strada, cod_postal, numar);
                    if (adresa.localitate == localitate && adresa.judet == judet && adresa.tara == tara && adresa.strada == strada && adresa.cod_postal == cod_postal && adresa.numar == numar)
                        return adresa;
                }
            }
            Adresa adresa_invalid = new Adresa();
            return adresa_invalid;
        }
    }
}
