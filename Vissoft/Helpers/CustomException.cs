﻿namespace Vissoft.Helpers
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}