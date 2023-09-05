﻿string[] array = new string[6] {"123", "кот", "hello", "world", "мяу","456"};
Console.WriteLine("Дан массив: 123, кот, hello, world, мяу,456");
string[] newArray = new string[array.Length];
void SecondArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
}   
void PrintArray(string[] array)
{
    Console.Write("Получен массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array, newArray);
PrintArray(newArray);