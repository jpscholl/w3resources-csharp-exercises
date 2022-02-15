/*
//  Author: Jonathan Scholl
//  Date: 2/14/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array26
*/

//input size of matrix
Console.Write("Input size of square matrix: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());

//create square matrix and input elements
int[,] squareMatrix = new int[sizeMatrix, sizeMatrix];
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i, j] = Convert.ToInt32(Console.ReadLine()); 
    }
}

//output original
Console.WriteLine("\nOriginal Matrix");
 for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} ");
    }
    Console.WriteLine();
}


//setting zeros in lower triangular matrix
for (int i = 0; i < sizeMatrix; i++)
{
    for (int j = 0; j < sizeMatrix; j++)
    {
        if (i > j)
        {
            squareMatrix[i, j] = 0;
        }
    }
}

//print new matrix
Console.WriteLine();
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} ");
    }
    Console.WriteLine();
}
