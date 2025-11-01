using System;
using System.Collections.Generic;


public class Passwordcheckandmanyotherthing
{
    public void Passwordchecker(){
        //day5
        //string str1 = "World";
        //string str2 = "World";

        // if (str1 == str2) check both value as well address

        // best practice when checking for values only
        //if (str1.Equals(str2))
        //{
        //    Console.WriteLine("same");

        //}
        //else { Console.WriteLine("diff"); }

        //char[] charArr = { 'W', 'o', 'r', 'l', 'd' };
        //object newCompare = new string(charArr);

        //if (newCompare.Equals(str1))
        //{
        //    // Equals checks literal values
        //    Console.WriteLine("same");
        //}
        //else { Console.WriteLine("diff"); }


        //string str1 = "Hi My name is Anuj Shukla";

        //for (int i = 0; i < str1.Length; i++)
        //{
        //    System.Threading.Thread.Sleep(200);
        //    Console.Write(str1[i]);
        //}
        //Console.WriteLine();

        // Console.WriteLine(str1.Contains("Anuj"));

        // Console.WriteLine(!string.IsNullOrEmpty(str1)); // check for both null and ""


        //watched how to reverse string 



        // passowd checker 

        // Ask user to enter password, and store
        //*Ask user to enter password again, and store *Check if they are both contain something *If so check if they are the same
        //* If they are, print "Passwords match"
        //* If they are not, print "Passwords do not match" * If they are empty, print "Please enter a password."

        //Console.Write("Enter the Password:");

        //string pass = Console.ReadLine();

        //Console.WriteLine();

        //bool flag = true;

        //while (flag)
        //{
        //    if (pass.Length < 8)
        //    {
        //        Console.WriteLine("Length of the password should be 8 or greater");
        //        Console.Write("Enter your Password: ");
        //        pass = Console.ReadLine();
        //    }
        //    else if (!pass.Any(char.IsUpper))
        //    {
        //        Console.WriteLine("Password must contain at least one uppercase letter");
        //        Console.Write("Enter your Password: ");
        //        pass = Console.ReadLine();

        //    }
        //    else if (!pass.Any(char.IsLower))
        //    {
        //        Console.WriteLine("Password must contain at least one lowercase letter");
        //        Console.Write("Enter your Password: ");
        //        pass = Console.ReadLine();

        //    }
        //    else
        //    {
        //        flag = false;
        //    }
        //}
        //Console.Write("re-enter the Password:");
        //string pass2 = Console.ReadLine();



        //while (pass2 != pass)
        //{
        //    Console.WriteLine("Password don't match re-enter the password");
        //    pass2 = Console.ReadLine();
        //}
        //Console.WriteLine("Your password is successfully saved");


        // ARRAY SORTED
        //int[] arr = new int[5] { 23, 234, 52, 2346, 62 };
        //Console.WriteLine(string.Join(", ", arr));
        //Array.Sort(arr);
        //Console.WriteLine();
        //Console.Write("sorted Array:");
        //Console.WriteLine(string.Join(", ", arr));
        //Array.Reverse(arr);
        //Console.WriteLine();
        //Console.WriteLine(String.Join(", ", arr));

        //List<int> list = new List<int>();
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        //list.Add(4);
        //System.FormatException
        //System.OverflowException
        //int listsize = list.Count;

        bool flag = true;
        while (flag)
        {
            try
            {
                Console.WriteLine("enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"your number is {num}");
                Console.WriteLine("bye bye mitro");
                flag = false;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Write Number only");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Write Number less than 2billion");
            }
            catch (Exception)
            {
                Console.WriteLine("unknown error");
            }
        }
    }
}
