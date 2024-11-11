// Switch statement 
// Default is a catch all when no other case is true


Console.WriteLine("Please enter the day od the week");

int dayOfTheWeek =Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
       Console.WriteLine("Sunday");
        // more code
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("Hump day");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    default:
        Console.WriteLine("Invaild day number entered");
        break;
}
Console.WriteLine("");