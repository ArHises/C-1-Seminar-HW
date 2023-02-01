// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Enter first number to check: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number to check: ");
int second = int.Parse(Console.ReadLine());

if(first == second*second)
{
    Console.WriteLine("Match");
}
else
{
    Console.WriteLine("No match");
}


