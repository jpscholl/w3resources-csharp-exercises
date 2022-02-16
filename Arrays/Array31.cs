/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 31
*/


Console.Write("Input size of square matrix: ");
int matrixSize = Convert.ToInt32(Console.ReadLine());
int[,] squareMatrix = new int[matrixSize,matrixSize];
for (int i = 0; i < squareMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nInput matrix");
for (int i = 0;i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        if ((i == j && squareMatrix[i, j] != 1) || (i != j && squareMatrix[i, j] != 0))
        {
            goto label;
        }
    }
}
Console.WriteLine("\nThe matrix is an Identity Matrix.\n\n");
return;
label:
Console.WriteLine("\nThe matrix is not an Identity Matrix\n\n");
