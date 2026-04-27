namespace wordle_test
{
    internal class Program
    {
        public static string RandomWord(List<string> words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Count);
            return words[randomIndex];

        }

        public static void Check(string word, string guess)
        {
            

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == word[i])
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(guess[i]);
                    Console.ResetColor();

                }
                else if (word.Contains(guess[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(guess[i]);
                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(guess[i]);
                    Console.ResetColor();


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

            string Rszavak = RandomWord(szavak); // ez vissza adja a random szót de nem írja ki



            int guess_amount = 1;


            while (guess_amount <= 5)
            {
                
                Console.WriteLine("Enter Guess: ");


                string? Guess = Console.ReadLine();


                Check(Rszavak, Guess);
                Console.WriteLine("\n");
                guess_amount++;


                if (Rszavak == Guess)
                {
                    Console.WriteLine($"Sikerült. {guess_amount} próbálkozás alatt ");
                }
                else if (guess_amount <= 5)
                {
                    Console.WriteLine($"Nem sikerült. van még {6-guess_amount} lehetőséged");
                }
                else
                {
                    Console.WriteLine($"Nem sikerült. kifogytál a lehetőségekből");
                }
            }



            
 
            
            

            


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