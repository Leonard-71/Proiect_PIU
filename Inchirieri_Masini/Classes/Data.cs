using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Inchirieri
{

    public class Data
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ' ';
        private const char SEPARATOR_SECUNDAR_FISIER = ';';
        private int zi;
        private int luna;
        private int an;

        public int Zi { get; set; }
        public int Luna { get; set; }
        public int An { get; set; }
        public Data()
        {
            zi = 0;
            luna = 0;
            an = 0;
        }
        public Data(int _zi, int _luna, int _an)
        {
            zi = _zi;
            luna = _luna;
            an = _an;
        }

        public enum Zile
        {
            Luni=1,
            Marti=2,
            Miercuri=3,
            Joi=4,
            Vineri=5,
            Sambata=6,
            Duminica=7
        }
       
        public enum Luni
        {
           Ianuarie=1,
           Februarie=2,
           Martie=3,
           Aprilie=4,
           Mai=5,
           Iunie=6,
           Iulie=7,
           August=8,
           Septembrie=9,
           Octombrie=10,
           Noiembrie=11,
           Decembrie=12
        }

        public void CitireDataTastatura()
        {
            Console.Write("Introduceti ziua:  ");
            zi = int.Parse(Console.ReadLine());
            Console.Write("Introduceti luna:  ");
            luna= int.Parse(Console.ReadLine());
            Console.Write("Introduceti anul:  ");
            an = int.Parse(Console.ReadLine());
        }
        public string AfisareData()
        {
            return Zi + "." + Luna + "." + An + "\n";
        }
        public void ScriereDataFisier()
        {
            StreamWriter outputFile = File.CreateText("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\Data.txt");
            outputFile.Write(zi + ".");
            outputFile.Write(luna + ".");
            outputFile.WriteLine(an);
            outputFile.Close();
        }
        
        public Data CitireDataFisier()
        {
           
            Data data= new Data();
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect PIU-Filip Leonard\\Rep_proiect\\Clona\\Proiect_PIU\\Inchirieri_Masini\\Fisiere_text\\Data.txt"))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    var valoare_fisier = linieFisier.Split('.');
                    zi = int.Parse(valoare_fisier[0]);
                    luna = int.Parse(valoare_fisier[1]);
                    an = int.Parse(valoare_fisier[2]);
                    data = new Data(zi, luna, an);
                    if (data.zi == zi && data.luna == luna && data.an == an)
                        return data;
                }
            }
            Data data_invalid = new Data();
            return data_invalid;         
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectDataPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                Zi.ToString(),
                Luna.ToString(),
                An.ToString());

            return obiectDataPentruFisier;
        }

    }
}
