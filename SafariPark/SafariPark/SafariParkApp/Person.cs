using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMovable 
    {
        // When creating a new Peron, before the approriate ctor is called
        // the private fields are set their default values
        protected string _firstName = "";
        //protected - field can only be accessed in class it is in or derived classes
        private string _lastName = "";



        //public int Age { get; set; }

        private int _age;
        public int Age
        {
            get =>   _age;
            set =>   _age = value < 0 ? throw new ArgumentException("Age cannot be less than 0") : value; // if age is less than 0 throw argument exeption otherwhise asign value 
        }

        public Person()
        {

        }

        // Has the same name as the class
        // Is used to construct the object
        // Has no return type - return type if the class type
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        //public Person(string fName, string lName, int age)
        //{
        //    _firstName = fName;
        //    _lastName = lName;
        //    Age = age;
        //}

        public Person(string fName)
        {
            _firstName = fName;
        }


        //If there are other constructors, a paramterless ctor
        //must be declared (if you want one)


        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        // You can only override methods which are marked as virtual
        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int items)
        {
            return $"Walking along {items} times";
        }

    }
}
