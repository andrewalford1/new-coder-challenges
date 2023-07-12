// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your number:");

string userInput = Console.ReadLine();
int sequenceNumber = Int32.Parse(userInput);

int previousValue = 0;
int nextValue = 1;

for (int i = 1; i < sequenceNumber; i++)
{
    int sum = previousValue + nextValue;
    previousValue = nextValue;
    nextValue = sum;
    Console.WriteLine(nextValue);
}
