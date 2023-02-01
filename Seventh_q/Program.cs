// Показать вторую цифру трёхзначного числа
Console.WriteLine("Enter numbers between 100 and 999: ");
int number = int.Parse(Console.ReadLine());
number = number % 100 /10;

Console.WriteLine("Last digit is: " + number);
