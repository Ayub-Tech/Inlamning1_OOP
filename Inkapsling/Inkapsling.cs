using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1_OOP.NewFolder
{
    // Bas- och Underklasser med inkapsling

    public class ElektroniskEnhet
    {
        // Privata attribut
        private string namn;
        private int batteriKapacitet;

        // Konstruktor för att initialisera enheten
        public ElektroniskEnhet(string namn, int batteriKapacitet)
        {
            this.namn = namn;
            this.batteriKapacitet = batteriKapacitet;
        }

        // Offentlig metod för att sätta enhetens namn
        public void SättNamn(string namn)
        {
            this.namn = namn;
        }

        // Offentlig metod för att få enhetens namn
        public string HämtaNamn()
        {
            return namn;
        }

        // Offentlig metod för att sätta batterikapacitet
        public void SättBatteriKapacitet(int kapacitet)
        {
            if (kapacitet >= 0 && kapacitet <= 100)
            {
                batteriKapacitet = kapacitet;
            }
            else
            {
                Console.WriteLine("Batterikapaciteten måste vara mellan 0 och 100.");
            }
        }

        // Offentlig metod för att få batterikapaciteten
        public int HämtaBatteriKapacitet()
        {
            return batteriKapacitet;
        }

        // Virtuell metod för att starta enheten
        public virtual void Starta()
        {
            Console.WriteLine($"Den elektroniska enheten {namn} startar.");
        }
    }

    // Underklass Laptop
    public class Laptop : ElektroniskEnhet
    {
        public Laptop(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet)
        {
        }

        public override void Starta()
        {
            Console.WriteLine($"Laptop {HämtaNamn()} startar med en strömbrytare.");
        }
    }

    // Underklass Mobiltelefon
    public class Mobiltelefon : ElektroniskEnhet
    {
        public Mobiltelefon(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet)
        {
        }

        public override void Starta()
        {
            Console.WriteLine($"Mobiltelefon {HämtaNamn()} startar med en knapptryckning.");
        }
    }

    // Underklass Smartklocka
    public class Smartklocka : ElektroniskEnhet
    {
        public Smartklocka(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet)
        {
        }

        public override void Starta()
        {
            Console.WriteLine($"Smartklocka {HämtaNamn()} startar med svep på skärmen.");
        }
    }
}
