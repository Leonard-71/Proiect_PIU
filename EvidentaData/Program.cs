
using System.IO;
using Inchirieri;
namespace EvidentaData
{
    public class AdministrareData_FisierText
    {
        private const int NR_MAX_DATE = 50;
        private string numeFisier;

        public AdministrareData_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddData(Data data)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(data.ConversieLaSir_PentruFisier());
            }
        }

        public Data[] GetData(out int nrDate)
        {
           Data [] data = new Data [NR_MAX_DATE];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrDate = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    data[nrDate++] = new Data();
                }
            }

            return data;
        }
    }
}