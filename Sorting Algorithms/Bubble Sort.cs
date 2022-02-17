/*
//  Author: Jonathan Scholl
//  Date: 2/17/2022
//  Project: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/index.php Bubble Sort
*/

//Begin Main

//Opening statement
Console.WriteLine("Testing of Bubble Sort Algorithm");
Console.WriteLine("--------------------------------\n");

//test list that needs sorting
List<int> numArray = genList();

//test method with given list
BubbleSort(numArray);


//End Main

//Sort Method
static void BubbleSort(List<int> list)
{
    int attempts = 0;

    while (!isSorted(list))
    {
       for (int i = 0; i < list.Count - 1; i++)
       {
            if (list[i] > list[i + 1])
            {
                int temp = list[i];
                list[i] = list[i + 1];
                list[i + 1] = temp;
            }
       }
        Thread.Sleep(5);
        Console.Write($"Iteration #{attempts}: ");
        printList(list);
        attempts++;
    }
    Console.WriteLine($"\nSorted after {attempts} attempts.");
    printList(list);
}
//checks if list is sorted
static bool isSorted (List<int> list)
{
    for (int i = 0; i < list.Count - 1; i++)
    {
        if (list[i] > list[i + 1]) return false;
    }
    return true;
}
//prints contents of array/List
static void printList(List<int> list)
{
    foreach (int item in list)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
//generate random list of 10 integers
static List<int> genList()
{
    var rand = new Random();
    var newList = new List<int>();

    for (int i = 0; i < 10; i++)
    {
        newList.Add(rand.Next(10));
    }

    return newList;
}
