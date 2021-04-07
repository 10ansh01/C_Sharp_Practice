using System;


    public class Program
    {
        public enum Days
        {
            Sunday, 
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday
        }
        public static void Main()
        {
            Console.WriteLine("Read values of the Color enum");
            foreach (Days day in Enum.GetValues(typeof(Days)))
                Console.WriteLine(day);
        }
    }

