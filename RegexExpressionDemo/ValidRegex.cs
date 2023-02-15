using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpressionDemo
{
    public class ValidRegex
    {
        public static void PinValidation()
        {
            string pattern = "^[0-9]{3}[ ]?[0-9]{3}$";
            string[] input = { "400088", "A400088", "400088B","400 088" };
            Validation(input, pattern);
        }
        public static void EmailIdValidation()
        {
            // string pattern = "^[abc.]*[a-z0-9]{3}[@]?[bridgelabz]*[.]?[co]*[.]?[a-z]{2,}$";//"abc.xyz@bridgelabz.co.in
            string pattern = "^[abc]*([-+.]{1}[a-z0-9]{3}){0,1}[@]?[a-z]{2,}[.com]*$";

            string[] input = {  "abc-100@yahoo.com", "abc.100@yahoo.com", "abc@yahoo.com" };
            Validation(input, pattern);
        }
        public static void NameValidation()
        {
            string pattern = "^[0-9}*[a-zA-Z]{3,}[a-zA-z0-9]*$";
            string[] input = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1ABB23A" };
            Validation(input, pattern);
        }
        public static void Validation(string[]input,string pattern)
        {
            foreach(string inputItem in input)
            {
                if (Regex.IsMatch(inputItem, pattern))
                {
                    Console.WriteLine("{0} valid ",inputItem);
                }
                else
                {
                    Console.WriteLine("{0} Invalid ", inputItem);
                }
            }
        }
    }
}
