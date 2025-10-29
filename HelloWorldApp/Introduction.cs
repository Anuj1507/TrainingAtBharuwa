using System;

 public class Introduction
{

    public void intro()
    {
        const string name = "Anuj";
        int age = 23;
        char personality = 'A';
        bool intern = true;
        double salary = 740000000.0000D;

        Console.WriteLine($"My name is {name}, I am {age} years old, and it is {intern} that I am an intern at Bharuwa Solutions. I have an {personality}-type personality, and my salary is ₹{salary}.");

        Console.Write("Rate this out of 10: ");
        int rating = Convert.ToInt32(Console.ReadLine());
        int myRating = 3;
        int max_rating = Math.Max(rating, myRating);
        if (max_rating == rating)
        {
            Console.WriteLine($"You rated me {rating} out of 10.I have rated my self {myRating} so Thank you to rate me more than my exceptation.");
        }

        else if (myRating == rating)
        {
            Console.WriteLine($"You rated me {rating} out of 10.I also rated my self {myRating}  which mean  I Rightly judge myself but i need to improve. Thank you");
        }
        else
        {
            Console.WriteLine($"You rated me {rating} out of 10. I have rated my self {myRating}  which mean i need to improve more than my exception. Thank you");
        }
    }
}