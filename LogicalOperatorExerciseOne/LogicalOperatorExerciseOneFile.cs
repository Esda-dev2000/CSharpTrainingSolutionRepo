// assign a variable - to take user input
int inputNum;
int numberCheck = 10;
bool isGreaterOrNotAndEven;

// prompt user for input and convert int
Console.WriteLine("Please enter your number");
// Need to convert from string to int when using Console.Readline
inputNum = Convert.ToInt32(Console.ReadLine());

// process the data - checking if the input number is even and greater than 10
// To check if a number is even, we use: inputNum % 2 == 0
// Combine with the check for being greater than 10
isGreaterOrNotAndEven = (inputNum > numberCheck) && (inputNum % 2 == 0);

// output the results
Console.WriteLine($"The number is even and greater than 10: {isGreaterOrNotAndEven}");
