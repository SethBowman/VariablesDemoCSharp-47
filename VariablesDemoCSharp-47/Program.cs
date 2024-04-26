namespace VariablesDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Number types
            //Declaring a variable (create a variable)
            //Camel case - everyNextWordStartsWithCaptital
            int wholeNumber;

            //Initializing a variable (giving it a value)
            wholeNumber = 5;

            //Or do both
            //Declaring and initializing
            int otherNumber = 10;

            otherNumber = 40;

            double average = 99.99;

            decimal myWallet = 500.00m;

            //Word types

            string ourClass = "CSharp-47";

            char key = '1';

            //Fact type

            bool isCoding = true;

            //String interpolation
            //string message = $"Our class is {ourClass}";

            //Console.WriteLine($"Our class is {ourClass}");

            //Take user input

            Console.WriteLine("Give me your name:");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}");

            

        }
    }
}
