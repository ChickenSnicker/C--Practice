using System;

namespace Survey1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var Age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var MonthBorn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your Information:");
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your name is: {0}", Age);
            Console.WriteLine("Your name is: {0}\n", MonthBorn);

            Console.WriteLine("Your Zodiac Sign Is: ");
            switch(MonthBorn)
            {
                case "January":
                    Console.WriteLine("Aquarius \n ");
                    break;
                case "Febuary":
                    Console.WriteLine("Pisces \n ");
                    break;
                case "March":
                    Console.WriteLine("Aries  \n");
                    break;
                case "April":
                    Console.WriteLine("Taurus \n");
                    break;
                case "May":
                    Console.WriteLine("Gemini \n");
                    break;
                case "June":
                    Console.WriteLine("Cancer \n");
                    break;
                case "July":
                    Console.WriteLine("Leo \n");
                    break;
                case "August":
                    Console.WriteLine("Virgo \n");
                    break;
                case "September":
                    Console.WriteLine("Libra /n");
                    break;
                case "October":
                    Console.WriteLine("Scorpio \n");
                    break;
                case "November":
                    Console.WriteLine("Sagittarius \n");
                    break;
                case "December":
                    Console.WriteLine("Capicorn \n");
                    break;



                default:
                    Console.WriteLine("Invalid Input \n");
                    break;

            }
           Console.WriteLine();




           Console.WriteLine("Press Any key to exit......");
           Console.ReadKey();


            // OLD CODE FOR SURVEY
            //if (MonthBorn == "January")
            //{
            //    Console.WriteLine("You are a Aquarius.\n ");

            //}
            //else if (MonthBorn == "Febuary")
            //{
            //    Console.WriteLine("You are a Pisces.\n ");

            //}
            //else if (MonthBorn == "March")
            //{
            //    Console.WriteLine("You are an Aries.\n ");

            //}
            //else if (MonthBorn == "April")
            //{
            //    Console.WriteLine("You are a Taurus.\n ");

            //}
            //else if (MonthBorn == "May")
            //{
            //    Console.WriteLine("You are a Gemini.\n ");

            //}
            //else if (MonthBorn == "June")
            //{
            //    Console.WriteLine("You are a Cancer.\n ");

            //}
            //else if (MonthBorn == "July")
            //{
            //    Console.WriteLine("You are a Leo.\n ");

            //}
            //else if (MonthBorn == "August")
            //{
            //    Console.WriteLine("You are a Virgo.\n ");

            //}
            //else if (MonthBorn == "September")
            //{
            //    Console.WriteLine("You are an Libra.\n ");

            //}
            //else if (MonthBorn == "October")
            //{
            //    Console.WriteLine("You are a Scorpio.\n ");

            //}
            //else if (MonthBorn == "November")
            //{
            //    Console.WriteLine("You are an Sagittarius.\n ");

            //}
            //else if (MonthBorn == "December")
            //{
            //    Console.WriteLine("You are a Capricorn.\n ");

        }
        //Console.WriteLine();




        //Console.WriteLine("Press Any key to exit......");
        //Console.ReadKey();



    }
    }

