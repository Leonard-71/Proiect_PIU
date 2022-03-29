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
        private int zi;
        private int luna;
        private int an;

        public int Zi {
            get { return zi; }
            set { zi = value; }
        }
        public int Luna
        {
            get { return luna; }
            set { luna = value; }
        }
        public int An
        {
            get { return an; }
            set { an = value; }
        }
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
            StreamWriter outputFile = File.CreateText("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Data.txt");
            outputFile.Write(zi + ".");
            outputFile.Write(luna + ".");
            outputFile.WriteLine(an);
            outputFile.Close();
        }
        
        public Data CitireDataFisier()
        {
           
            Data data= new Data();
            using (StreamReader streamReader = new StreamReader("E:\\Facultate\\ANUL 2\\SEMESTRUL 2\\Lab PIU-Gaza Felicia\\Proiect pe etape\\Etapa 2\\proiect-piu\\FisiereText\\Data.txt"))
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



    }
}
