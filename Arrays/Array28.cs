/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 28
*/

//we already have size so create 3x3 matrix
int[,] squareMatrix = new int[3,3];
int determinant = 0;

//input elements into matrix
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//output matrix
Console.WriteLine();
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} ");
    }
    Console.WriteLine();
}

//calculate and output determinant
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    determinant += (squareMatrix[0, i] * (squareMatrix[1, (i + 1) % 3] * 
        squareMatrix[2, (i + 2) % 3] - squareMatrix[1, (i + 2) % 3] * squareMatrix[2, (i + 1) % 3]));
}

Console.WriteLine($"Determinant: {determinant}");
