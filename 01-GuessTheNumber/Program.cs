Console.WriteLine("Think of a number between 1 and 100");

var random = new Random();

bool isCorrectGuess = false;

int min = 1;
int max = 101;

while (isCorrectGuess == false)
{
    int guess = random.Next(min, max);

    Console.WriteLine($"Is your number {guess}? [Y/N]");

    string userInput = Console.ReadLine().ToUpper();

    if (userInput == "Y")
    {
        isCorrectGuess = true;
        continue;
    }

    Console.WriteLine($"Is your number greater than or less than {guess}? [G/L]");

    userInput = Console.ReadLine().ToUpper();

    if (userInput == "G")
    {
        min = guess + 1;
    }
    else if (userInput == "L")
    {
        max = guess;
    }
}