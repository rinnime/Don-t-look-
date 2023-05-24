using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Password");
        Console.WriteLine("Please enter the password:");

        string correctPassword = "hjklfdsag"; // Can make the password anything
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
                    string comment = GetRandomComment();
                    Console.WriteLine();
                    Console.WriteLine("Enter password:", comment);
                }
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string GetRandomComment()
    {
        // An array of comments that will be randomly selected
        string[] comments = {
            "Do you really know the password?",
            "That's not the password!",
            "Hahaha! Keep trying.",
            "Try again.",
            "You know you could just make a new password.",
            "I know you don't remember your password, so stop trying.",
            "How many times are you going to keep guessing?",
            "..."
        };

        Random random = new Random();
        int index = random.Next(comments.Length);
        return comments[index];
    }
}
