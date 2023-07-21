Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == numberTwo)
{
    Console.Write("Числа равны");
}
else if (numberOne > numberTwo)
{
    Console.Write("Первое число" + " " + numberOne + " " + "больше чем втрое" +  " " + numberTwo);
}
else 
{
    Console.Write("Втрое чило" + " " + numberTwo + " " + "больше чем первое" + " "+ numberOne);
}