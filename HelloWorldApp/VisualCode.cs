using System;
class VisualCode
{
 public void Vcfun()
    {
        // Console.WriteLine("Hello,World!");
     //Console.WriteLine(int.MinValue);
     //Console.WriteLine(int.MaxValue);

     // Converting String to int 

     //string name = "-21";

     //int num = Convert.ToInt32(name);

     //Console.WriteLine(num);


     //String flotnum = "2.34";
     //float num = Convert.ToSingle(flotnum);
     //Console.WriteLine(num);


     //float formnum = 7.23312334F;


     //Console.WriteLine(string.Format("{0:0.00}",formnum));
     //Console.WriteLine(string.Format("{formnum:0.00}"));


     // frizz and buzz game 

     Console.WriteLine("Welcome to frizz buzz game\n");

     {
         for (int i = 0; i < 10; i++)
         {
             Console.Write("Enter numer: ");
             int num = Convert.ToInt32(Console.ReadLine());
             if (num % 5 == 0 && num % 3 == 0)
             {
                 Console.WriteLine("fizz buzz");
             }
             else if (num % 5 == 0)
             {
                 Console.WriteLine("fizz");

             }
             else if (num % 3 == 0)
             {
                 Console.WriteLine("buzz");

             }
             else
             {
                 Console.WriteLine(num);
             }
         }
     }
    }
 }
