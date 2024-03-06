using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FYPManagement
{
    internal class Utilities
    {
        public static bool IsAlphanumeric(string input)
        {
            string pattern = "^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsNumeric(string input)
        {
            string pattern = "^[0-9]+$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsEmail(string input)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsName(string input)
        {
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsPhone(string input)
        {
            string pattern = @"^(\d{4})-(\d{7})$";
            return Regex.IsMatch(input, pattern);
        }


    }
}
