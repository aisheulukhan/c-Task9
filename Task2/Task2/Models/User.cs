using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Task2.Exceptions;

namespace Task2.Models
{
     class User : IAccount
    {
        private static int _id;
        private string _password;
        private string _fullName;
        private string _email;
        public string FullName { get; set; }
        public int Id
        {
            get;
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker( value))
                {
                    _password = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (EmailChecker(  value))
                {
                    _email = value;
                }
            }

        }
        public User(string email,  string password)
        {
            this.Email = email;
            this.Password = password;
            if (PasswordChecker( password))
            {
                _id++;
                Id = _id;
            }
        }
        public User (string email, string password, string fullName) : this(email, password)
        {
            this.FullName = fullName;
        }
        public static bool PasswordChecker( string password)
        {
            Regex regexpass = new Regex("^[A-Za-z0-9]{8,}$");
            Match match = regexpass.Match(password);
            if (match.Success)
            {
                return true;
            }
            else
            {
                throw new PasswordException("Şifrə yanlışdır!");
            }


        }
        public static bool EmailChecker(string email)
        {
            Regex regexemail = new Regex(@"^([^\W])([a-z\d\.\-_]+)@([a-z\d\-]+\.)([a-z]{2,3})$");
            Match match = regexemail.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                throw new EmailException("Email yalnışdır!");
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine($" Id - {Id}");
            Console.WriteLine($"Full Name - {FullName}");
            Console.WriteLine($"Email - {Email}");
            Console.WriteLine($"Password - {Password}");
        }

    }
}
