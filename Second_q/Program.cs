// По заданному номеру дня недели вывести его название
 Console.WriteLine("Enter number of the day of a week: ");
int day = int.Parse(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine("Sunday");
}
else if(day == 2)
{
    Console.WriteLine("Monday");
}
else if(day == 3)
{
    Console.WriteLine("Tuesday");
}
else if(day == 4)
{
    Console.WriteLine("Wednesday");
}
else if(day == 5)
{
    Console.WriteLine("Thursday");
}
else if(day == 6)
{
    Console.WriteLine("Friday");
}
else if(day == 7)
{
    Console.WriteLine("Saturday");
}
else{

    Console.WriteLine("Invalid number of a day");
}