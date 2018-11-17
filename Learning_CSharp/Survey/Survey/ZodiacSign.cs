using System;
using System.Collections.Generic;
using System.Text;

namespace Survey
{
    public class ZodiacSign
    {
        public void FindZodiac(string month)
        {
            switch (month.ToLower())
            {
                case "january":
                    Console.WriteLine("You are a Capricorn");
                    break;
                case "february":
                    Console.WriteLine("You are an Aquarius");
                    break;
                case "march":
                    Console.WriteLine("You are a Pices");
                    break;
                case "april":
                    Console.WriteLine("You are an Aries");
                    break;
                case "may":
                    Console.WriteLine("You are a Taurus");
                    break;
                case "june":
                    Console.WriteLine("You are a Gemini");
                    break;
                case "july":
                    Console.WriteLine("You are a Cancer");
                    break;
                case "august":
                    Console.WriteLine("You are a Leo");
                    break;
                case "september":
                    Console.WriteLine("You are a Virgo");
                    break;
                case "october":
                    Console.WriteLine("You are a Libra");
                    break;
                case "november":
                    Console.WriteLine("You are a Scorpio");
                    break;
                case "december":
                    Console.WriteLine("You are a Sagittarius");
                    break;
            }

        }
    }
}
