using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    internal class InvalidAgeforVotingException: Exception
    {
        public InvalidAgeforVotingException(string message) : base(message)
        {
            
        }
    }
}
