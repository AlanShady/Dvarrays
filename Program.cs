// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = 
// {
//     {1, 2, 3},
//     {4, 5, 6},
//     {7, 8, 9}
// };

// Console.WriteLine("Введите номер строки и столбца элемента, значение которого вы хотите получить:");
// Console.Write("Строка: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Столбец: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if (row >= 1 && row <= 3 && column >= 1 && column <= 3)
// {
//     int value = array[row - 1, column - 1];
//     Console.WriteLine($"Значение элемента на позиции ({row}, {column}) равно {value}");
// }
// else
// { 
//     Console.WriteLine("Введенная позиция элемента не существует в массиве.");
// }

// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] array = new int[4, 4]
{ 
    { 1, 2, 3, 4 },
    { 0, 0, 0, 0 },
    { 0, 0, 0, 0 },
    { 5, 6, 7, 8 }
};
for(int i = 0; i < array.GetLength(1); i++)
{
    var tmp = array[3, i];
    array[3, i] = array[0, i];
    array[0, i] = tmp;
}
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

// int[,] array = new int[4,2];

// int sumInMin=0;
// int indexMin=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum=0;

//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i,j] = new Random().Next(0,10);
//      System.Console.Write(array[i,j]+ " ");

//      sum += array[i,j];
//    }
//     System.Console.WriteLine("сумма "+sum);

//    if(sum>sumInMin)
//    {
//      sumInMin= sum;
//      indexMin= i;
//    }

//    System.Console.WriteLine();
// }

// System.Console.WriteLine("\nСтрока с наименьшей суммой элементов = "+indexMin);