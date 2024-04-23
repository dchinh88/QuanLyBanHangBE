using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelper
{
    public class CommonException : Exception
    {
        public int StatusCode { get; }

        public CommonException(string message, int statusCode) : base(message)
        {
            this.StatusCode = statusCode;
        }
        public CommonException(string message, int statusCode, Exception exception) : base(message, exception)
        {
            this.StatusCode = statusCode;
        }

    }
}
