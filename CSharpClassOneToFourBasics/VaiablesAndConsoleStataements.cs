// Declare variables
string? firstName = string.Empty; // initializing an empty string // the ? is making the variable nullable
string lastName = string.Empty;
int age; // initializing to zero does this automatically
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool isWorking = true;

// prompt the user for input
Console.WriteLine("Please enter your first name");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

// converting from a string to an int
Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary");
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please enter your gender (M or F): ");
// converting data type to character
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());

// process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"First Name: {firstName} {lastName}");
Console.WriteLine($"What is your age: {age}");
Console.WriteLine($"What is your salary: {salary}");
Console.WriteLine($"What is your gender: {gender}");
Console.WriteLine($"Are you employed: {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
