using System;
using System.Collections.Generic;

List<string> names = new List<string> {"<name>", "Ana", "Felipe"};
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();

names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();

Console.WriteLine($"My name is {names[0]}");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

Console.WriteLine($"The list contains {names.Count} names");

Console.WriteLine();

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index of {index}");
}

Console.WriteLine();

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();

List<int> fibonacciNumbers = [1, 1];

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// Challenge: Create a list of the first 20 Fibonacci numbers
fibonacciNumbers = [1, 1];

while (fibonacciNumbers.Count < 20)
{
    var p1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var p2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(p1 + p2);
}

foreach (var num in fibonacciNumbers)
{
    Console.WriteLine(num);
}
