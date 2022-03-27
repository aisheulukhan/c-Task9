using System;

namespace Task2.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string fullname = "";
            string password = "";
            string email = "";
            int key;
            do
            {
                Start:
                try
                {
                    Console.WriteLine("Rəqəm daxil edin");
                    Console.WriteLine("1.Hesab yaradın");
                    Console.WriteLine("2.End");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }

                switch (key)
                {
                    case 1:
                        User user1;
                        InputFullName(ref fullname);
                        InputEmail(ref email);
                        Console.WriteLine(User.EmailChecker(email));
                        InputPassword(ref password);
                        Console.WriteLine(User.PasswordChecker(password));
                        user1 = new User(email, password, fullname);
                        user1.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("End");
                        break;
                    default:
                        Console.WriteLine("Yanlış daxil etdiniz");
                        break;
                }


            } while (key != 2);

            static void InputFullName(ref string fullname)
            {
                Start:
                try
                {
                    Console.WriteLine("Ad soyad daxil edin");
                    fullname = Convert.ToString(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Yalnız simvol daxil edilmelidir!");
                    goto Start;
                }
            }
            static void InputEmail(ref string email)
            {
                Console.WriteLine("Email daxil edin");
                email = Console.ReadLine();
            }
            static void InputPassword(ref string password)
            {
                Console.WriteLine("Şifrə daxil edin");
                password = Console.ReadLine();

            }

        }    
    }
}


