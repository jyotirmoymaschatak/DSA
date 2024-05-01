// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int n = 5;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
        Console.Write(" ");

    for (int j = 0; j < (2 * i + 1); j++)
        Console.Write("*");

    for (int j = 0; j < n - i - 1; j++)
        Console.Write(" ");

    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = i; j > 0; j--)
        Console.Write(" ");

    for (int j = 2*(n-i) -1; j > 0; j--)
        Console.Write("*");

    for (int j = i; j > 0; j--)
        Console.Write(" ");

    Console.WriteLine();
}