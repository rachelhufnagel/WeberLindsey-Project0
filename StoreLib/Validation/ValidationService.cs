using System;

namespace StoreLib.Validation
{
    public class ValidationService
    {
        public void InvalidInputMessage()
        {
            Console.WriteLine("Invalid input! Please choose a valid option.");
        }

        public void InvalidLoginCredentials() {
            Console.WriteLine("You have entered an incorrect username");
            Console.WriteLine("Please verify your credentials and try again.");
        }

    }
}