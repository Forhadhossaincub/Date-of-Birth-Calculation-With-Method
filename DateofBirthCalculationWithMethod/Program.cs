using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateofBirthCalculationWithMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InputUserDetails();

            Console.ReadKey();

        }
        public static void InputUserDetails()
        {
            Console.Write("Your Name: ");
            string name = Console.ReadLine();


            Console.Write("Your Date of Birth :");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            int ageYear = Age(dob);
            Console.WriteLine($"Mr. {name} age is {ageYear} years.");
        }
        public static int Age(DateTime dob)
        {
            int year = (DateTime.Now - dob).Days / 365;
            return year;
        }
    }
}
