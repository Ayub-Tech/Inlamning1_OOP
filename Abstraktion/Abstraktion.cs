using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1_OOP.Abstraktion
{
    // Abstrakt basklass ElektroniskEnhet
    public abstract class ElektroniskEnhet
    {
        protected string Namn { get; set; }
        protected int BatteriKapacitet { get; set; }

        protected ElektroniskEnhet(string namn, int batteriKapacitet)
        {
            Namn = namn;
            BatteriKapacitet = batteriKapacitet;
        }

        public void VisaInfo() =>
            Console.WriteLine($"Enhetens namn: {Namn}, Batterikapacitet: {BatteriKapacitet}%");

        public void SättBatteriKapacitet(int kapacitet) =>
            BatteriKapacitet = kapacitet >= 0 && kapacitet <= 100 ? kapacitet : BatteriKapacitet;

        public abstract void Starta();
    }

    public class Laptop : ElektroniskEnhet
    {
        public Laptop(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet) { }

        public override void Starta() =>
            Console.WriteLine($"Laptop {Namn} startar med en strömbrytare.");
    }

    public class Mobiltelefon : ElektroniskEnhet
    {
        public Mobiltelefon(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet) { }

        public override void Starta() =>
            Console.WriteLine($"Mobiltelefon {Namn} startar med en knapptryckning.");
    }

    public class Smartklocka : ElektroniskEnhet
    {
        public Smartklocka(string namn, int batteriKapacitet)
            : base(namn, batteriKapacitet) { }

        public override void Starta() =>
            Console.WriteLine($"Smartklocka {Namn} startar med svep på skärmen.");
    }
}