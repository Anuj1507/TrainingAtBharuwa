using System;

class Calculator
{
    public float CalculateAnswer()
    {
        Console.WriteLine("Hi I am mini Calculator, I can do Sum,Subtraction, Multiplicaton and division.\nKindly Provide me two numbers and the operation you want to perform.");
        
        Console.Write("Enter first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Now want you want me to do with this two number choose from the menu\n1)Sum\n2)Subtraction\n3)multiplication\n4)divide");

        int operation = Convert.ToInt32(Console.ReadLine());
        
        if(num2==0 && operation==4)
        {
            Console.WriteLine($"you can't divide {num1} by {num2} ");   
        }

        switch (operation)
        {
            case 1:
                {
                    return num1 + num2;

                }
            case 2:
                {
                    return num1 - num2;
                }
            case 3:
                {
                    return num1 * num2;
                }
            case 4:
                {
                    return num1 / num2;
                }
            default:
                Console.WriteLine("Invalid operation selected!");
                return 0;
        }
        
    }
}
                    
                