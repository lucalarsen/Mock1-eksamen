using System;

namespace ClassLibraryBilAfgift
{
    /// <summary>
    /// class som indeholder afgift metoder
    /// </summary>
    public class Afgift
    {
        private decimal bilunder200000 = 200000;
        private decimal resultat = 0;

        /// <summary>
        /// metode til at udregne bilafgift på personbiler
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public decimal BilAfgift(decimal pris)
        {
            
            if (pris <= bilunder200000)
            {
                decimal endeligPris = pris * 0.85m;
                return resultat = endeligPris;
            }
            else
            {
                decimal endeligPris = (pris * 1.50m) - 130000m;
                return resultat = endeligPris;
            }


        }
        /// <summary>
        /// metode til at udregne bilafgift på elbiler med hjælp fra Bilafgift metoden
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public decimal ElbilAfgift(decimal pris)
        {
            decimal fullPris = BilAfgift(pris) * 0.20M;
            return resultat = fullPris;
        }

    }
}
