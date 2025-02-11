// Alessandro Cardenas-Engle
// Module 5 Challenge
// 2/10/25

using System;

namespace Module5Challenge 
{
    class Program
    {
        static void Main(string[] args )
        {
            // string array that has a dozen dad jokes!
            string[] dadJokes = new string[]
            {
                "I got fired from the bank today. A woman asked me to check her balance, so I pushed her.",
                "My dog accidentally ate a whole bag of scrabble tiles so I took him to the vet. No word yet.",
                "To the guy who invented zero, thanks for nothing.",
                "A polar bear walks into a bar and says to the bartender: 'I'll take a rum........ and coke.' The bartender says: 'What's with the pause?' Polar bear says: 'I was born with them.'",
                "My wife complains I dont buy her flowers, but to be honest, I didn't know she sold flowers.",
                "I went to the book store the other day and saw a book that said 'How to solve 50% of your problems.' So I bought two.",
                "I no longer see my wife and kids and it's all because of gambling... I won the lottery and moved to Hawaii!!!",
                "My therapist said I have a phobia of getting married. He asked: 'Do you know what your symptoms are?' I said: 'I can't say I do.'",
                "Whoever stole the copy of my Microsoft office, I will find you. You have my Word.",
                "Two weeks ago I sent my hearing aid in for repair... I've heard nothing since.",
                "A colorblind friend of mine insists that apples are yellow, I said: 'that's bananas.'",
                "I don't always tell dad jokes, but when I do, he laughs."
            
    
            };

            // Created a random object to genrate random numbers
            Random rnd = new Random();
            bool showMoreJokes = true;

            // while-loop to display dad jokes and asks the user if they want to see more jokes
            while(showMoreJokes)
            {
                Console.Clear();
                Console.WriteLine("Here are some Dad Jokes for you: \n");

                // Displays two random jokes at a time
                for (int j = 0; j < 2; j++)
                {

                    int jokeIndex = rnd.Next(dadJokes.Length);

                    Console.WriteLine(dadJokes[jokeIndex]);

                }

                // Prompts the user if they want to read more Dad jokes
                Console.Write("\nWould you like to hear more Dad jokes? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                // this checks the users response if it wasn't a yes
                // if it wasn't(no) then the loop ends, otherwise, it continues
                if (response != "yes")
                {

                    // when the user inputs no it ends the loop and displays this message
                    showMoreJokes = false;
                    Console.WriteLine("\nThanks you for reading and hopefully laughing at the Dad jokes!");
                }
            
            } // end of while loop
        } // end main
    } // end program
} // end namespace
