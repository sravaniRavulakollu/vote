using System;

namespace vote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age<18)
            {
                Console.WriteLine("Not Allowed to vote");
            }
            else
            {
                Console.WriteLine("Allowed to vote");
            }


        }
    }
}
