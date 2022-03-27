using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
     interface IAccount
    {
        
       static bool  PasswordChecker( string password)
        {
            return false;
        }
        void ShowInfo();
    }
}
