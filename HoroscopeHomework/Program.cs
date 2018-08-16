using System;

namespace HoroscopeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Please enter your birthdate:");

            //acquire user input as DateTime
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            //declare a string to use later
            string sign = "ERROR:0";

            //(I have no idea if this entire if/if-else statement can be done better.)
            //(I'm sure it can be... this is horribly inefficient and takes a long time.)
            //Determine the user's zodiac sign based on the month they were born
            //and whether they were born earlier or later than a certain date
            if (birthdate.Month == 1)
            {
                if (birthdate.Day <= 19)
                {
                    sign = "Capricorn";
                }
                else if (birthdate.Day >= 20)
                {
                    sign = "Aquarius";
                }
            }
            else if (birthdate.Month == 2)
            {
                if (birthdate.Day <= 18)
                {
                    sign = "Aquarius";
                }
                else if (birthdate.Day >= 19)
                {
                    sign = "Pisces";
                }
            }
            else if (birthdate.Month == 3)
            {
                if (birthdate.Day <= 20)
                {
                    sign = "Pisces";
                }
                else if (birthdate.Day >= 21)
                {
                    sign = "Aries";
                }
            }
            else if (birthdate.Month == 4)
            {
                if (birthdate.Day <= 19)
                {
                    sign = "Aries";
                }
                else if (birthdate.Day >= 20)
                {
                    sign = "Taurus";
                }
            }
            else if (birthdate.Month == 5)
            {
                if (birthdate.Day <= 20)
                {
                    sign = "Taurus";
                }
                else if (birthdate.Day >= 21)
                {
                    sign = "Gemini";
                }
            }
            else if (birthdate.Month == 6)
            {
                if (birthdate.Day <= 20)
                {
                    sign = "Gemini";
                }
                else if (birthdate.Day >= 21)
                    sign = "Cancer";
            }
            else if (birthdate.Month == 7)
            {
                if (birthdate.Day <= 21)
                {
                    sign = "Cancer";
                }
                else if (birthdate.Day >= 22)
                {
                    sign = "Leo";
                }
            }
            else if (birthdate.Month == 8)
            {
                if (birthdate.Day <= 22)
                {
                    sign = "Leo";
                }
                else if (birthdate.Day >= 23)
                {
                    sign = "Virgo";
                }
            }
            else if (birthdate.Month == 9)
            {
                if (birthdate.Day <= 22)
                {
                    sign = "Virgo";
                }
                else if (birthdate.Day >= 23)
                {
                    sign = "Libra";
                }
            }
            else if (birthdate.Month == 10)
            {
                if (birthdate.Day <= 22)
                {
                    sign = "Libra";
                }
                else if (birthdate.Day >= 23)
                {
                    sign = "Scorpio";
                }
            }
            else if (birthdate.Month == 11)
            {
                if (birthdate.Day <= 21)
                {
                    sign = "Scorpio";
                }
                else if (birthdate.Day >= 22)
                {
                    sign = "Sagittarius";
                }
            }
            else if (birthdate.Month == 12)
            {
                if (birthdate.Day <= 21)
                {
                    sign = "Sagittarius";
                }
                else if (birthdate.Day >= 22)
                {
                    sign = "Capricorn";
                }
            }

            //declare another string to use in a moment
            string fortune = "ERROR:1";

            //give the user a unique fortune depending on what we determined
            //their zodiac sign was
            //(Again, I'm sure there's a better way to do this...)
            if (sign == "Capricorn")
            {
                fortune = "You will live forever.";
            }
            else if (sign == "Aquarius")
            {
                fortune = "You will die next Monday.";
            }
            else if (sign == "Pisces")
            {
                fortune = "You will die next Tuesday.";
            }
            else if (sign == "Aries")
            {
                fortune = "You will die in a glorious battle.";
            }
            else if (sign == "Taurus")
            {
                fortune = "You will die next Wednesday.";
            }
            else if (sign == "Gemini")
            {
                fortune = "You will die in a mining accident.";
            }
            else if (sign == "Cancer")
            {
                fortune = "You will die next Thursday.";
            }
            else if (sign == "Leo")
            {
                fortune = "You will die next Friday.";
            }
            else if (sign == "Virgo")
            {
                fortune = "You will die next Saturday.";
            }
            else if (sign == "Libra")
            {
                fortune = "You will die next Sunday.";
            }
            else if (sign == "Scorpio")
            {
                fortune = "You will die in a programming accident.";
            }
            else if (sign == "Sagittarius")
            {
                fortune = "You will forget a semicolon in your next program but" +
                    " mysteriously it will work anyway.";
            }

            //write the birthdate we took from the user earlier
            Console.WriteLine("Your birthdate is: " + birthdate);
            //find the day of the week from that date
            Console.WriteLine("You were born on a " + birthdate.DayOfWeek + " and your next" +
                //add a year to the original birthdate, then find the day of the week
                " birthday will be on a " + birthdate.AddYears(1).DayOfWeek + ".");
            Console.Write("You are a");

            //will display "You are an..." instead of "You are a..."
            //if the user is an Aries or Aquarius
            if (sign == "Aries" || sign == "Aquarius")
            {
                Console.Write("n");
            }

            //text formatting
            Console.Write(" " + sign + ". ");

            //display the fortunes we made up earlier
            Console.WriteLine(fortune);

            //keep the program open
            Console.ReadLine();

        }
    }
}
