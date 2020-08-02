using System;

namespace masking_sensitive_information
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a secret and we'll conceal it while only showing the last four digits.");
            Console.WriteLine("\n");



            var usersSecret = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine($"You typed '{usersSecret}. Oh no. It's not concealed. How about this?'");
            Console.WriteLine("\n");



            var lengthOfSecret = usersSecret.Length;



            var lengthOfSecretMinusFour = usersSecret.Length - 4;



            string redacted = new string('*', lengthOfSecretMinusFour);



            Console.WriteLine($"the 'redacted' variable returns '{redacted}'");
            Console.WriteLine("\n");



            var lastFourOfSecret = usersSecret.Substring(usersSecret.Length - 4, 4);



            Console.WriteLine($"The variable 'lastFourOfSecret' returns '{lastFourOfSecret}'");
            Console.WriteLine("\n");



            string redactedAndExposedCombined = redacted + lastFourOfSecret;



            Console.WriteLine($"When we recombine both of those variables we get {redactedAndExposedCombined}");
            Console.WriteLine("\n");




            // how do i print a certain number of * to replace the first part of the secrete while exposing the last four parts using the variable above






            Console.ReadKey();



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
