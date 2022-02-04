/*
//  Author: Jonathan Scholl
//  Date: 2/4/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/

//Main method
//Variables
int matrixSize = CustomMatrixSize();

//Create new matrices based on size input
int[,] matrixOne = CreateNewMatrix(matrixSize);
int[,] matrixTwo = CreateNewMatrix(matrixSize);

//Add two matrices
int[,] addMatrix = SubtractMatrix(matrixOne, matrixTwo, matrixSize);

//Print output
Console.WriteLine(Environment.NewLine + "First matrix:");
PrintMatrix(matrixOne);
Console.WriteLine(Environment.NewLine + "Second matrix:");
PrintMatrix(matrixTwo);
Console.WriteLine(Environment.NewLine + "Added matrix:");
PrintMatrix(addMatrix);
//End Main Method

//Custom classes
//Start CustomMatrixSize
static int CustomMatrixSize()
{
    int matrixSize = 0;
    //Allows size to be 1-5
    while (matrixSize <= 0 || matrixSize > 5)
    {
        //Prompt user to input size and store
        Console.Write("Input the size of the square matrix(less than 5): ");
        matrixSize = Convert.ToInt32(Console.ReadLine());

        //Let's user know they entered wrong number
        if (matrixSize <= 0 || matrixSize > 5) Console.WriteLine("Invalid size.");
    }
    return matrixSize;
}//end CustomMatrixSize

//Create new matrix
static int[,] CreateNewMatrix(int size)
{
    int[,] matrix = new int[size, size];

    //loop for input of elements inside new matrixOne
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //prompt user to input element
            Console.Write("Input element: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matrix;
}

//class to create addition matrix
static int[,] SubtractMatrix(int[,] one, int[,] two, int size)
{
    int[,] outputMatrix = new int[size, size];

    for (int i = 0; i < outputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < outputMatrix.GetLength(1); j++)
        {
            outputMatrix[i, j] = one[i, j] - two[i, j];
        }
    }
    return outputMatrix;
}

//Print matrix in square
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
