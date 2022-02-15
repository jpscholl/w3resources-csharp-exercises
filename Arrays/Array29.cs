/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 29
*/

//variables
int matrixRows, matrixColumns = 0;
int zeroCount = 0, nonZeroCount = 0;

//ask user for rows and columns
Console.Write("Input the number of rows: ");
matrixRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the number of columns: ");
matrixColumns = Convert.ToInt32(Console.ReadLine());

//create new matrix based on input
int[,] userMatrix = new int[matrixRows, matrixColumns];

//input elements inside matrix
for (int i = 0; i < userMatrix.GetLength(0); i++)
{
    for (int j = 0; j < userMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        userMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//output original matrix and count number of zeros and non zeros
Console.WriteLine("\n" +
    "" +
    "Original Matrix");
for (int i = 0; i < userMatrix.GetLength(0); i++)
{
    for (int j = 0; j < userMatrix.GetLength(1); j++)
    {
        Console.Write($"{userMatrix[i, j]} ");

        if (userMatrix[i, j] == 0)zeroCount++;
            else nonZeroCount++;
    }
    Console.WriteLine();
}

//output results to user
bool isSparse = zeroCount > nonZeroCount ? true : false;

Console.WriteLine($"\nThe matrix sparse: {isSparse}");
Console.WriteLine($"There are {zeroCount} number of zeros in the matrix");
