
namespace Inlämningsuppgift.Arv
{
    public class ElektroniskEnhet // Huvudklassen för Elektronisk Enhet
    {
        public string Namn;  // Namnet på enheten
        public int BatteriKapacitet;  // Batterikapacitet i %

        public void Ladda()  // Metod
        {
            Console.WriteLine("Den här enheten kan laddas.");
        }

        public void VisaBatteriStatus() // Metod
        {
            Console.WriteLine($"Enheten {Namn} har {BatteriKapacitet}% batteri kvar.");
        }
    }

    public class Mobiltelefon : ElektroniskEnhet // Subklass Mobiltelefon som ärver från ElektroniskEnhet
    {
        public string Operativsystem; // Nya attribut

        public new void Ladda() // Överskriver metoden Ladda
        {
            Console.WriteLine($"Mobiltelefonen {Namn} laddar snabbt med {Operativsystem}!");
        }

        public void RingSamtal() // Ny metod specifik för mobiltelefoner
        {
            Console.WriteLine($"Mobiltelefonen {Namn} ringer ett samtal.");
        }
    }
}




