// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Enter first numbers: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second numbers: ");
int second = int.Parse(Console.ReadLine());

if(first % second == 0)
{
    Console.WriteLine("Its matches");
}
else
{
    Console.WriteLine("The remainder is: " + first % second);
}
