using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exceptions
{
   public class PasswordException :Exception
    {
        public PasswordException (string message): base(message) { }
    }
}
