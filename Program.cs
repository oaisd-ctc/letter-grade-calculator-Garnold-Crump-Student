using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the number score you have in class.");
        double score = double.Parse(Console.ReadLine());
        if (score >= 100)
        {
            Console.WriteLine("Letter Grade: A+");
            Console.WriteLine("Wow! " + (score) + " That’s impressive! ");
        }

        if (score is > 90 and < 100)
        {
            Console.WriteLine("Letter Grade: A");
            Console.WriteLine("Very nice!");
        }

        if (score is > 80 and < 90)
        {
            Console.WriteLine("Letter Grade: B");
            Console.WriteLine(" Keep it up!");
        }

        if (score is > 70 and < 80)
        {
            Console.WriteLine("Letter Grade: C");
            Console.WriteLine("  You got this, keep working!");
        }


        if (score is > 60 and < 70)
        {
            Console.WriteLine("Letter Grade: D");
            Console.WriteLine(" Keep trying!");
        }

        if (score <= 59.99)
        {
            Console.WriteLine("Letter Grade: E");
            Console.WriteLine(" Don’t give up!");
        }



    }

}