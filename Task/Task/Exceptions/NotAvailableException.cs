using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Exceptions
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException(string message) : base(message) { }
    }
}
