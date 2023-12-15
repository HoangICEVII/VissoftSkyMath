using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.Helper
{
    public class CustomException : Exception
    {
        public string Message { get; }
        public int StatusCode { get; }

        public CustomException(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
