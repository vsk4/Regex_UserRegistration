using System;
namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, lastName, Email,mobileNo,password;
            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();
            UserRegPattern pattern = new UserRegPattern();
            bool result1 = pattern.ValidateFirstName(firstName);
            Console.WriteLine("Validation Check for first name is : " + result1);
            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();
            bool result2 = pattern.ValidateLastName(lastName);
            Console.WriteLine("Validation Check for last name is " + result2);
            Console.WriteLine("Enter Email ID :");
            Email = Console.ReadLine();
            bool result3 = pattern.ValidateEmail(Email);
            Console.WriteLine("Validation Check for email :" + result3);
            Console.WriteLine("Enter Mobile Number");
            mobileNo = Console.ReadLine();
            bool result4 = pattern.ValidatemobileNo(mobileNo);
            Console.WriteLine("Validation Check for mobileNo :" + result4);
            Console.WriteLine("Enter Passoword");
            password = Console.ReadLine();
            bool result5 = pattern.ValidatePassword(password);
            Console.WriteLine("Validation for password :" + result5);
        }
    }
}