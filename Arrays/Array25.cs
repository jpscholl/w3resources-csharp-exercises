/*
//  Author: Jonathan Scholl
//  Date: 2/14/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array25
*/

//input size of square matrix
Console.Write("Input size of square matrix: ");
int matrixSize = Convert.ToInt32(Console.ReadLine());

//create square matrix
int [,] squareMatrix = new int[matrixSize, matrixSize];

//input elements of matrix
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//output original matrix
Console.WriteLine("\nOriginal Matrix");
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} ");
    }
    Console.WriteLine();
}

//calculate and output sum of individual rows
Console.WriteLine("\nSum of Rows");
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        rowSum += squareMatrix[i, j];
    }
    Console.WriteLine($"Row {i + 1} sum: {rowSum}");
}

//calculate and output sum of individual columsn
Console.WriteLine("\nSum of Columns");
for (int j = 0; j < squareMatrix.GetLength(0); ++j)
{   
    int colSum = 0;
    for (int i = 0; i < squareMatrix.GetLength(1); ++i)
    {
        colSum += squareMatrix[i , j];
    }
    Console.WriteLine($"Column {j + 1} sum: {colSum}");
}
