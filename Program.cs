// Задача 54:
//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             { 5, 2, 8 },
//             { 4, 9, 1 },
//             { 7, 3, 6 }
//         };

//         OrderRowsDescending(array);

//         Console.WriteLine("Упорядоченный массив по убыванию в каждой строке:");
//         PrintArray(array);
//     }

//     static void OrderRowsDescending(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             int[] tempRow = new int[columns];
//             for (int j = 0; j < columns; j++)
//             {
//                 tempRow[j] = array[i, j];
//             }

//             Array.Sort(tempRow, (x, y) => y.CompareTo(x));

//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = tempRow[j];
//             }
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 },
//             { 10, 11, 12 }
//         };

//         int minSumRowIndex = FindRowWithMinSum(array);

//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");
//     }

//     static int FindRowWithMinSum(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRowIndex = -1;

//         for (int i = 0; i < rows; i++)
//         {
//             int rowSum = 0;
//             for (int j = 0; j < columns; j++)
//             {
//                 rowSum += array[i, j];
//             }

//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minSumRowIndex = i;
//             }
//         }

//         return minSumRowIndex;
//     }
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix1 = {
//             { 1, 2 },
//             { 3, 4 }
//         };

//         int[,] matrix2 = {
//             { 5, 6 },
//             { 7, 8 }
//         };

//         int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

//         Console.WriteLine("Результат умножения матриц:");
//         PrintMatrix(resultMatrix);
//     }

//     static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
//     {
//         int rows1 = matrix1.GetLength(0);
//         int columns1 = matrix1.GetLength(1);
//         int rows2 = matrix2.GetLength(0);
//         int columns2 = matrix2.GetLength(1);

//         if (columns1 != rows2)
//         {
//             throw new ArgumentException("Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
//         }

//         int[,] resultMatrix = new int[rows1, columns2];

//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < columns2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < columns1; k++)
//                 {
//                     sum += matrix1[i, k] * matrix2[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }

//         return resultMatrix;
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int columns = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,,] threeDimArray = Generate3DArray();

//         Print3DArrayWithIndexes(threeDimArray);
//     }

//     static int[,,] Generate3DArray()
//     {
//         int[,,] threeDimArray = new int[3, 3, 3];
//         Random random = new Random();

//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 for (int k = 0; k < 3; k++)
//                 {
//                     int num;
//                     do
//                     {
//                         num = random.Next(10, 100);
//                     } while (ArrayContainsValue(threeDimArray, num));

//                     threeDimArray[i, j, k] = num;
//                 }
//             }
//         }

//         return threeDimArray;
//     }

//     static bool ArrayContainsValue(int[,,] array, int value)
//     {
//         foreach (int num in array)
//         {
//             if (num == value)
//             {
//                 return true;
//             }
//         }
//         return false;
//     }

//     static void Print3DArrayWithIndexes(int[,,] array)
//     {
//         for (int i = 0; i < 3; i++)
//         {
//             Console.WriteLine($"Слой {i + 1}:");
//             for (int j = 0; j < 3; j++)
//             {
//                 for (int k = 0; k < 3; k++)
//                 {
//                     Console.Write($"[{i},{j},{k}]: {array[i, j, k]}  ");
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
//         }
//     }
// }
