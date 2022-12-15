Console.Write("Введите любое целое число от 1 до 7: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);
if (number == 1)
{
    Console.WriteLine($"{number} -> Monday");
}
else if (number == 2)
{
    Console.WriteLine($"{number} -> Tuesday");
}
else if (number == 3)
{
    Console.WriteLine($"{number} -> Wednesday");
}
else if (number == 4)
{
    Console.WriteLine($"{number} -> Thursday");
}
else if (number == 5)
{
    Console.WriteLine($"{number} -> Friday");
}
else if (number == 6)
{
    Console.WriteLine($"{number} -> Saturday");
}
else if (number == 7)
{
    Console.WriteLine($"{number} -> Sunday");
}
else
{
    Console.WriteLine("You are wrong!");
}