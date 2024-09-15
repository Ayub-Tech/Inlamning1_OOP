using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1_OOP.Polymorphism
{
    // Basklass ElektroniskEnhet
    public class ElektroniskEnhet
    {
        public string Namn { get; set; }

        // Virtuell metod som kan överskrivas i underklasser
        public virtual void Starta()
        {
            Console.WriteLine($"Den elektroniska enheten {Namn} startar.");
        }
    }

    // Underklass Laptop
    public class Laptop : ElektroniskEnhet
    {
        public override void Starta()
        {
            Console.WriteLine($"Laptop {Namn} startar med en strömbrytare.");
        }
    }

    // Underklass Mobiltelefon
    public class Mobiltelefon : ElektroniskEnhet
    {
        public override void Starta()
        {
            Console.WriteLine($"Mobiltelefon {Namn} startar med en knapptryckning.");
        }
    }

    // Underklass Smartklocka
    public class Smartklocka : ElektroniskEnhet
    {
        public override void Starta()
        {
            Console.WriteLine($"Smartklocka {Namn} startar med svep på skärmen.");
        }
    }
}
