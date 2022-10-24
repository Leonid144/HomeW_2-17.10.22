// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int dec = number % 100;
    
    int result = dec / 10;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

    if (number < 100)
    {
        int result = -1; 
    Console.Write($"Третьей цифры нет {result}");
    }
    while (number>= 1000)
    {
        number = (number / 10);
    
    int result1 = number % 10;
    Console.Write($"Третья цифра {number} = {result1}");
    }
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool dw(int number)
{

    if (number == 6 || number == 7)
       return true;
    else
        return false;
}
Console.Write("введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(dw(number));
*/
