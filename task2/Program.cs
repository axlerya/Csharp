Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThree = Convert.ToInt32(Console.ReadLine());



if (numberOne == numberTwo & numberTwo == numberThree & numberOne == numberThree)
{
    Console.WriteLine("Числа равны");
}

else if (numberOne > numberTwo & numberOne > numberThree)
{
    Console.WriteLine($"max = {numberOne} - первое число");
}

else if (numberTwo > numberOne & numberTwo > numberThree)
{
    Console.WriteLine($"max = {numberTwo} - второе число");
}

else if (numberThree > numberOne & numberThree > numberTwo)
{
    Console.WriteLine($"max = {numberThree} - третье число");
}


