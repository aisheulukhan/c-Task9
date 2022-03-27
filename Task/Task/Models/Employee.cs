using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class Employee:Person
    {
        private double _salaryOfHour;
        private double _workingHour;
        public double SalaryOfHour {
            get
            {
                return _salaryOfHour;
            }
            set
            {
                if ((value * _workingHour) >= 250)
                {
                     _salaryOfHour = value;
                }
            } 
        }
        public double WorkingHour {
            get
            {
                return _workingHour;
            }
            set
            {
                if (value <= 160 || (value / 30) <=8)
                {
                    _workingHour = value;
                }
            } 
        }

        public Employee (string name, string surname, int age, double salaryOfHour, double workingHour)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.SalaryOfHour = salaryOfHour;
            this.WorkingHour = workingHour;
        }

        public void CalculateSalary(double salaryOfaHour, double workingHour, double salary)
        {
            if ((salaryOfaHour * workingHour) > 250)
            {
                salary = salaryOfaHour * workingHour;

                Console.WriteLine($"Maaş: {salary}");
            }
            else
            {

                Console.WriteLine("Yanlışdır");
            }
        }

        
    }
}
