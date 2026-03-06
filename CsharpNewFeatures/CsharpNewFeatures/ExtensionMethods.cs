using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewFeatures
{
    public static class MyExtensionMethods
    {
        public static bool IsEven(this int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidEmail(this string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        
        
    }
}
