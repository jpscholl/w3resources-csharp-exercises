/*
//  Author: Jonathan Scholl
//  Date: 10/20/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String13.cs
*/

//global variable
char[] charHolder;
int stringLength;
int loopStart = 0;  //not sure what to call this?

//tell user what program does
Console.WriteLine("Extract substring from given string.");

//prompt user for input and store
Console.WriteLine("Please input a string: ");
string userInputString = Console.ReadLine();

//hold length of string and transfer string to char array
stringLength = userInputString.Length;
charHolder = userInputString.ToCharArray(0, stringLength);

//ask user for starting point
Console.WriteLine("Starting point for extraction: ");
int startingPosition = Int32.Parse(Console.ReadLine());

//ask user for length of substring
Console.WriteLine("Length of substring: ");
int substringLength = Int32.Parse(Console.ReadLine());

//retrieve based on start and end position
Console.Write("The substring retrieve from the string is : ");
while(loopStart < substringLength)
{
    Console.Write(charHolder[startingPosition + loopStart - 1]);
    loopStart++;
}
Console.Write("\n\n");
