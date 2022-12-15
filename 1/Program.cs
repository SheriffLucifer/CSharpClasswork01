Console.Write("Введите любое целое число 1: ");
string input1 = Console.ReadLine() ?? "";


Console.Write("Введите любое целое число 2: ");
string input2 = Console.ReadLine() ?? "";

int number1 = int.Parse(input1);
int number2 = int.Parse(input2);

if (number1 == Math.Pow(number2, 2))
{
    Console.WriteLine($"Yes {number2} -> {number1}");
}
else
{
    Console.WriteLine($"No {number2} -> {number1}");
}