// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Enter numbers between 100 and 999: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Last digit is: " + number % 10);
