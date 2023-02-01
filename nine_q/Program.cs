// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Enter numbers between 100 and 999: ");
int number = int.Parse(Console.ReadLine());

int firstDigit = number / 100;
int lastDigit = number % 10;
int newNumber = firstDigit * 10 + lastDigit;

Console.WriteLine("The new number is: " + newNumber);
