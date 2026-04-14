// Create a named tuple with X and Y coordinates
var pt = (X: 1, Y: 2);

// Calculate slope from origin to the point
var slope = (double)pt.Y / pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}");

// Modify the X coordinate of the tuple
pt.X = pt.X + 3;
Console.WriteLine($"The point is now at {pt}");

// Create a new tuple with modified Y value using with expression
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}");

// Assign tuple to another tuple with compatible structure
var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

// Getting user input for first and last name to create tuple with automated workflow
Console.WriteLine("Enter first customers name: ");
string FirstName = Console.ReadLine();
Console.WriteLine("Enter customers last name: ");
string LastName = Console.ReadLine();

// Create tuples with named fields for different data types
var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: FirstName, LastName: LastName);
var order = (Product: "guitar picks", style: "triangle", quantity: 50, UnitPrice: 0.10m);

// Build formatted strings using tuple fields
string automatedAction1 = $"Starting {namedData.Name}, temperature is: {namedData.Temp} and wind speed is {namedData.Wind + " meters"}";
string automatedAction2 = $"Customer: {person.FirstName}, {person.LastName}, has ordered {order.Product}, style: {order.style}, quantity: {order.quantity}, at unit price of {order.UnitPrice}";

Console.WriteLine($"\n{automatedAction1}");
Console.WriteLine($"\n{automatedAction2}");

// Create a record instance with positional constructor
Point pt3 = new(1, 1);

// Create new record with modified field using with expression
var pt4 = pt3 with { Y = 10 };
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of the line of {pt4} is {slopeResult}");
Console.WriteLine($"The two points are {pt3} and {pt4}");

// Define a record type for Point
public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}