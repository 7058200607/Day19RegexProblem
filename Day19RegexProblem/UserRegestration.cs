using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19RegexProblem
{
    public class UserRegestration
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Regex_EmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
        public static string Regex_PhoneNumber = ("^\\+?[1-9][0-9]{7,14}$");


        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        }
        public bool ValidateEmailId(string emailId)
        {
            return Regex.IsMatch(emailId, Regex_EmailId);
        }
        public bool ValidatePhoneNumber(string Phonenumber)
        {
            return Regex.IsMatch(Phonenumber, Regex_PhoneNumber);
        }
    }
}


