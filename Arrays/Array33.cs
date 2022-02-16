/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 33
*/

//taking their example to simplify
object[] mixedArray = new object[8];
mixedArray[0] = 25;
mixedArray[1] = "Anna";
mixedArray[2] = false;
mixedArray[3] = 25;
mixedArray[4] = System.DateTime.Now;
mixedArray[5] = 112.22;
mixedArray[6] = "Anna";
mixedArray[7] = false;

Console.WriteLine("OG array:");
foreach (object obj in mixedArray)
{
    Console.WriteLine(obj);
}


Console.WriteLine("\nAfter removal:");
foreach (var item in mixedArray.Distinct())
{
    Console.WriteLine(item);
}
