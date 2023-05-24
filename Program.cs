using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Password");
        Console.WriteLine("Please enter the password:");

        string correctPassword = "password123";
        int maxAttempts = 5;
        int attemptCount = 0;

        while (attemptCount < maxAttempts)
        {
            string password = Console.ReadLine();

            if (password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                // Proceed with the game logic or display additional content
                break;
            }
            else
            {
                attemptCount++;
                Console.WriteLine($"Incorrect password! Attempt {attemptCount} of {maxAttempts}");

                if (attemptCount == maxAttempts)
                {
                    Console.WriteLine("Game Over. You have exceeded the maximum number of attempts.");
                    break;
                }
                else
                {
                    string joke = GetRandomJoke();
                    Console.WriteLine("Here's a joke for you:");
                    Console.WriteLine(joke);
                    Console.WriteLine("Please try again:");
                }
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string GetRandomJoke()
    {
        // An array of jokes that will be randomly selected
        string[] jokes = {
            "Why don't scientists trust atoms? Because they make up everything!",
            "Did you hear about the mathematician who's afraid of negative numbers? He'll stop at nothing to avoid them!",
            "Why don't skeletons fight each other? They don't have the guts!",
            "What's the best thing about Switzerland? I don't know, but their flag is a big plus!",
            "I used to be a baker, but I couldn't make enough dough!",
        };

        Random random = new Random();
        int index = random.Next(jokes.Length);
        return jokes[index];
    }
}
