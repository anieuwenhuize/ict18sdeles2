using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Voertuig
    {
        // 0. persoon moet een leeftijd hebben V
        // 1. personen moeten kunnen instappen
        // 2. personen moeten kunnne uitstappen
        // 3. de gemiddelde leeftijd van de inzittenden 
        //      berekenen

        private ArrayList inzittenden;

        public Voertuig()
        {
            this.inzittenden = new ArrayList();
        }

        public void Instappen(Persoon persoon)
        {
            this.inzittenden.Add(persoon);
        }

        public Persoon Uitstappen()
        {
            return new Persoon("Piet");
                // persoon moet uit 'lijst' worden verwijderd
        }

        private int GetAantalInzittenden()
        {
            return this.inzittenden.Count;
        }

        private int GetTotaalLeeftijd()
        {
            int totaal = 0;

            foreach(Persoon persoon in this.inzittenden) {
                totaal += persoon.GetLeeftijd();
            }
            return totaal;
        }

        public double GetGemiddeldeLeeftijd()
        {
            if (this.GetAantalInzittenden() == 0) return 0;
            return this.GetTotaalLeeftijd() / this.GetAantalInzittenden();
        }
    }
}
