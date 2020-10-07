
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    class UserRegPattern
    {
        string firstNameRegex = "[A-Z]{1}[A-Za-z]{2,}";
        string lastNameRegex = "[A-Z]{1}[A-Za-z]{2,}";
        string emailRegex = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNameRegex);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, firstNameRegex);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, emailRegex);
        }
    }
}