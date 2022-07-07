/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}


void CheckNumber(string num)
{
  if (num[0]==num[4] && num[1]==num[3])
  {
    Console.WriteLine($"Число: {num} - палиндром.");
  }
  else Console.WriteLine($"Число: {num} - не палиндром.");
}




int number = GetNumber();
string num = number.ToString();

if (num!.Length == 5)
{
  CheckNumber(num);
}
else 
Console.WriteLine($"Вы ввели не пятизначное число. Начните заново.");
