using System;

namespace Challenge_Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Password");
            var Password = Console.ReadLine();
            Console.ReadLine();
            if (Password == "hunter2")
            {
                Console.WriteLine("Access Granted");
            
            }
            else if (Password != "hunter2")
            {
                Console.WriteLine("Access Denied ");
            }
            Console.WriteLine();


            Console.WriteLine("Press Any key to exit......");
            Console.ReadKey();

        }
    }
}
