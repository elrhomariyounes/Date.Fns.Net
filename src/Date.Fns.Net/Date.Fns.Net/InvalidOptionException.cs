using System;
namespace Date.Fns.Net
{
    /// <summary>
    /// Exception for invalid options
    /// </summary>
    public class InvalidOptionException : Exception
    {
        public InvalidOptionException()
        {
        }

        public InvalidOptionException(string option, string value) : base(String.Format("Invalid value {0} for option {1}", value, option))
        {
        }
    }
}
