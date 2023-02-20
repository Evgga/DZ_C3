// Задача 19. Напишите программу, ктр принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();


void PrintPalindromNumber(string  number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write(number + " -> да, число палиндром");
    }
    else
    {
        Console.Write(number + " -> нет, число не палиндром");
    }
}
if (number!.Length == 5)
{
  PrintPalindromNumber(number);
}
else 
{
    Console.WriteLine("Введите положительное целое пятизначное число");
}

