/*
//  Author: Jonathan Scholl
//  Date: 2/17/2022
//  Project: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/index.php BogoSort
*/


//main method

//create list of integers and begin sort method with parameters
List<int> list = new List<int>() { 2, 1, 3, 0, 4 };
Console.WriteLine("Sorting...");
BogoSort(list);


//bogosort method
static void BogoSort(List<int> list)
{
	int attempts = 0;

	while (!isSorted(list))
    {
		if (!isSorted(list))
        {
			printList(list, attempts);
        }
		Thread.Sleep(5);
		list = reGen(list);
		attempts++;
    }
	printList(list, attempts);
	Console.WriteLine();
	Console.WriteLine($"BogoSort completed after {attempts} attempts.");
}
//checks if list is sorted
static bool isSorted (List<int> list)
{
	for (int i = 0; i < list.Count - 1; i++)
	{
		if (list[i] > list[i + 1])
		{
			return false;
		}
	}
	return true;
}
//prints list after sorted
static void printList(List<int> list, int attempts)
{
	Console.Write($"BogoSort iteration {attempts}: ");
	for (int i = 0; i < list.Count; i++)
	{
		Console.Write(list[i]);
		if (i < list.Count)
		{
			Console.Write(" ");
		}
	}
	Console.WriteLine();
}
//generates new list after failed sort
static List<int> reGen(List<int> list)
{
	int temp;
	List<int> newList = new List<int>();
	Random rand = new Random();

	while (list.Count > 0)
	{
		temp = Convert.ToInt32(rand.Next(list.Count));
		newList.Add(list[temp]);
		list.RemoveAt(temp);
	}
	return newList;
}
