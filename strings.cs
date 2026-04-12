using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maria";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

// String interpolation allows you to embed expressions inside string literals, using curly braces {}.
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "   Hello World!   ";
Console.WriteLine($"[{greeting}]");

// TrimStart() removes whitespace from the beginning of the string
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// TrimEnd() removes whitespace from the end of the string
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// Trim() removes whitespace from both the beginning and end of the string
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Replace() substitutes one substring with another
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// ToUpper() converts all characters to uppercase
Console.WriteLine(sayHello.ToUpper());

// ToLower() converts all characters to lowercase
Console.WriteLine(sayHello.ToLower());

// Contains() checks if a string contains a specific substring (returns true or false)
string songLyrics = "You say goodbye, and I say Hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// StartsWith() checks if a string starts with a specific substring (returns true or false)
Console.WriteLine(songLyrics.StartsWith("You"));

// EndsWith() checks if a string ends with a specific substring (returns true or false)
Console.WriteLine(songLyrics.EndsWith("Hello"));
