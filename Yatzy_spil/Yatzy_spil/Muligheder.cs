using System;
namespace Yatzy_spil
{

    public class Muligheder : Bæger
    {
        /*public Bæger baegerMulighed;
        public Muligheder(Bæger b)
        { baegerMulighed = b; }*/

        private int HvorMangeAfEnSlags(int slags) //opretter en metode til at finde ud af hvor mange terninger der er ens. i () er "slags" defineret som en int varibel, som senere kan skiftes ud med et tal
        {
            int antal = 0;

            if (terning1.Oejne == slags) //tjekker / sammenligner om terning1 er lig med det tal vi nu vil tjekke. 1'ere hvis nu vi havde sat "1" i slags
            { antal = antal + 1; } //hvis terning1 = det tal vi vil tjekke (fx 1'ere), så tæller den 1 op.
            if (terning2.Oejne == slags)
            { antal = antal + 1; } //osv. ned af.
            if (terning3.Oejne == slags)
            { antal = antal + 1; }
            if (terning4.Oejne == slags)
            { antal = antal + 1; }
            if (terning5.Oejne == slags)
            { antal = antal + 1; } //husk at "antal" ændrer sig på vej ned i koden

            return antal; //hvis nu der fx var 3 1'ere, så ville den returne "3" (hvis vi skulle tjekke 1'erne)
        }
    }
}
/*Bæger baegerMulighed;
      public Muligheder(Bæger b) { baegerMulighed = b; }*/

//public bæger baegerMulighed;
//public Muligheder(Baeger b) {baegerMulighed = b;} (//for at undgå, at lave to sæt terninger så kalder vi baegerklassen)
//ved brug af "new" dannes to sæt terninger frem for at man kalder på eksisterende terninger

/*public Bæger mitbaeger = new Bæger(); //opretter lige et nyt bæger fra bægerklassen*/
