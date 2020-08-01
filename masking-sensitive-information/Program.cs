using System;

namespace masking_sensitive_information
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's learn about masking information.");
                    Console.WriteLine("\n");

            Console.WriteLine("First, enter a completly made up 10-digit number to your top secret offshore account.");
                    Console.WriteLine("\n");


            var userEnteredTenDigitNumber = Console.ReadLine();

            var convertedAccountNumber = Int32.Parse(userEnteredTenDigitNumber);


            do
            {
                Console.WriteLine("Enter a 10-digit number with no letters or characters.");
                userEnteredTenDigitNumber = Console.ReadLine();
                Console.WriteLine("\n");
            }

            while (userEnteredTenDigitNumber.Length != 10);
            {
                Console.WriteLine("Excellent. Let's move on.");
                Console.WriteLine("\n");

            }


            var maskedAccountNumber = userEnteredTenDigitNumber.Substring(6, 4);

            Console.WriteLine($"You entered: '{userEnteredTenDigitNumber}' and your maskedAccountNumber would be: XXXXXX{maskedAccountNumber}");
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
