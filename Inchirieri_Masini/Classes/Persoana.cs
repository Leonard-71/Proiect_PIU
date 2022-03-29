using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Inchirieri
{
    public class Persoana
    {
        private string nume;
        private string prenume;
        private string cnp;
        //Adresa adresa;

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

        public void CitirePersoanaTastatura()
        {
            Console.Write("Nume:  ");
            nume = Console.ReadLine();
            Console.Write("Prenume:  ");
            prenume = Console.ReadLine();
            Console.Write("Cnp:  ");
            cnp = Console.ReadLine();
        }
        public string AfisarePersoana()
        {
            return Nume + "\t" + Prenume + "\t" + Cnp + "\n";
        }
        public void ScrierePersoaneFisier()
        {
            StreamWriter outputFile = File.CreateText("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Persoane.txt");
            outputFile.Write(nume + " ");
            outputFile.Write(prenume + " ");
            outputFile.WriteLine(cnp);
            outputFile.Close();
        }
        public Persoana CitirePersoanaFisier()
        {
            Persoana persoana = new Persoana( );
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Persoane.txt"))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    var valoare_fisier = linieFisier.Split(' ');
                    nume =valoare_fisier[0];
                    prenume =valoare_fisier[1];
                    cnp =valoare_fisier[2];
                    persoana = new Persoana(nume, prenume, cnp);
                    if (persoana.nume == nume && persoana.prenume == prenume && persoana.cnp == cnp)
                        return persoana;
                }
            }        
            Persoana persoana_invalid = new Persoana();
            return persoana_invalid; 
        }

    }
}
