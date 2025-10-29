using System;
using System.Reflection.Metadata;

class Person
{
   public static void Main(string[] args)
    {
        Introduction introObject = new Introduction();
        introObject.intro();
        Calculator calObject = new Calculator();
        float ans = calObject.CalculateAnswer();
        Console.WriteLine($"Answer is {ans}");
    }
}
