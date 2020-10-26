using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch1
{
    class CustomException : Exception
    {
        int Retries { get;  }
        public string ErrorMessage { get; private set; }

        public CustomException(int numberOfRetries)
        {
            Retries = numberOfRetries;
            ErrorMessage = $"Max number of retries exceeded. Max allowed is {Retries}";
        }
    }
}
