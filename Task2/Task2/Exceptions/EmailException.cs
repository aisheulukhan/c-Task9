using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exceptions
{
   public class EmailException:Exception
    {
        public EmailException(string message) : base(message) { }
    }
}
