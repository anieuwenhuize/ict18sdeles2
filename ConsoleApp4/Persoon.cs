using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Persoon
    {
        private int leeftijd;
        private string naam;

        public Persoon(string naam)
        {
            this.leeftijd = (naam.Length * 2) % 87;
            this.naam = naam;
        }

        public int GetLeeftijd()
        {
            return this.leeftijd;
        }

        public string GetNaam()
        {
            return this.naam;
        }
    }
}
