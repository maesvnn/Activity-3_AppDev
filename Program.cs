using System;

Console.WriteLine("===== YOLO REGISTRATION SYSTEM =====");

Console.Write("Enter Full Name: ");
string fullName = Console.ReadLine();

Console.Write("Enter Age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.Write("Enter Username: ");
    string username = Console.ReadLine();

    Console.Write("Enter Password: ");
    string password = Console.ReadLine();

    Console.WriteLine("\n===== WELCOME =====");
    Console.WriteLine("Name: " + fullName);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Username: " + username);
    Console.WriteLine("Registered Successfully!");
    Console.WriteLine("Welcome to YOLO Registration System!");
}
else
{
    Console.WriteLine("\nRegistration Failed!");
    Console.WriteLine("Oh no! You must be 18 years old and above to register.");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();