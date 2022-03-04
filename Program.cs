using System;

Console.WriteLine("Guess the secret number between 1 and 50!");
Console.Write("Choose Your difficulty level (easy, medium or hard)");
string difficultyInput = Console.ReadLine().ToLower();
int convertToTries()
{
    if (difficultyInput == "easy")
    {
        return 8;
    } else if (difficultyInput == "medium")
    {
        return 6;
    } else 
    {
        return 4;
    }
}
int checkingGuesses = convertToTries() + 1;
 bool run = true;
while (run)
{
if (difficultyInput == "cheater")
{
    GuessTheNumber();
} else 
{

for (int i = 1; i < convertToTries()+1; i++)
{
    if (i == convertToTries())
    {
        Console.Write($"you have {checkingGuesses - i} guess remaining.");

    }
    else
    {
        Console.Write($"you have {checkingGuesses - i} guesses remaining.");
    }
    GuessTheNumber();
    if (i == convertToTries())
    {
        run = false;
    }
}

}


}
int randomInt()
{
    Random r = new Random();
    int genRand = r.Next(1, 51);
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
        run = false;
    }
    else
    {
        Console.WriteLine($"Wrong again waterboy!");
        if (int.Parse(input) > SecretNumber)
        {
            Console.WriteLine("Guess is too high!");
        } else 
        {
           Console.WriteLine("Guess is too low!"); 
        }
    }

}
