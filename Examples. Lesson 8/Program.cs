// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] matrix = new int[5, 5];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// RepleceRowArray(matrix);
// PrintArray(matrix);


// void RepleceRowArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(1) - 1, j];
//         array[array.GetLength(1) - 1, j] = temp;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void FillArray(int[,] array)
// {
//     Random generator = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = generator.Next(1, 10);
//         }
//     }
// }



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// using System;
// using System.Globalization;

// Console.Write("Введите число строк: ");
// int row = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число столбцов: ");
// int coloumn = int.Parse(Console.ReadLine()!);
// double[,] doubleArray = CreateDoubleArray(row, coloumn);
// FillDoubleArray(doubleArray);
// PrintArray(doubleArray);
// Console.WriteLine();
// //ChangeRows(doubleArray);
// //PrintArray(doubleArray);
// Console.WriteLine();
// double[,] newArray = ChangeRowsAndColumns(doubleArray);
// PrintArray(newArray);


// double[,] CreateDoubleArray(int row, int coloumn)
// {
//     double[,] array = new double[row, coloumn];
//     return array;
// }

// void FillDoubleArray(double[,] collection)
// {
//     Random doubleRandomGenerator = new Random();
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             collection[i, j] = Math.Round(doubleRandomGenerator.Next(0, 10) + doubleRandomGenerator.NextDouble(), 2);
//         }
//     }
// }
// void PrintArray(double[,] arr)
// {
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
//         {
//             Console.Write($"| {arr[rows, coloumns]} |");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeRows(double[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         double m = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = m;
//     }
// }
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// double[,] ChangeRowsAndColumns(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             double m = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = m;
//         }
//     }
//     return array;
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Console.Clear();
// int[,] matrix = new int[4, 4];
// Random generator = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = generator.Next(100, 200);
//     }
// }

// PrintArray(matrix);
// Console.WriteLine();

// int[] rowArray = MatrixToRow(matrix);
// GetFrequense(rowArray);


// int[] MatrixToRow(int[,] matrix)
// {
//     int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[index] = matrix[i, j];
//             index++;
//         }
//     }
//     return result;
// }

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void GetFrequense(int[] sortedArray)
// {
//     SortArray(sortedArray);
//     Console.WriteLine(string.Join(" ", rowArray));
//     int currentElement = sortedArray[0];
//     int count = 1;
//     for (int i = 1; i < sortedArray.Length; i++)
//     {
//         if (sortedArray[i] != currentElement)
//         {
//             Console.WriteLine($"{currentElement} встречается {count}");
//             currentElement = sortedArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{currentElement} встречается {count}");
// }






