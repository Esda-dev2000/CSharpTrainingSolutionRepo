// A simple Loop - does not take users input

// for the variable i = 0 (lowerbound = zero
// lowerbound < upperbound; lowerbound++
// lowerbound++ increases a value each time the code block in the loop has been executed
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello hello world -{i}");
}
// the output = 10 lines of hello world ( zero to 9 - as the index starts at zero)


//***********************************************************************************************************
// A simple loop - The loops takes the user input for how many times they want to print hello world
Console.WriteLine("How many times do you want to print Hello World?");
//collect the users input and store in a variable
int userInput = Convert.ToInt32(Console.ReadLine());

for (int userIput = 0; userIput < userInput; userIput++)
{
    Console.WriteLine($"Hello world -{userIput}");
}
// the output = 10 lines of hello world ( zero to 9 - as the index starts at zero)

