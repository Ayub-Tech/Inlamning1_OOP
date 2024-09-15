using Inlämningsuppgift.Arv;

internal class Program
{
    static void Main(string[] args)
    {
        // Skapar en elektronisk enhet
        ElektroniskEnhet enhet1 = new ElektroniskEnhet();
        enhet1.Namn = "Laptop";
        enhet1.BatteriKapacitet = 50;
        enhet1.VisaBatteriStatus();  // Output: Enheten Laptop har 50% batteri kvar.
        enhet1.Ladda();              // Output: Den här enheten kan laddas.

        // Skapar en mobiltelefon
        Mobiltelefon telefon1 = new Mobiltelefon();
        telefon1.Namn = "iPhone";
        telefon1.BatteriKapacitet = 80;
        telefon1.Operativsystem = "iOS";
        telefon1.VisaBatteriStatus();  // Output: Enheten iPhone har 80% batteri kvar.
        telefon1.Ladda();              // Output: Mobiltelefonen iPhone laddar snabbt med iOS!
        telefon1.RingSamtal();         // Output: Mobiltelefonen iPhone ringer ett samtal.
    }
}
 