using Operators_Exercises;


//int x = 10;
//int y = 11;

//x += y; // output 21
//x -= y; // 10
//x *= y; // 110
//x %= y; // 0

// Exercise 1

//int a = 17;
//int b = 4;

//int quotient = a / b;
//int remainder = a % b;


//Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


// Exercise 2
Console.WriteLine("Please enter the radius: ");

while (true)
{
    try
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Methods.AreaOfCircle(radius);
        Console.WriteLine(area);
        break;
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("We encountered an error but it didn't crash the program");
    }
}


