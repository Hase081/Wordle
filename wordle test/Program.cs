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
            string betuk = "qwertzuiopasdfghjklzxcvbnm";

            for (int i = 0; i < guess.Length; i++)
            {
                char low_guess = char.ToLower(guess[i]);

                if (!betuk.Contains(low_guess))
                {
                    Console.WriteLine("Érvénytelen karakter!");
                    return;
                }
            }

            if (word.Length != guess.Length)
            {
                Console.WriteLine("Túl hosszú vagy túl rövid a tipp!");
                return;
            }

            char[] wordChars = word.ToCharArray(); 
            char[] guessChars = guess.ToCharArray();

            ConsoleColor[] colors = new ConsoleColor[guess.Length];

            
            for (int i = 0; i < guessChars.Length; i++)
            {
                if (guessChars[i] == wordChars[i])
                {
                    colors[i] = ConsoleColor.Green;
                    wordChars[i] = '0'; // már felhasznált betű
                }
            }

            
            for (int i = 0; i < guessChars.Length; i++)
            {
                if (colors[i] == ConsoleColor.Green)
                    continue; // már zöld

                int index = Array.IndexOf(wordChars, guessChars[i]);
                if (index != -1)
                {
                    colors[i] = ConsoleColor.Yellow;
                    wordChars[index] = '0'; // már felhasznált betű
                }
                else
                {
                    colors[i] = ConsoleColor.DarkGray;
                }
            }

            
            for (int i = 0; i < guessChars.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = colors[i];
                Console.Write(guessChars[i]);
                Console.ResetColor();
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



            int guess_amount = 0;

            Console.WriteLine("Only 5 letters allowed, you have 5 guesses and you can only input english letters, uppercase or lowercase doesn't matter");
            while (guess_amount <= 4)
            {
                
                Console.WriteLine("Enter Guess: ");


                string? Guess = Console.ReadLine()?.ToLower();


                Check(Rszavak, Guess);
                Console.WriteLine("\n");
                guess_amount++;

               

                if (Rszavak == Guess)
                {
                    Console.WriteLine($"Sikerült. {guess_amount} próbálkozás alatt ");
                    break;
                }
                else if (guess_amount <= 5)
                {
                    Console.WriteLine($"Nem sikerült. van még {5-guess_amount} lehetőséged");
                }
                else
                {
                    Console.WriteLine($"Nem sikerült. kifogytál a lehetőségekből");
                    break ;
                }
            }

        }
    }
}