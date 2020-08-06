using System;
using System.Collections.Generic;
using System.Text;

namespace LabTwelve
{
    public class Person
    {
        private string _name;
        private string _address;


        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public Person()
        { }

        public virtual string ToString()
        {
            return $"Person[name = {Name}, address = {Address}]";
        }
    }
}
