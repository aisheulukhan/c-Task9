using System;
using Task.Exceptions;

namespace Task.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string name = "";
            string surname = "";
            int age = 0;
            double salaryOfHour = 0;
            double workingHour = 0;
            double salary = 0;
            double IQRank = 0;
            double LanguageRank = 0;
            double ExamResult = 0;

            int key;
            do
            {
                Start:
                try
                {
                    Console.WriteLine("1.İşçinin maaşının hesablanması");
                    Console.WriteLine("2. Şagirdin imtahan balının ortalamanını hesablanması");
                    Console.WriteLine("Reqem daxil edin");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }
                switch (key)
                {
                    case 1:
                        InputEmployee(name, surname, age, ref workingHour, ref salaryOfHour);
                        Employee e = new Employee(name, surname, age, workingHour, salaryOfHour);
                        e.CalculateSalary(salaryOfHour, workingHour,salary);
                        break;
                    case 2:
                        InputStudent(name, surname, age, ref IQRank, ref LanguageRank);
                        Student stu = new Student(name, surname, age, IQRank, LanguageRank);
                        stu.ExamResult(LanguageRank, IQRank, ExamResult);
                        break;

                    default:
                        Console.WriteLine("Yanlış daxil etdiniz");
                        break;
                }

            } while (key !=3);
            static void InputEmployee(string name, string surname, int age, ref double workingHour, ref double salaryOfHour)
            {
                EName(name);
                ESurname(surname);
                EAge(age);
                EWorkingHour(ref workingHour);
                ESalaryOfHour(ref salaryOfHour);

            }
            static void EName(string name)
            {
                Console.WriteLine("İşçinin adını daxil edin");
                name = Convert.ToString(Console.ReadLine());
            }
            static void ESurname(string surname)
            {
                Console.WriteLine("İşçinin soyadını daxil edin");
                surname = Convert.ToString(Console.ReadLine());
            }
            static void EAge(int age)
            {
                Start:
                try
                {

                    Console.WriteLine("İşçinin yaşını daxil edin");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 18 || age > 64)
                    {
                        throw new NotAvailableException("İşləmək olmaz!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }
            } 

            static void EWorkingHour (ref double workingHour)
            {
                Start:
                try
                {
                    Console.WriteLine("Aylıq iş saatını daxil edin: ");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    if (workingHour < 0 || workingHour > 160 || (workingHour / 30) >= 8)
                    {
                        throw new NotAvailableException("Yalnış daxil edilib. Aylıq iş saatı 1 saatdan az və 160 saatdan çox ola bilməz!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }
            }

            static void ESalaryOfHour(ref double salaryOfHour)
            {
                Start:
                try
                {
                    Console.WriteLine("Hər saat başı qazanılan maaşı daxil edin: ");
                    salaryOfHour = Convert.ToDouble(Console.ReadLine());
                    if (salaryOfHour <= 1 || (salaryOfHour > 250))
                    {
                        throw new NotAvailableException("Maaş 250 Manatdan az olmamalıdır!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }

            }
            static void InputStudent(string name, string surname, int age, ref double IQRank, ref double LanguageRank)
            {

                SName(name);
                SSurname(surname);
                SAge(age);
                SIQRank(ref IQRank);
                SLanguageRank(ref LanguageRank);
            }
            static void SName(string name)
            {
                Console.WriteLine("Şagirdin adını daxil edin");
                name = Convert.ToString(Console.ReadLine());

            }

            static void SSurname(string surname)
            {
                Console.WriteLine("Şagirdin soyadını daxil edin");
                surname = Convert.ToString(Console.ReadLine());
            }
            static void SAge(int age)
            {
                Start:
                try
                {

                    Console.WriteLine("Sagirdin yasini daxil edin");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 6 || age > 20)
                    {
                        throw new NotAvailableException("Yaş düz daxil edilməyib!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }


            }
            static void SIQRank(ref double IQRank)
            {
                Start:
                try
                {

                    Console.WriteLine("IQ imtahan balınızı daxil edin: ");
                    IQRank = Convert.ToInt32(Console.ReadLine());
                    if (IQRank < 0 || IQRank > 100)
                    {
                        throw new NotAvailableException("İmtahan balınızı düzgün daxil edin!");
                    }
                    goto Start;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }

            }
            static void SLanguageRank(ref double LanguageRank)
            {
                Start:
                try
                {
                    Console.WriteLine("Dil imtahan bali");
                    LanguageRank = Convert.ToDouble(Console.ReadLine());
                    if (LanguageRank < 0 || LanguageRank > 100)
                    {
                        throw new NotAvailableException("İmtahan balınızı düzgün daxil edin!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnız rəqəm daxil olunmalıdır!");
                    goto Start;
                }


            }

        }

    }
}

