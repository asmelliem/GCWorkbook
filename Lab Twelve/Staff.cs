using System;
using System.Collections.Generic;
using System.Text;

namespace LabTwelve
{
    public class Staff : Person
    {
        private string _school;
        private double _pay;

        public string School
        {
            get
            {
                return _school;
            }
            set
            {
                _school = value;
            }
        }

        public double Pay
        {
            get
            {
                return _pay;
            }
            set
            {
                if(value >= 0)
                {
                    _pay = value;
                }
                else
                {
                    throw new FormatException("You did not enter a valid input for pay.");
                }
            }
        }

        public Staff(string name, string address, string school, double pay) : base (name, address)
        {
            base.Name = name;
            base.Address = address;
            this.School = school;
            this.Pay = pay;            
        }

        public Staff()
        {

        }

        public override string ToString()
        {
            return $"Staff[{base.ToString()}],school = {School}, pay = {Pay}]";
        }

    }
}
