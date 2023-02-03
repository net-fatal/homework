// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int num_a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num_b = int.Parse(Console.ReadLine()!);

if (num_a > num_b)
{
    Console.WriteLine($"Первое число {num_a} больше чем второе {num_b}");
}
 else
{
    Console.WriteLine($"Второе число {num_b} больше чем первое {num_b}");
}
