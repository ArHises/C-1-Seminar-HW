// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Enter numbers between 10 and 99: ");
int number = int.Parse(Console.ReadLine());

int first = number % 10;
int second = number / 10;

if(first > second)
{
    Console.WriteLine("bigger digit is: " + first);
}
else
{
    Console.WriteLine("bigger digit is: " + second);
}