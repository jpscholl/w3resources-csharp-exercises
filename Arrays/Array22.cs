/*
//  Author: Jonathan Scholl
//  Date: 2/4/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array22
*/

//set matrix
int[,] squareMatrix =
{
    { 1, 2},
    { 4, 5}
};

//print original matrix
Console.WriteLine("Original:");
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for(int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i,j]} ");
    }
    Console.WriteLine();
}

//transpose matrix
int[,] transposeMatrix = new int[squareMatrix.GetLength(0),squareMatrix.GetLength(1)];

for (int i = 0; i < transposeMatrix.GetLength(0); i++)
{
    for (int j = 0; j < transposeMatrix.GetLength(0); j++)
    {
        transposeMatrix[i,j] = squareMatrix[j,i];
    }
}

Console.WriteLine("\nTransposed:");

//print transpose matrix
for (int i = 0; i < transposeMatrix.GetLength(0); i++)
{
    for (int j = 0; j < transposeMatrix.GetLength(1); j++)
    {
        Console.Write($"{transposeMatrix[i, j]} ");
    }
    Console.WriteLine();
}
