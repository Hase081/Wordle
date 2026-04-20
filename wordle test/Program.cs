namespace wordle_test
{
    internal class Program
    {
        public static string RandomWord( List<string> words )
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Count);
            return words[randomIndex];
        }


        public class Wordle
        {


            public class Guesses
            {
                List<string> Guess = new List<string>();

                public void Guessing(string word)
                {

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 5)
                        {
                            if (char.IsLetter(word[i]) == true)
                            {
                                Guess.Add(word);
                                //innen összehasonlitás kéne a random szóval (még egy methódus)
                            }
                            else
                            {
                                Console.WriteLine("Nem alkalmas szó!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nem alkalmas szó!");
                        }

                    }


                }
            }

        }

        


        static void Main(string[] args)
        {
            List<string> szavak = new List<string>();
            string[] szavak_tomb = File.ReadAllLines("words.txt");

            for (int i = 0; i < szavak_tomb.Length; i++)
            {
                szavak.Add(szavak_tomb[i]);
            }

            RandomWord(szavak);


            /*for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(szavak[i]); // KÉPES BEOLVASNI SZAVAKAT A WORDS.TXTBÖL
            }
            */

            //Console.WriteLine(szavak[1][2]);  pl 2. szó 3. betüje
            /*majd megcsinaljuk hogy random képes legyen kiválasztani egy szót és mentse is el hogy az hányadik szó
             * azután eltudjuk érni az összes ebtüjét annak a szónak egy for ciklussal,
             switch case-t fogok majd használni arra hogy megnézze van e olyan betu a szóban és hogy jó helyen van e,
            azt nem tudom még hogyan fogom megoldani hogy egy betü-t csak egyszer jelöljön ki 
            (például a szóban van 1 P,mi tippelunk egy 2 P-s szót és erre kijelöli mind a kettőt  vagy sárgának vagy az eggyiket zöldnek)*/
        }
    }
}