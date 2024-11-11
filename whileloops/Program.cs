// While loops - are a condition-controlled, pre-test loops
using System.Diagnostics.Metrics;

Console.WriteLine("While loop");
int counter = 0;
while(counter < 10)
{
    Console.WriteLine($"Hellow World! - {counter}");
    counter += 2;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.
int sum = 0;
Console.WriteLine("Please numbers to be summed up. (-1 to stop or exit)");
while(sum != 1)
{
    sum += 2;
}


Console.WriteLine("While Loop Completed");

Console.WriteLine("Do While Loop");
sum = 0;
