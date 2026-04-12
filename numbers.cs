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

WorkWithIntegers();
OrderPrecedence();
IntegersOtherStuff();