﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введите количество чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[N];

void InputNumbers(int N)
{
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(N);
Console.WriteLine($"Количество чисел больше 0 -> {Comparison(massiveNumbers)} ");