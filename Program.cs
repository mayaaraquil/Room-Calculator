Console.WriteLine("Hello! Welcome to Maya's room calculator");

Console.WriteLine("Enter the length: ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the width: ");
double width = double.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine("Area:" + area);

double perimeter = 2 * (length + width);
Console.WriteLine("Perimeter: " + perimeter);



Console.WriteLine("Please enter your area: ");
double input = double.Parse(Console.ReadLine());
double oddCheck = input % 2;
if (oddCheck == 250)
{
    Console.WriteLine("small");
}
if(oddCheck == 250-650)
{
    Console.WriteLine("medium");
}
else if(oddCheck == 650)
{
    Console.WriteLine("Larges");
}
