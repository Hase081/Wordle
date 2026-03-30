namespace wordle_test
{
    internal class Program
    {

        public class Wordle
        {
            public char Letter1 { get; set; }

            public char Letter2 { get; set; }

            public char Letter3 { get; set; }

            public char Letter4 { get; set; }

            public char Letter5 { get; set; }

            public Wordle(char letter1, char letter2, char letter3, char letter4, char letter5)
            {
                letter1 = Letter1;
                letter2 = Letter2;
                letter3 = Letter3;
                letter4 = Letter4;
                letter5 = Letter5;
            }

        }
        static void Main(string[] args)
        {
            string[] szavak = File.ReadAllLines("words.txt");


            /*for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(szavak[i]);  KÉPES BEOLVASNI SZAVAKAT A WORDS.TXTBÖL
            }
            */

            Console.WriteLine(szavak[1][2]); 
            /*majd megcsinaljuk hogy random képes legyen kiválasztani egy szót és mentse is el hogy az hányadik szó
             * azután eltudjuk érni az összes ebtüjét annak a szónak egy for ciklussal,
             switch case-t fogok majd használni arra hogy megnézze van e olyan betu a szóban és hogy jó helyen van e,
            azt nem tudom még hogyan fogom megoldani hogy egy betü-t csak egyszer jelöljön ki 
            (például a szóban van 1 P,mi tippelunk egy 2 P-s szót és erre kijelöli mind a kettőt  vagy sárgának vagy az eggyiket zöldnek)*/
        }
    }
}
