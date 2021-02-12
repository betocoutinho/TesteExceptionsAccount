using System;
using System.Collections.Generic;
using System.Text;

namespace TesteExceptionsAccount.Entities.Exceptions
{
    class ExceptionAccount : ApplicationException
    {
        public ExceptionAccount(string message) : base(message)
        {

        }
    }
}
