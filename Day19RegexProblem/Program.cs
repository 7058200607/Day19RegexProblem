using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19RegexProblem
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Regestration Using Regex");
            UserRegestration userRegestration = new UserRegestration();
            Console.WriteLine("Enter Your First Name :");
            string FirstName = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidateFirstName(FirstName));


            Console.WriteLine("Enter Your Last Name :");
            string LastName = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidateFirstName(LastName));

            Console.WriteLine("Enter Your EmailID :");
            string EmailId = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidateEmailId(EmailId));

            Console.WriteLine("Enter Your Phone Number :");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidatePhoneNumber(PhoneNumber));

            Console.WriteLine("Enter Your Passward1 Number :");
            string Passward1 = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidatePassward1(Passward1));

            Console.WriteLine("Enter Your Passward2 Number :");
            string Passward2 = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidatePassward2(Passward2));

            Console.WriteLine("Enter Your Passward3 Number :");
            string Passward3 = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidatePassward3(Passward3));

            Console.WriteLine("Enter Your Passward4 Number :");
            string Passward4 = Console.ReadLine();
            Console.WriteLine(userRegestration.ValidatePassward4(Passward4));

        }

         
    }
}