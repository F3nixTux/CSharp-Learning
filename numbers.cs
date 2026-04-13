void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // Substraction
    c = a - b;
    Console.WriteLine(c);

    // Multiplication
    c = a * b;
    Console.WriteLine(c);

    // Division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    // Order of operations
    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void IntegerPresicionsAndLimits()
{
    // Integer quotient and remainder
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b ) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    // Integer limits
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    // Great example of overflow
    int what = max + 3;
    Console.WriteLine($"An example of overflow {what}");
}

void IntegersOtherStuff()
{
    int a = 18;
    int b = 6;

    // Mixing variables and numbers
    int c = a + b - 12 * 17;
    Console.WriteLine(c);

    // Behaviour for division of integers
    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void WorkWithDoubles()
{
    // Doubles are floating-point numbers, which means they can represent fractional values.
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    // More compicated expression
    a = 19;
    b = 23;
    c = 8;
    d = (a + b) / c;
    Console.WriteLine(d);

    // Double limits
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of doubles is {min} to {max}");

    // Rounding errors with doubles
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

void WorkWithDecimals()
{
    // Decimals are a special type of floating-point number that has more precision that doubles
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of decimals is {min} to {max}");

    // Greater precison with decimals
    decimal a = 1.0M;
    decimal b = 3.0M;
    Console.WriteLine(a / b);
}

void Challenge()
{
    // The challenge is to use numeric types to find the area of circle whose radius is 2.50 centimeters
    Console.WriteLine("\nThe challenge is to use numeric types to find the area of circle whose radius is 2.50 centimeters");

    double radius = 2.50;
    double area = Math.Pow(radius, 2) * Math.PI;
    // Math.Pow is a great method to give any value or number any power, returns double
    
    Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
}

Console.WriteLine("=== Working with Integers ===");
WorkWithIntegers();

Console.WriteLine("\n=== Order of Precedence ===");
OrderPrecedence();

Console.WriteLine("\n=== Integer Precision and Limits ===");
IntegerPresicionsAndLimits();

Console.WriteLine("\n=== Other Integer Operations ===");
IntegersOtherStuff();

Console.WriteLine("\n=== Working with Doubles ===");
WorkWithDoubles();

Console.WriteLine("\n=== Working with Decimals ===");
WorkWithDecimals();

Console.WriteLine("\n=== Challange ===");
Challenge();