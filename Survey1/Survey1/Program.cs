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

            Console.WriteLine("What month were you born?");
            var MonthBorn = Console.ReadLine();

            Console.WriteLine("What day were you born?");
            var DayBorn = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Your Information:");
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your name is: {0}", Age);
            Console.WriteLine("Your name is: {0}\n", MonthBorn);


            Console.WriteLine("Your Zodiac Sign Is: ");
           
            switch (MonthBorn)
            {
                case "January":
                case "january":
                    if (DayBorn <= 19)
                    Console.WriteLine("Capircorn \n");
                    else if (DayBorn > 19)
                        Console.WriteLine("Aquarius \n ");
                    break;
                case "Febuary":
                case "febuary":
                    if (DayBorn <= 18)
                        Console.WriteLine("Aquarius \n");
                    else if (DayBorn > 19)
                        Console.WriteLine("Pisces \n ");
                    break;
                case "March":
                case "march":
                    if (DayBorn <= 20)
                        Console.WriteLine("Pisces \n");
                    else if (DayBorn > 20)
                        Console.WriteLine("Aries \n ");
                    break;
                case "April":
                case "april":
                    if (DayBorn <= 19)
                        Console.WriteLine("Aries \n");
                    else if (DayBorn > 20)
                        Console.WriteLine("Taurus \n ");
                    break;
                case "May":
                case "may":
                    if (DayBorn <= 20)
                        Console.WriteLine("Taurus \n");
                    else if (DayBorn > 20)
                        Console.WriteLine("Gemini \n ");
                    break;
                case "June":
                case "june":
                    if (DayBorn <= 20)
                        Console.WriteLine("Gemini \n");
                    else if (DayBorn > 20)
                        Console.WriteLine("Cancer \n ");
                    break;
                case "July":
                case "july":
                    if (DayBorn <= 22)
                        Console.WriteLine("Cancer \n");
                    else if (DayBorn > 22)
                        Console.WriteLine("Leo \n ");
                    break;
                case "August":
                case "august":
                    if (DayBorn <= 22)
                        Console.WriteLine("Leo \n");
                    else if (DayBorn > 22)
                        Console.WriteLine("Virgo \n ");
                    break;
                case "September":
                case "september":
                    if (DayBorn <= 22)
                        Console.WriteLine("Virgo \n");
                    else if (DayBorn > 22)
                        Console.WriteLine("Libra \n ");
                    break;
                case "October":
                case "october":
                    if (DayBorn <= 22)
                        Console.WriteLine("Libra \n");
                    else if (DayBorn > 22)
                        Console.WriteLine("Scorpio \n ");
                    break;
                case "November":
                case "november":
                    if (DayBorn <= 21)
                        Console.WriteLine("Scorpio \n");
                    else if (DayBorn > 21)
                        Console.WriteLine("Sagittarius \n ");
                    break;
                case "December":
                case "december":
                    if (DayBorn <= 21)
                        Console.WriteLine("Sagittarius \n ");
                    else if (DayBorn > 21)
                        Console.WriteLine("Capicorn \n");
                    break;
                default:
                    Console.WriteLine("Invalid Day or Month Input \nPlease Stay With In Date Range For Each Month \nThank you \n");
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

