using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Bus bus = new Bus();
            Trein trein = new Trein();

            Persoon daan = new Persoon("Daan");
            Persoon tim = new Persoon("Tim");

            bus.Instappen(tim);
            bus.Instappen(daan);

            double gemLeeftijdBus = bus.GetGemiddeldeLeeftijd();
            double gemLeeftijdTrein = trein.GetGemiddeldeLeeftijd();

            Console.WriteLine($"Gem leeftijd bus: {gemLeeftijdBus}");
            //Console.WriteLine($"Gem leeftijd (8) trein: {gemLeeftijdTrein}");
            Console.ReadLine();
        }
    }
}