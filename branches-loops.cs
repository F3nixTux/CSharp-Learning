// Call the ExploreIf function to demonstrate if-else statements
ExploreIf();

// Define a function to explore conditional statements
void ExploreIf()
{
    int a = 5;
    int b = 3;
    
    // Check if the sum of a and b is greater than 10
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    Console.WriteLine();

    int c = 4;
    
    // Check if the sum of a, b, and c is greater than 10 AND a is greater than b
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    Console.WriteLine("");

    // Check if the sum of a, b, and c is greater than 10 OR a is greater than b
    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }

    Console.WriteLine("");

}

// Initialize a counter for the do-while loop
int counter = 0;

// Do-while loop: execute the block at least once, then check the condition
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
while (counter < 10);

Console.WriteLine("");

// For loop: iterate from 0 to 9, printing the counter each time
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World! The counter is {i}");
}

Console.WriteLine("");

// Nested for loops: iterate over rows (1 to 10) and columns (a to j)
for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The column is {column}");
    }
}

Console.WriteLine("");

// Challenge 
// Find if sum of integers from 1 to 20 is divisible by 3

for (int i = 0; i < 1; i++)
{
    int sum = 0;
    for (int j = 1; j <= 20; j++)
    {
        sum += j;
    }
    // The % operator gives remainder of division
    if (sum % 3 == 0)
    {
        Console.WriteLine($"The sum of integers from 1 to 20 is {sum} and it is divisible by 3");
    }
    else
    {
        Console.WriteLine($"The sum of integers from 1 to 20 is {sum} and it is not divisible by 3");
    }
}