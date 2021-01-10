using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExcecoes.Exceptions
{
    class AccountExceptions : ApplicationException
    {
        public AccountExceptions(string message) : base(message){}
    }
}