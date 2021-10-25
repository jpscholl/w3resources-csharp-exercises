/*
//  Author: Jonathan Scholl
//  Date: 10/25/2021
//  Project: https://www.w3resource.com/csharp-exercises/data-types/index.php 3
//  Description: Write a C# Sharp program that takes userid and password as input (type string). 
//  After 3 wrong attempts, user will be rejected.
*/
using System;

namespace DataTypes3
{
    class Program
    {       
        const string storedUsername = "username";
        const string storedPassword = "password";
        static void Main(string[] args)
        {
            string username;
            string password;

            int maxAttempts = 3;
            bool login = false ;

            Console.WriteLine($"You have {maxAttempts} attemps to enter correct username and password");

            do
            {
                Console.Write("Please enter username: ");
                username = Console.ReadLine();

                Console.Write("Please enter password: ");
                password = Console.ReadLine();

                if (storedUsername == username && storedPassword == password)
                {
                    login = true;
                }
                else
                {
                    Console.Write("Try again!\n");
                    login = false;
                    maxAttempts--;
                }
            } while ((storedUsername != username && storedPassword != password)
            && maxAttempts > 0);

            if (login == true)
            {   
                Console.Write("\nPassword entered successfully!\n\n");
            }
            else if (login == false)
            {
                Console.Write("\nLogin attempt more than three times. Try later!\n\n");
            }

        }
    }
}
