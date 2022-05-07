using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBankAccount.Entities.Exceptions
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
