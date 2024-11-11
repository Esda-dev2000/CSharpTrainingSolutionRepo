// Ask the user to enter the number of apples
Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine()); // Read input and convert it to an integer

// Ask the user to enter the number of oranges
Console.WriteLine("Enter number of oranges: ");
int numberofOranges = Convert.ToInt32(Console.ReadLine()); // Read input and convert it to an integer

// If Statements ( ==, <, >, >=, <=, != )
// Compare the number of apples and oranges
if (numberOfApples > numberofOranges) // Check if apples are more than oranges
{
    Console.WriteLine("You have more apples"); // Print message if condition is true
}
else if (numberOfApples < numberofOranges) // Check if apples are less than oranges
{
    Console.WriteLine("You have more oranges"); // Print message if condition is true
}
else if (numberOfApples == numberofOranges) // Check if apples and oranges are equal
{
    Console.WriteLine("You have the same number of apples and oranges"); // Print message if condition is true
}

// Ask the user to enter their final grade
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine()); // Read input and convert it to an integer

// Switch Statements
// Determine the result based on the entered grade
switch (grade)
{
    case int n when n >= 0 && n <= 59: // If grade is between 0 and 59
        Console.WriteLine("You Failed"); // Print "Failed" for this range
        break; // Exit this case

    case int n when n >= 60 && n <= 100: // If grade is between 60 and 100
        Console.WriteLine("You Passed"); // Print "Passed" for this range
        break; // Exit this case

    case 101: // If grade is exactly 101
        Console.WriteLine("Single Case Example"); // Print specific message
        break; // Exit this case

    default: // If grade does not match any of the above cases
        Console.WriteLine("Invalid Grade"); // Print "Invalid Grade"
        break; // Exit this case
}

// Ternary Operator - used to assign a value 
// Check if there are more apples or more oranges and store the result in the variable "message"
var message = numberOfApples > numberofOranges ? "You have more Apples" : "You have more Oranges";
// Print the message
Console.WriteLine(message);
