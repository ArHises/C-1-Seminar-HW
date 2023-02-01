// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if(number / 100 != 0)
{
    Console.WriteLine("third digit is: "+ number / 100 % 10);
}
else
{
    Console.WriteLine("Third digit does not exist!");
}
