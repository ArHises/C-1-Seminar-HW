// Показать четные числа от 1 до N
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int a = 0;

while(a <= number)
{
    if (a % 2 == 0) 
    {
        Console.WriteLine(a);
    }
    a++;
}