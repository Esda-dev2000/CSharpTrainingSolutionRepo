// Welcome message
Console.WriteLine("WELCOME");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calcultor options/Menu - give the user the option to choose the operator e.g +, -
Console.WriteLine("Please select an operator option");
Console.WriteLine("1. Addtion");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Mulitiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulus");

//collect the users input into a variable
int calcOption = Convert.ToInt32(Console.ReadLine()); //global scope

//store the answer in a variable called answer
int answer = 0; //global scope

// Decide which operation is needed based on selected option
// if statement:
// if the user input is == to a calcOption then perfrom the operation e.g additon
if (calcOption == 1)
{
    answer = num1 + num2;
}
else if (calcOption == 2)
    answer = num1 - num2;

else if (calcOption == 3)       
    answer = num1 * num2;

else if (calcOption == 4)
    answer = num1 / num2;

else if (calcOption == 3)
    answer = num1 % num2;
else
{
    Console.WriteLine("Invaild choice");
}

// Print output
Console.WriteLine($"The output is {answer}");