/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 30
*/

//method to compare matrices
static bool isEqual(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne == null || matrixTwo == null) return false;
    if (matrixOne.Length != matrixTwo.Length) return false;

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (matrixOne[i, j] != matrixTwo[i, j]) return false;
        }
    }
    return true;
}

//create first matrix
Console.Write("Input rows of first matrix: ");
int matrixRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rows of first matrix: ");
int matrixColumn = Convert.ToInt32(Console.ReadLine());
var firstMatrix = new int[matrixRow, matrixColumn];

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        Console.Write("Input Element: ");
        firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//create second matrix
Console.Write("Input rows of second matrix: ");
matrixRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rows of second matrix: ");
matrixColumn = Convert.ToInt32(Console.ReadLine());
var secondMatrix = new int[matrixRow, matrixColumn];

for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        Console.Write("Input Element: ");
        secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


//output matrices
Console.WriteLine("\nFirst matrix");
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        Console.Write($"{firstMatrix[i, j]} ");
    }
    Console.WriteLine();
}

//output matrices
Console.WriteLine("\nSecond matrix");
for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        Console.Write($"{secondMatrix[i, j]} ");
    }
    Console.WriteLine();
}

//test to see if they're equal
Console.WriteLine();
Console.WriteLine($"Are matrices equal: {isEqual(firstMatrix, secondMatrix)}")
