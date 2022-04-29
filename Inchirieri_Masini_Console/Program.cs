using Inchirieri;
using Inchirieri_Masini;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

Persoana  p1 = new Persoana();
Persoana  p2 = new Persoana();

Masina    m1 = new Masina();
Masina    m2 = new Masina();

Data      d1 = new Data();
Data      d2 = new Data();

Adresa    a1 = new();
Adresa    a2 = new();
/*
//  PERSOANA  
p1.CitirePersoanaTastatura();
p1.ScrierePersoaneFisier();
p2.CitirePersoanaFisier();
Console.WriteLine(p1.AfisarePersoana());
Console.WriteLine(p2.AfisarePersoana());

Persoana persoana = new Persoana();
Console.WriteLine(persoana.CautaPersoana("Leonard"));
*/
//  Masina 
//m1.CitireMasinaTastatura();
//m1.ScriereMasinaFisier();
//m2.CitireMasinaFisier();



Masina masina = new Masina();
Console.WriteLine(masina.AfisareMasina());
/*
Masina masina = new Masina();
<<<<<<< Updated upstream
Console.WriteLine(masina.CautaMasini("Volvo"));
=======
//Console.WriteLine(masina.CautaMasini("Volvo"));

*/

     // Data 
d1.CitireDataTastatura();
d1.ScriereDataFisier();
d2.CitireDataFisier();
Console.WriteLine(d1.AfisareData());
Console.WriteLine(d2.AfisareData());

      //Adresa
a1.CitireAdresaTastatura();
a1.ScriereAdresaFisier();
a2.CitireAdresaFisier();
Console.WriteLine(a1.AfisareAdresa());
Console.WriteLine(a2.AfisareAdresa());
