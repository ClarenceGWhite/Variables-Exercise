namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myDog;
                myDog = "Gracie";

            int myAge;
                myAge = 68;

            char myFirstLetter;
                myFirstLetter = 'A';

            bool myCollegeStatus;
                myCollegeStatus = true;

            double myStreetNumber;
                myStreetNumber = 9950;

            decimal myCurrentPocketChange;
                myCurrentPocketChange = 1.50m;

            Console.WriteLine($"My dog is named {myDog} and she lives at {myStreetNumber} Fountain Cir.");
            Console.WriteLine($"I am {myAge} years old and I have ${myCurrentPocketChange} in my pocket.");
            Console.WriteLine($"Am I essentially in college? {myCollegeStatus}!");
            Console.WriteLine("Hello, World!");
        }
    }
}