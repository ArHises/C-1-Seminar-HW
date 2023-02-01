// Найти максимальное из трех чисел
 Console.WriteLine("Enter first number: ");
int first = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter second number: ");
int second = int.Parse(Console.ReadLine());

 Console.WriteLine("Enter third number: ");
int third = int.Parse(Console.ReadLine());

if(first > second && first > third)
{
    Console.WriteLine("Higher number is : " + first);
}
else if(second > first && second > third)
{
    Console.WriteLine("Higher number is : " + second);
}
else
{
    Console.WriteLine("Higher number is : " + third);
}

