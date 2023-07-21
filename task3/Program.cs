Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberRemains = number % 2;

if (numberRemains == 0)
{ 
    Console.WriteLine($"Число {number} - четное");
}
else
{ 
    Console.WriteLine($"Число {number} - нечетное");
}