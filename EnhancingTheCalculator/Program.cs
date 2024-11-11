Console.WriteLine("***************Welcome to the sample calculator!*****************");

//Show calculator options/ menu
Console.WriteLine("Please select an operator option");
Console.WriteLine("1. Addtion");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Mulitiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulus");
Console.WriteLine("6. Fibonacci Sequence");

//assign variables 
int choice =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int answer;

// Decide which operator is need based on selected option
// ** If Staements **

// switch statements 
switch (choice)
{
    case 1:
        answer = num1 + num2;
        break;
    case 2:
        break;
        answer = num2 - num1;
    case 3:
        break;
        answer = num2 * num1;
        break;
    case 4:
        answer = num2 / num1;
        break;
    case 5:
        break;
        answer = num2 % num1;
    case 6:
        break;
        for (int i = num1; i <= num2; i++)
        {
            answer += i;
        }
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

