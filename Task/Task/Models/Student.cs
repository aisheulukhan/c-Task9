using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class Student :Person
    {
        private double _iqRank;
        private double _languageRank;
        
        public double IQRank {
            get
            {
                return _iqRank;
            }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    _iqRank = value;
                }
            }
        }
        public double LanguageRank {
            get
            {
                return _languageRank;
            }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    _languageRank = value;
                }
            }
        }


        public void ExamResult(double LanguageRank, double IQRank, double ExamResult)
        {
            ExamResult = LanguageRank + IQRank;
            if ((LanguageRank + IQRank) >= 120)
            {
                
                Console.WriteLine($"{ExamResult} bal - İmtahandan keçdiniz");

            }
            else
            {
                Console.WriteLine($"{ExamResult} bal - İmtahandan kəsildiniz");
            }
        }
        public Student (string name, string surname, int age, double iqRank, double languageRank)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IQRank = iqRank;
            this.LanguageRank = languageRank;

        }
    }
}
