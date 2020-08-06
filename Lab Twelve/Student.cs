using System;
using System.Collections.Generic;
using System.Text;

namespace LabTwelve
{
    public class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;

        public string Program
        {
            get
            {
                return _program;
            }
            set
            {
                _program = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if(value > 0)
                {
                    _year = value;
                }
                else
                {
                    throw new FormatException("You entered an invalid input for year.");
                        
                }
            }
        }

        public double Fee
        {
            get
            {
                return _fee;
            }
            set
            {
                if (value > 0)
                {
                    _fee = value;
                }
                else
                {
                    throw new FormatException("You entered an invalid input for fee.");

                }
            }
        }


        public Student(string name, string address,string program, int year, double fee) : base (name, address)
        {
            base.Name = name;
            base.Address = address;
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"Student[{base.ToString()}, program = {Program}, year = {Year}, fee = {Fee}]";
        }
    }
}
