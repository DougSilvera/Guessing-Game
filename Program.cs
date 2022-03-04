using System;

Console.WriteLine("Guess the secret number between 1 and 50!");
for (int i = 1; i < 5; i++)
{
    if (i == 4)
    {
        Console.Write($"you have {5 - i} guess remaining.");

    }
    else
    {
        Console.Write($"you have {5 - i} guesses remaining.");
    }
    GuessTheNumber();
}
int randomInt()
{
    Random r = new Random();
    int genRand = r.Next(1, 101);
    return genRand;
}

void GuessTheNumber()
{
    Console.Write(" What is your guess?: ");
    int SecretNumber = randomInt();
    // Console.WriteLine(SecretNumber);
    string input = Console.ReadLine();
    if (int.Parse(input) == SecretNumber)
    {
        Console.WriteLine("Success! You guessed the number");
        System.Environment.Exit(0);
    }
    else
    {
        Console.WriteLine($"Wrong again waterboy!");
    }

}
