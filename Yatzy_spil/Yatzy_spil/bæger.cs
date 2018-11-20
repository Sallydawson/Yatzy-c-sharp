using System;
namespace Yatzy_spil
{
    public class Bæger
    {
        public Terning terning1 = new Terning(); //opretter objekt af typen terning fra terning klassen - vi new'er terning klassen op til en ny type
        public Terning terning2 = new Terning(); //(fortsat) metoden bliver aktiveret og vi får et nyt objekt
        public Terning terning3 = new Terning(); //(fortsat) vi vil have en nye variabel som hedder terning1 - den skal indeholde objekter fra terningklassen
        public Terning terning4 = new Terning();
        public Terning terning5 = new Terning();

        public void RystBaeger() //ny metode 
        { /*vi har lige oprettet 5 terninger af typen terning fra terningklassen. 
        KastTerning er en metode fra terningklassen, som vi kalder frem her, for at bruge den på alle terningerne, så vi får en ny metode der ryster bægeret med alle terningerne */
            terning1.KastTerning();
            terning2.KastTerning();
            terning3.KastTerning();
            terning4.KastTerning();
            terning5.KastTerning();
        }


        //KOMBINATIONER

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


        //Hvor mange af en slags 1-6:

        public int SumEttere () //I nedenstående sætter vi så en variabel / parameter (1-6) ind i metoden HvorMangeAfEnSlags, for at tjekke alle mulighederne
        {
            return HvorMangeAfEnSlags(1) * 1; //return hvor mange 1'ere der er og summen af dem
        }

        public int SumToere()
        {
            return HvorMangeAfEnSlags(2) * 2; //return hvor mange 2'ere der er og summen af dem
        }

        public int SumTreere()
        {
            return HvorMangeAfEnSlags(3) * 3;
        }

        public int SumFiere()
        {
            return HvorMangeAfEnSlags(4) * 4;
        }

        public int SumFemmere()
        {
            return HvorMangeAfEnSlags(5) * 5;
        }

        public int SumSeksere()
        {
            return HvorMangeAfEnSlags(6) * 6;
        }

        //Par

        public int SumEtPar() //metode til at finde summen af et par
        { //bruger for-loop, sætter i til 6 fordi vi vil have det højeste par. Så den starter ved 6
            for (int flow = 6; flow >= 1; --flow) //i går 1 ned hver gang loopet bliver kørt. Så længe i er større end eller lig med 1, så kører loopet
            { //hvis den så finder et par - ved at se om HvorMangeAfEnSlags er større end 1
                if (HvorMangeAfEnSlags(flow) > 1)
                { return flow * 2; } //så udregnes pointene af parret
            }
            return 0; //hvis den går hele vejen igennem til den når under 1, så returnere den 0 - fordi der ikke var nogle point
        }

        // public int SumToPar() //MANGLER


        //3 og 4 ens

        public int SumTreEns()
        {
            for (int flow1 = 6; flow1 >= 1; --flow1)
            {
                if (HvorMangeAfEnSlags(flow1) > 2)
                { return flow1 * 3; }
            }
                return 0;
        }

        public int SumFireEns()
        {
            for (int flow2 = 6; flow2 >= 1; --flow2)
            {
                if (HvorMangeAfEnSlags(flow2) > 3)
                { return flow2 * 4; }
            }
            return 0;
        }

        //Straight

        public int SumLilleStraight()
        {
            if (SumEtPar() > 1 || HvorMangeAfEnSlags(6) == 1) //HMMMM ??
            { return 0; }
        
            return 15;
        }


        public int SumStorStraight()
        {
            if (SumEtPar() > 1 || HvorMangeAfEnSlags(1) == 1)
            { return 0; }
            
            return 20;
        }


    }


    
}
