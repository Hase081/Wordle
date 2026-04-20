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
            public void Guess(string guess)
            {
                int guesses = 0;


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

            RandomWord(szavak); // ez vissza adja a random szót de nem írja ki

            
            


            /*for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(szavak[i]); // KÉPES BEOLVASNI SZAVAKAT A WORDS.TXTBÖL
            }
            */ 
            /*
             *jelengleg csak arra képes hogy a words txtböl kiválaszt egy random szót 
             */
        }
    }
}