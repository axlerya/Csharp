Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numbersEven = "";
int count =  number / 2; 
int i = 0;
int numberAdd = 0;

while (i<count)
{
    i++;
    numberAdd += 2;
    numbersEven = numbersEven.Insert(numbersEven.Length, $" {numberAdd}");
}
Console.WriteLine($"Все четные числа до числа {number} - {numbersEven}");
