using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey! What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("What type of animal do you have?");
        string animalType = Console.ReadLine();
        Console.WriteLine("Who is your favorite singer?");
        string favoriteSinger = Console.ReadLine();

        Console.WriteLine($"One day,{userName} was listening to music on the way to work.");
        Console.WriteLine($"Deciding to stop to get food, {userName} runs into a {favoriteColor} cafe.");
        Console.WriteLine($"Inside the cafe, {favoriteSinger} is playing and {userName} feels right at home.");
        Console.WriteLine($"Just as {userName}  walking out, they notice a {animalType} and feel reminded of theirs!");
        Console.WriteLine($"Smiling,{userName} walks out and continues on to work."); // Note: Above is for Exercise #1 

        Console.WriteLine("Enter any number you like"); // Addition 
        int num1 = int.Parse(Console.ReadLine()); // int.Parse to recieve int input from console readline 
        Console.WriteLine("Give me a number to add to the first one");
        int num2 = int.Parse(Console.ReadLine());
        int result = Sum(num1, num2); //Calling the code into the main and making into a variable 
        Console.WriteLine($"The sum of {num1} and {num2} is {result}");

        Console.WriteLine("Enter a number");// Subtraction
        int numC = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a number to subtract by");
        int numD = int.Parse(Console.ReadLine());
        int answer = Difference(numC, numD);
        Console.WriteLine($"{numC} minus {numD} is {answer}");

        Console.WriteLine("Pick a number"); // Multiplication 
        int numX = int.Parse(Console.ReadLine());
        Console.WriteLine("Pick another to multiply by");
        int numY = int.Parse(Console.ReadLine()); 
        int product = Multiply(numX, numY); 
        Console.WriteLine($"{product} is the product of {numX} and {numY}");


        Console.WriteLine("Choose a number"); // Division 
        int numA = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a number to divide by");
        int numB = int.Parse(Console.ReadLine());
        int quotient = Divide(numA, numB);
        Console.WriteLine($"The quotient of {numA} and {numB} is {quotient}");



    }

    public static int Sum(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }
    public static int Multiply(int numX, int numY)
    {
        return numX * numY;
    }
    public static int Divide(int numA, int numB)
    {
        return numA / numB;
    }
    public static int Difference(int numC, int numD)
    {
        return numC - numD;
    }
    
}

