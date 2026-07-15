using System;

Console.WriteLine("================================");
Console.WriteLine("   GitHub Actions Demo Project");
Console.WriteLine("================================");

Console.WriteLine($"Current Time : {DateTime.Now}");
Console.WriteLine($"Machine Name : {Environment.MachineName}");
Console.WriteLine($".NET Version : {Environment.Version}");

Console.WriteLine();

int a = 25;
int b = 15;

Console.WriteLine($"Addition       : {a + b}");
Console.WriteLine($"Subtraction    : {a - b}");
Console.WriteLine($"Multiplication : {a * b}");
Console.WriteLine($"Division       : {a / b}");

Console.WriteLine();
Console.WriteLine("Build Successful!");
