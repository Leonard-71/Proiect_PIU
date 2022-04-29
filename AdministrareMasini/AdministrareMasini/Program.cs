using LibrarieModele;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareStudenti_FisierText
    {
        private const int NR_MAX_Masini = 50;
        private string numeFisier;

        public AdministrareStudenti_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddMasina(Masina masina)
        { 
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(masina.ConversieLaSir_PentruFisier());
            }
        }

        public Masina[] GetMasina(out int nrMasini)
        {
            Masina[] masina = new Masina[NR_MAX_Masini];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrMasini = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    masina[nrMasini++] = new Masina(linieFisier);
                }
            }

            return masina;
        }
    }
}